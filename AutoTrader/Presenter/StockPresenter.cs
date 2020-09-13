using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Diagnostics;
using AutoTrader.View;
using AutoTrader.Model;
using AxKHOpenAPILib;
using System.Globalization;

namespace AutoTrader.Presenter
{
    public class StockPresenter
    {
        private readonly IMainView mainView;
        private readonly IConditionView conditionView;
        private readonly IDisclosureView disclosureView;
        private readonly APIExtention apiModel;
        
        List<PriceInfo> priceInfoList = new List<PriceInfo>();

        public StockPresenter(IMainView _mainView, IConditionView _conditionView, IDisclosureView _disclosureView)
        {
            mainView = _mainView;
            conditionView = _conditionView;
            disclosureView = _disclosureView;
            mainView.Presenter = this;
            conditionView.Presenter = this;
            disclosureView.Presenter = this;
            apiModel = (APIExtention)mainView.kHOpenAPI;
        }

        #region Request
        public void RequestTermChart(string currentStockCode, string termUnit)
        {
            apiModel.SetInputValue("종목코드", currentStockCode);
            apiModel.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            apiModel.SetInputValue("수정주가구분", "1");

            string rqName = "";
            string trCode = "";

            if (termUnit == "DAY")
            {
                rqName = "주식일봉차트조회";
                trCode = "OPT10081";
            }
            else if(termUnit == "WEEK")
            {
                rqName = "주식주봉차트조회";
                trCode = "OPT10082";
            }
            else if (termUnit == "MONTH")
            {
                rqName = "주식월봉차트조회";
                trCode = "OPT10083";
            }
            else
            {
                Debug.Assert(false);
            }

            int nRet = apiModel.CommRqData(rqName, trCode, 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 일봉 정보요청 성공");
            else
                Console.WriteLine("주식 일봉 정보요청 실패");
        }
        
        public void RequestMinuteChart(string currentStockCode, int minuteUnit)
        {
            if(minuteUnit > 60)
            {
                minuteUnit = 60;
            }
            apiModel.SetInputValue("종목코드", currentStockCode);
            apiModel.SetInputValue("틱범위", minuteUnit + "");
            apiModel.SetInputValue("수정주가구분", "1");

            int nRet = apiModel.CommRqData("주식분봉차트조회", "OPT10080", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 분봉 정보요청 성공");
            else
                Console.WriteLine("주식 분봉 정보요청 실패");
        }

        public void RequestTickChart(string currentStockCode, int tickUnit)
        {
            apiModel.SetInputValue("종목코드", currentStockCode);
            apiModel.SetInputValue("틱범위", tickUnit.ToString());
            apiModel.SetInputValue("수정주가구분", "1");

            int nRet = apiModel.CommRqData("주식틱봉차트조회", "OPT10079", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 틱봉 정보요청 성공");
            else
                Console.WriteLine("주식 틱봉 정보요청 실패");
        }

        public void RequestStockInfo(string currentStockCode)
        {
            apiModel.SetInputValue("종목코드", currentStockCode);

            int nRet = apiModel.CommRqData("주식기본정보요청", "OPT10001", 0, "1003");

            if (nRet == 0)
                Console.WriteLine("주식기본정보요청 성공");
            else
                Console.WriteLine("주식기본정보요청 실패");
        }

        public void RequestOrderBook(string currentStockCode)
        {
            apiModel.SetInputValue("종목코드", currentStockCode);

            int nRet = apiModel.CommRqData("주식호가정보요청", "OPT10004", 0, "1004");

            if (nRet == 0)
                Console.WriteLine("주식호가정보요청 성공");
            else
                Console.WriteLine("주식호가정보요청 실패");
        }

        public void RequestTotalAsset(string accountNum, string password)
        {
            apiModel.SetInputValue("계좌번호", accountNum);
            apiModel.SetInputValue("비밀번호", password);
            apiModel.SetInputValue("비밀번호입력매체구분", "00");
            apiModel.SetInputValue("조회구분", "1");

            int nRet = apiModel.CommRqData("계좌평가잔고내역요청", "OPW00018", 0, "1005");

            if (nRet == 0)
                Console.WriteLine("계좌평가잔고내역요청 성공");
            else
                Console.WriteLine("계좌평가잔고내역요청 실패");
        }

        public void RequestAsset(string accountNum, string password)
        {
            apiModel.SetInputValue("계좌번호", accountNum);
            apiModel.SetInputValue("비밀번호", password);
            apiModel.SetInputValue("상장폐지조회구분", "0");
            apiModel.SetInputValue("비밀번호입력매체구분", "00");

            int nRet = apiModel.CommRqData("계좌평가현황요청", "OPW00004", 0, "1006");

            if (nRet == 0)
                Console.WriteLine("계좌평가현황요청 성공");
            else
                Console.WriteLine("계좌평가현황요청 실패");
        }

        public void RequestNaverUrl(string stockCode)
        {
            Process.Start("https://finance.naver.com/item/main.nhn?code=" + stockCode);
        }

        public void RequestPaxnetUrl(string stockCode)
        {
            Process.Start("http://www.paxnet.co.kr/stock/analysis/main?abbrSymbol=" + stockCode);
        }
        
        public void RequestNewsUrl(string stockCode, string beginDate, string endDate)
        {
            string stockName = apiModel.GetMasterCodeName(stockCode);
            beginDate = beginDate.Replace('-', '.');
            endDate = endDate.Replace('-', '.');
            Process.Start("https://search.naver.com/search.naver?where=news&query=" + stockName + "&pd=3&ds=" + beginDate + "&de=" + endDate);
        }

        public void RequestDart(string stockCode, string beginDate, string endDate)
        {
            DartApi.RequestDisclosure(stockCode, beginDate, endDate, out List<DisclosureInfo> infolist);
            SetDisclosureView(infolist);
        }

        public void RequestDartViewer(string rceptNum)
        {
            DartApi.RequestViewer(rceptNum);
        }
        #endregion

        #region Update
        public void UpdateStockInfo(int totalStock, double distribRatio, double per, double eps, double roe, double pbr, double ev)
        {
            mainView.TotalStockLabel.Text = totalStock + "억";
            mainView.DistribRatioLabel.Text = string.Format("{0:F2}%", distribRatio);
            mainView.PerLabel.Text = string.Format("{0:F2}", per);
            mainView.EpsLabel.Text = string.Format("{0:F2}", eps);
            mainView.RoeLabel.Text = string.Format("{0:F2}", roe);
            mainView.PbrLabel.Text = string.Format("{0:F2}", pbr);
            mainView.EvLabel.Text = string.Format("{0:F2}", ev);
        }

        public void UpdateOrderBook(List<BidAskSpread> AskSpreadList, List<BidAskSpread> BidSpreadList)
        {
            mainView.AskSeries.Points.Clear();
            foreach (BidAskSpread Ask in AskSpreadList)
            {
                mainView.AskSeries.Points.AddXY(Ask.Price, Ask.Amount);
            }
            foreach (BidAskSpread Bid in BidSpreadList)
            {
                mainView.BidSeries.Points.AddXY(Bid.Price, Bid.Amount);
            }
        }

        public void UpdateChartAxis(int startPosition, int endPosition)
        {
            try
            {
                int max = 0;
                int min = int.MaxValue;

                int volumeMax = 0;
                int volumeMin = int.MaxValue;

                for (int i = startPosition - 1; i < endPosition; i++)
                {
                    if (i >= priceInfoList.Count)
                        break;
                    if (i < 0)
                        i = 0;

                    if (priceInfoList[i].Highest > max)
                        max = priceInfoList[i].Highest;
                    if (priceInfoList[i].Lowest < min)
                        min = priceInfoList[i].Lowest;

                    if (priceInfoList[i].Volume > volumeMax)
                        volumeMax = priceInfoList[i].Volume;
                    if (priceInfoList[i].Volume < volumeMin)
                        volumeMin = priceInfoList[i].Volume;
                }

                double offset = 0.2 * (max - min);
                mainView.MainChart.ChartAreas[0].AxisY.Maximum = max + offset;
                mainView.MainChart.ChartAreas[0].AxisY.Minimum = min - offset;

                double volumeOffset = 0.2 * (volumeMax - volumeMin);
                mainView.MainChart.ChartAreas[1].AxisY.Maximum = volumeMax + volumeOffset;
                if (volumeMin - volumeOffset > 0)
                    mainView.MainChart.ChartAreas[1].AxisY.Minimum = volumeMin - volumeOffset;
                else
                    mainView.MainChart.ChartAreas[1].AxisY.Minimum = 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message.ToString());
            }
        }

        public void SetChartInfo(string trCode, string rqName)
        {
            apiModel.SetRequestType(trCode, rqName);

            string stockCode = apiModel.GetRequestValue<string>("종목코드");

            RequestStockInfo(stockCode);
            RequestOrderBook(stockCode);

            mainView.PriceSeries.Points.Clear();
            mainView.VolumeSeries.Points.Clear();
            mainView.IndicatorSeries.Points.Clear();

            if (rqName == "주식분봉차트조회" || rqName == "주식틱봉차트조회")
            {
                mainView.MainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0";
            }
            else
            { 
                mainView.MainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";
            }

            ParseChartData(trCode, rqName, out int minValue, out int maxValue);
            MergeTimeSeries();
            SetChartSeries(minValue, maxValue);
        }

        public void ParseChartData(string trCode, string rqName, out int minValue, out int maxValue)
        {
            priceInfoList.Clear();
            int nCnt = apiModel.GetRepeatCnt(trCode, rqName);
            maxValue = 0;
            minValue = int.MaxValue;

            for (int nIdx = 0; nIdx < nCnt; nIdx++)
            {
                PriceInfo entity = new PriceInfo();

                if (rqName == "주식분봉차트조회" || rqName == "주식틱봉차트조회")
                {
                    string strDate = apiModel.GetRequestValue<string>("체결시간", nIdx);
                    entity.Date = DateTime.ParseExact(strDate, "yyyyMMddHHmmss", null).ToShortDateString();
                    entity.Start = Math.Abs(apiModel.GetRequestValue<int>("시가", nIdx));
                    entity.Highest = Math.Abs(apiModel.GetRequestValue<int>("고가", nIdx));
                    entity.Lowest = Math.Abs(apiModel.GetRequestValue<int>("저가", nIdx));
                    entity.End = Math.Abs(apiModel.GetRequestValue<int>("현재가", nIdx));
                }
                else
                {
                    string strDate = apiModel.GetRequestValue<string>("일자", nIdx).Trim();
                    entity.Date = DateTime.ParseExact(strDate, "yyyyMMdd", null).ToShortDateString();
                    entity.Start = apiModel.GetRequestValue<int>("시가", nIdx);
                    entity.Highest = apiModel.GetRequestValue<int>("고가", nIdx);
                    entity.Lowest = apiModel.GetRequestValue<int>("저가", nIdx);
                    entity.End = apiModel.GetRequestValue<int>("현재가", nIdx);
                }

                entity.Volume = apiModel.GetRequestValue<int>("거래량", nIdx);
                priceInfoList.Add(entity);

                if (entity.Highest > maxValue)
                    maxValue = entity.Highest;
                if (entity.Lowest < minValue)
                    minValue = entity.Lowest;
            }

        }

        public void MergeTimeSeries()
        {
            if (mainView.SelectedMinuteUnit > 60)
            {
                List<PriceInfo> mergedInfoList = new List<PriceInfo>();
                int stride = mainView.SelectedMinuteUnit / 60;

                for (int nIdx = 0; nIdx < priceInfoList.Count; nIdx += stride)
                {
                    PriceInfo mergedInfo = new PriceInfo();

                    // 4시간봉 관련하여 임시 처리 
                    if (stride == 4)
                    {
                        stride = 3;
                    }
                    else if (stride == 3)
                    {
                        stride = 4;
                    }
                    // 인덱스 초과 처리
                    if (priceInfoList.Count <= nIdx + stride)
                    {
                        stride = priceInfoList.Count - nIdx;
                    }

                    for (int n = 0; n < stride; n++)
                    {
                        mergedInfo.Volume += priceInfoList[nIdx + n].Volume;

                        if (n == 0)
                        {
                            mergedInfo.End = priceInfoList[nIdx + n].End;
                            mergedInfo.Highest = priceInfoList[nIdx + n].Highest;
                            mergedInfo.Lowest = priceInfoList[nIdx + n].Lowest;
                        }
                        if(n == stride - 1)
                        {
                            mergedInfo.Date = priceInfoList[nIdx + n].Date;
                            mergedInfo.Start = priceInfoList[nIdx + n].Start;
                        }

                        if (mergedInfo.Highest < priceInfoList[nIdx + n].Highest)
                        {
                            mergedInfo.Highest = priceInfoList[nIdx + n].Highest;
                        }
                        if(mergedInfo.Lowest > priceInfoList[nIdx + n].Lowest)
                        {
                            mergedInfo.Lowest = priceInfoList[nIdx + n].Lowest;
                        }
                    }
                    mergedInfoList.Add(mergedInfo);
                }
                priceInfoList = mergedInfoList;
            }

        }

        public void SetChartSeries(int minValue, int maxValue)
        {
            for (int nIdx = 0; nIdx < priceInfoList.Count; nIdx++)
            {
                PriceInfo entity = priceInfoList[nIdx];
                // adding date and high
                mainView.PriceSeries.Points.AddXY(entity.Date, entity.Highest);
                mainView.PriceSeries.Points[nIdx].YValues[1] = entity.Lowest;
                mainView.PriceSeries.Points[nIdx].YValues[2] = entity.Start;
                mainView.PriceSeries.Points[nIdx].YValues[3] = entity.End;
                mainView.PriceSeries.Points[nIdx].ToolTip = entity.ToString();
                mainView.VolumeSeries.Points.AddXY(entity.Date, entity.Volume);
                mainView.VolumeSeries.Points[nIdx].Color = Color.FromArgb(128, 0, 40, 250);
                mainView.VolumeSeries.Points[nIdx].ToolTip = "일자 : " + entity.Date + "\n"
                                                    + "거래량 : " + String.Format("{0:#,###}", entity.Volume);
            }

            ChartArea priceChartArea = mainView.MainChart.ChartAreas["PriceChartArea"];

            if (priceInfoList.Count > 0)
            {
                priceChartArea.AxisX.ScaleView.ZoomReset();

                priceChartArea.AxisY.Maximum = maxValue;
                priceChartArea.AxisY.Minimum = minValue;

                if (!priceChartArea.AxisX.ScaleView.IsZoomed)
                {
                    int startPosition = (int)priceChartArea.AxisX.ScaleView.ViewMinimum;
                    int endPosition = (int)priceChartArea.AxisX.ScaleView.ViewMaximum;
                    UpdateChartAxis(startPosition, endPosition);
                    SetViewPeriod(startPosition, endPosition);
                }

                HighlightArea(HighlightOption.MFI);
            }

        }

        public void SetViewPeriod(int startPosition, int endPosition)
        {
            DataPoint end = mainView.PriceSeries.Points.ElementAtOrDefault(startPosition);
            DataPoint begin = mainView.PriceSeries.Points.ElementAtOrDefault(endPosition);
            if (begin == null)
            {
                mainView.BeginDate = mainView.PriceSeries.Points.LastOrDefault().AxisLabel;
            }
            else
            {
                mainView.BeginDate = begin.AxisLabel;
            }
            if (end == null)
            {
                mainView.EndDate = mainView.PriceSeries.Points.FirstOrDefault().AxisLabel;
            }
            else
            {
                mainView.EndDate = end.AxisLabel;
            }
        }

        public void HighlightArea(HighlightOption option)
        {
            if ((option & HighlightOption.MFI) == HighlightOption.MFI)
            {
                CalcMFI(14, 20);
            }
            else
            {

            }
        }

        public void CalcMFI(int period, int drawRange)
        {
            mainView.MainChart.ChartAreas[1].AxisX.StripLines.Clear();
            mainView.MainChart.ChartAreas[1].AxisY2.Maximum = 100;
            mainView.MainChart.ChartAreas[1].AxisY2.Minimum = 0;
            DataPointCollection Candles = mainView.PriceSeries.Points;
            DataPointCollection Volumes = mainView.VolumeSeries.Points;

            drawRange = (drawRange < 0) ? 0 : drawRange;
            drawRange = (drawRange > 50) ? 50 : drawRange;

            for (int i=0; i< Candles.Count - period - 1; i++)
            {
                double plusRmf = 0;
                double minusRmf = 0;
                for (int j=0; j< period; j++)
                {
                    DataPoint candleB = Candles[i + j + 1];
                    DataPoint volumeB = Volumes[i + j + 1];
                    double highB = candleB.YValues[0];
                    double lowB = candleB.YValues[1];
                    double endB = candleB.YValues[3];

                    double tpB = (highB + lowB + endB) / 3;

                    DataPoint candleA = Candles[i + j];
                    DataPoint volumeA = Volumes[i + j];
                    double highA = candleA.YValues[0];
                    double lowA = candleA.YValues[1];
                    double endA = candleA.YValues[3];
                    
                    double tpA = (highA + lowA + endA)/3;
                    double rmf = tpA * volumeA.YValues[0];

                    plusRmf += (tpB < tpA) ? rmf : 0;
                    minusRmf += (tpB > tpA) ? rmf : 0;
                }

                double mfr = plusRmf / minusRmf;
                double mfi = 100 - (100 / (1 + mfr));
                
                if (mfi <= drawRange)
                {
                    StripLine oversell = new StripLine();
                    oversell.BackColor = Color.FromArgb(145, 10, 40, 250);
                    oversell.StripWidth = 1;
                    oversell.IntervalOffset = i;
                    mainView.MainChart.ChartAreas[1].AxisX.StripLines.Add(oversell);
                }
                else if(mfi >= 100 - drawRange)
                {
                    StripLine overbought = new StripLine();
                    overbought.BackColor = Color.FromArgb(145, 250, 40, 40);
                    overbought.StripWidth = 1;
                    overbought.IntervalOffset = i;
                    mainView.MainChart.ChartAreas[1].AxisX.StripLines.Add(overbought);
                }

                mainView.IndicatorSeries.Points.AddXY(Candles[i].AxisLabel, mfi);
                mainView.IndicatorSeries.Points[i].Color = Color.FromArgb(255, 20, 20, 20);
            }
        }

        public void SetBaseStockInfo(string trCode, string rqName)
        {
            apiModel.SetRequestType(trCode, rqName);
            int tos = apiModel.GetRequestValue<int>("시가총액");
            double dtr = apiModel.GetRequestValue<double>("유통비율");
            double per = apiModel.GetRequestValue<double>("PER");
            double eps = apiModel.GetRequestValue<double>("EPS");
            double roe = apiModel.GetRequestValue<double>("ROE");
            double pbr = apiModel.GetRequestValue<double>("PBR");
            double ev = apiModel.GetRequestValue<double>("EV");
            
            UpdateStockInfo(tos, dtr, per, eps, roe, pbr, ev);
        }

        public void SetOrderBookInfo(string trCode, string rqName)
        {
            apiModel.SetRequestType(trCode, rqName);
            List<BidAskSpread> AskSpreadList = new List<BidAskSpread>();
            List<BidAskSpread> BidSpreadList = new List<BidAskSpread>();

            for (int i = 0; i < 9; i++)
            {
                BidAskSpread bidAskSpread = new BidAskSpread();
                if (i == 4)
                {
                    int price = apiModel.GetRequestValue<int>("매도" + (10 - i) + "차선호가");
                    int amount = apiModel.GetRequestValue<int>("매도" + (10 - i) + "우선잔량");
                    bidAskSpread.Price = (price > 0) ? price : -price;
                    bidAskSpread.Amount = amount;
                    AskSpreadList.Add(bidAskSpread);
                }
                else
                {
                    int price = apiModel.GetRequestValue<int>("매도" + (10 - i) + "차선호가");
                    int amount = apiModel.GetRequestValue<int>("매도" + (10 - i) + "차선잔량");
                    bidAskSpread.Price = (price > 0) ? price : -price;
                    bidAskSpread.Amount = amount;
                    AskSpreadList.Add(bidAskSpread);
                }
            }

            BidAskSpread askSpreadFirst = new BidAskSpread();
            int bidPrice = apiModel.GetRequestValue<int>("매도최우선호가");
            int bidAmount = apiModel.GetRequestValue<int>("매도최우선잔량");
            askSpreadFirst.Price = (bidPrice > 0) ? bidPrice : -bidPrice;
            askSpreadFirst.Amount = bidAmount;
            AskSpreadList.Add(askSpreadFirst);
            BidAskSpread bidSpreadFirst = new BidAskSpread();
            int askPrice = apiModel.GetRequestValue<int>("매수최우선호가");
            int askAmount = apiModel.GetRequestValue<int>("매수최우선잔량");
            bidSpreadFirst.Price = (askPrice > 0) ? askPrice : -askPrice;
            bidSpreadFirst.Amount = askAmount;
            BidSpreadList.Add(bidSpreadFirst);

            for (int i = 0; i < 9; i++)
            {
                BidAskSpread bidAskSpread = new BidAskSpread();
                if (i == 4)
                {
                    int price = apiModel.GetRequestValue<int>("매수" + (2 + i) + "우선호가");
                    int amount = apiModel.GetRequestValue<int>("매수" + (2 + i) + "우선잔량");
                    bidAskSpread.Price = (price > 0) ? price : -price;
                    bidAskSpread.Amount = amount;
                    BidSpreadList.Add(bidAskSpread);
                }
                else
                {
                    int price = apiModel.GetRequestValue<int>("매수" + (2 + i) + "차선호가");
                    int amount = apiModel.GetRequestValue<int>("매수" + (2 + i) + "차선잔량");
                    bidAskSpread.Price = (price > 0) ? price : -price;
                    bidAskSpread.Amount = amount;
                    BidSpreadList.Add(bidAskSpread);
                }
            }
            //UpdateOrderBook(AskSpreadList, BidSpreadList);
        }

        public void SetRealOrderBookInfo(string trCode)
        {
            apiModel.SetRealType(trCode);
            List<BidAskSpread> AskSpreadList = new List<BidAskSpread>();
            List<BidAskSpread> BidSpreadList = new List<BidAskSpread>();

            for (int i = 0; i < 10; i++)
            {
                int price = apiModel.GetRealtimeValue<int>(RealTypes.매도호가10 - i);
                int amount = apiModel.GetRealtimeValue<int>(RealTypes.매도호가수량10 - i);
                BidAskSpread askSpread = new BidAskSpread();
                askSpread.Amount = amount;
                askSpread.Price = price;
                BidSpreadList.Add(askSpread);
            }
            for (int i = 0; i < 10; i++)
            {
                int price = apiModel.GetRealtimeValue<int>(RealTypes.매수호가1 + i);
                int amount = apiModel.GetRealtimeValue<int>(RealTypes.매수호가수량1 + i);
                BidAskSpread bidSpread = new BidAskSpread();
                bidSpread.Amount = price;
                bidSpread.Price = amount;
                BidSpreadList.Add(bidSpread);
            }
            //UpdateOrderBook(AskSpreadList, BidSpreadList);
        }

        public void SetAssetListView(string trCode, string rqName)
        {
            apiModel.SetRequestType(trCode, rqName);
            double principal = apiModel.GetRequestValue<double>("예수금");
            double buyTotal = apiModel.GetRequestValue<double>("총매입금액");
            double dayPrincipal = apiModel.GetRequestValue<double>("당일투자원금");
            double dayEarning = apiModel.GetRequestValue<double>("당일투자손익");
            double dayEarningPer = apiModel.GetRequestValue<double>("당일손익율");
            double accPrincipal = apiModel.GetRequestValue<double>("누적투자원금");
            double accEarning = apiModel.GetRequestValue<double>("누적투자손익");
            double accEarningPer = apiModel.GetRequestValue<double>("누적손익율");

            mainView.PcpLabel.Text = string.Format("{0:c}", principal);
            mainView.DayPcpLabel.Text = string.Format("{0:c}", dayPrincipal);
            mainView.DayErnLabel.Text = string.Format("{0:c}({1}%)", dayEarning, dayEarningPer);
            mainView.AccPcpLabel.Text = string.Format("{0:c}", accPrincipal);
            mainView.AccErnLabel.Text = string.Format("{0:c}({1}%)", accEarning, accEarningPer);
            mainView.TotBuyLabel.Text = string.Format("{0:c}", buyTotal);

            int nCnt = apiModel.GetRepeatCnt(trCode, rqName);

            ListViewItem item = new ListViewItem();
            for (int nLoop = 0; nLoop < nCnt; nLoop++)
            {
                item.SubItems.Add(apiModel.GetRequestValue<string>("종목명", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("보유수량", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("평균단가", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("매입금액", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("평가금액", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("손익금액", nLoop));
                item.SubItems.Add(apiModel.GetRequestValue<string>("손익율", nLoop));
            }
            mainView.AssetList.Items.Add(item);
        }

        public void SetConditionView(string conditionList)
        {
            var list = new List<string>();
            foreach(string condition in conditionList.Split(';'))
            {
                list.Add(condition);
            }
            conditionView.ConditionListBox.DataSource = list;
            ((Form)conditionView).Show();
        }

        public void SetDisclosureView(List<DisclosureInfo> infos)
        {
            disclosureView.DisclosureListView.BeginUpdate();
            foreach (DisclosureInfo info in infos)
            {
                ListViewItem item = new ListViewItem(info.Title);
                item.SubItems.Add(info.Date);
                item.SubItems.Add(info.CorpCode);
                item.SubItems.Add(info.RCeptNum);
                disclosureView.DisclosureListView.Items.Add(item);
            }
            disclosureView.DisclosureListView.EndUpdate();
            ((Form)disclosureView).Show();
        }

        public void SendCondition(int key, string condition)
        {
            apiModel.SendCondition("0", condition, key, 0);
        }

        //public void SetTotalAssetView(string trCode, string rqName)
        //{
        //    long totalBuyingAmount = long.Parse(apiModel.GetCommData(trCode, rqName, 0, "총매입금액"));
        //    long totalEstimatedAmount = long.Parse(apiModel.GetCommData(trCode, rqName, 0, "총평가금액"));
        //    long totalEarningAmount = long.Parse(apiModel.GetCommData(trCode, rqName, 0, "총평가손익금액"));
        //    float totalEarningPercent = float.Parse(apiModel.GetCommData(trCode, rqName, 0, "총수익률(%)"));
        //}

        public void SetConditionStocks(_DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            apiModel.SetRequestType(e.sTrCode, e.sRQName);
            int count = apiModel.GetRepeatCnt(e.sTrCode, e.sRQName);

            mainView.StockList.BeginUpdate();
            mainView.StockList.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                string stockCode = apiModel.GetRequestValue<string>("종목코드", i);
                string stockName = apiModel.GetRequestValue<string>("종목명", i);
                string upDownRate = apiModel.GetRequestValue<string>("등락율", i) + '%';
                string volume = apiModel.GetRequestValue<string>("거래량", i);
                
                ListViewItem viewItem = new ListViewItem(stockCode);
                viewItem.SubItems.Add(stockName);
                viewItem.SubItems.Add(upDownRate);
                viewItem.SubItems.Add(volume);
                viewItem.ImageIndex = 0;
                
                mainView.StockList.Items.Add(viewItem);
            }
            mainView.StockList.EndUpdate();
        }

        public void UpdateTrData(_DKHOpenAPIEvents_OnReceiveTrDataEvent trEvent)
        {
            
            switch (trEvent.sRQName)
            {
                case "주식일봉차트조회":
                case "주식주봉차트조회":
                case "주식월봉차트조회":
                case "주식분봉차트조회":
                case "주식틱봉차트조회":
                    SetChartInfo(trEvent.sTrCode, trEvent.sRQName);
                    break;
                case "주식기본정보요청":
                    SetBaseStockInfo(trEvent.sTrCode, trEvent.sRQName);
                    break;
                case "주식호가정보요청":
                    SetOrderBookInfo(trEvent.sTrCode, trEvent.sRQName);
                    break;
                case "계좌평가현황요청":
                    SetAssetListView(trEvent.sTrCode, trEvent.sRQName);
                    break;
                case "조건검색종목":
                    SetConditionStocks(trEvent);
                    break;
                //case "계좌평가잔고내역요청":
                //    SetTotalAssetView(trEvent.sTrCode, trEvent.sRQName);
                //    break;
            }
        }

        public void UpdateRealData(_DKHOpenAPIEvents_OnReceiveRealDataEvent realEvent)
        {
            switch (realEvent.sRealType)
            {
                case "주식호가잔량":
                    SetRealOrderBookInfo(realEvent.sRealType);
                    break;
            }
        }

        #endregion
    }
}
