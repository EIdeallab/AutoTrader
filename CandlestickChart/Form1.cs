using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CandlestickChart
{
    public partial class Form1 : Form
    {
        List<PriceInfoEntityObject> priceInfoList;

        private Series priceSeries;
        private Series volumeSeries;

        private string currentStockCode = "";
        private int selectedTickUnit = 1;
        private int selectedMinuteUnit = 1;
        private Boolean isMinuteSelected = false;
        private Boolean isTickSelected = false;
        
        public Form1()
        {
            InitializeComponent();

            this.axKHOpenAPI1.OnEventConnect += this.KHOpenAPI_OnEventConnect;
            this.axKHOpenAPI1.OnReceiveTrData += this.KHOpenAPI_OnReceiveTrData;
            this.axKHOpenAPI1.OnReceiveRealData += this.KHOpenAPI_OnReceiveRealData;
            this.requestButton.Click += this.ButtonClicked;
            this.dailyButton.Click += this.ButtonClicked;
            this.weeklyButton.Click += this.ButtonClicked;
            this.monthlyButton.Click += this.ButtonClicked;
            this.minuteButton.Click += this.ButtonClicked;
            this.tickButton.Click += this.ButtonClicked;
            this.n1Button.Click += this.ButtonClicked;
            this.n3Button.Click += this.ButtonClicked;
            this.n5Button.Click += this.ButtonClicked;
            this.n10Button.Click += this.ButtonClicked;
            this.n15Button.Click += this.ButtonClicked;
            this.n30Button.Click += this.ButtonClicked;
            this.n45Button.Click += this.ButtonClicked;
            this.n60Button.Click += this.ButtonClicked;

            
            this.searchButton.Click += this.ButtonClicked;
            
            priceSeries = MainChart.Series["priceSeries"];
            priceSeries["PriceUpColor"] = "Red";
            priceSeries["PriceDownColor"] = "Blue";
            volumeSeries = MainChart.Series["volumeSeries"];
            this.MainChart.AxisViewChanged += this.ChartAxisViewChanged;
            this.MainChart.MouseWheel += this.ChartMouseWheel;
            this.MainChart.MouseMove += this.ChartMouseMove;

            MainChart.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
            MainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";

            new ToolTip().SetToolTip(currentPriceLabel, "현재가");
            new ToolTip().SetToolTip(netChangeLabel, "전일대비");
            new ToolTip().SetToolTip(fluctuationRateLabel, "등락률");
            new ToolTip().SetToolTip(accumulatedVolumeLabel, "누적거래량");
            new ToolTip().SetToolTip(volumeChangeLabel, "전일거래량 대비");
            new ToolTip().SetToolTip(turnoverRatioLabel, "거래량회전률");
            new ToolTip().SetToolTip(tradingValueLabel, "거래대금");
            new ToolTip().SetToolTip(openPriceLabel, "시가");
            new ToolTip().SetToolTip(highPriceLabel, "고가");
            new ToolTip().SetToolTip(lowPriceLabel, "저가");

            if (axKHOpenAPI1.CommConnect() != 0)
                System.Windows.Forms.MessageBox.Show("로그인 실패");
        }

        private void KHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                //로그인 성공
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("로그인 실패");
            }
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            if (sender.Equals(this.requestButton))
            {
                currentStockCode = this.itemCodeTextBox.Text.Trim();
                itemNameLabel.Text = axKHOpenAPI1.GetMasterCodeName(currentStockCode);
                RequestDailyChart();
            }
            else if(sender.Equals(this.dailyButton))
            {
                if(currentStockCode.Length > 0)
                {
                    TurnNButtonsEnabled(false);
                    RequestDailyChart();
                }
            }
            else if(sender.Equals(this.weeklyButton))
            {
                if (currentStockCode.Length > 0)
                {
                    TurnNButtonsEnabled(false);
                    RequestWeeklyChart();
                }
            }
            else if(sender.Equals(this.monthlyButton))
            {
                if (currentStockCode.Length > 0)
                {
                    TurnNButtonsEnabled(false);
                    RequestMonthlyChart();
                }
            }
            else if(sender.Equals(this.minuteButton))
            {
                if (currentStockCode.Length > 0)
                {
                    TurnNButtonsEnabled(true);
                    RequestMinuteChart(selectedMinuteUnit);
                }
            }
            else if(sender.Equals(this.tickButton))
            {
                if (currentStockCode.Length > 0)
                {
                    n1Button.Enabled = true;
                    n3Button.Enabled = true;
                    n5Button.Enabled = true;
                    n10Button.Enabled = true;
                    n30Button.Enabled = true;
                    n15Button.Enabled = false;
                    n45Button.Enabled = false;
                    n60Button.Enabled = false;

                    isMinuteSelected = false;
                    isTickSelected = true;

                    RequestTickChart(selectedTickUnit);
                }
            }
            else if(sender.Equals(this.n1Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 1;
                    RequestMinuteChart(selectedMinuteUnit);
                }
                else if(isTickSelected)
                {
                    selectedTickUnit = 1;
                    RequestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n3Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 3;
                    RequestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 3;
                    RequestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n5Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 5;
                    RequestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 5;
                    RequestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n10Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 10;
                    RequestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 10;
                    RequestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n15Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 15;
                    RequestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.n30Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 30;
                    RequestMinuteChart(selectedMinuteUnit);
                }
                else if (isTickSelected)
                {
                    selectedTickUnit = 30;
                    RequestTickChart(selectedTickUnit);
                }
            }
            else if (sender.Equals(this.n45Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 45;
                    RequestMinuteChart(selectedMinuteUnit);
                }
            }
            else if (sender.Equals(this.n60Button))
            {
                if (isMinuteSelected)
                {
                    selectedMinuteUnit = 60;
                    RequestMinuteChart(selectedMinuteUnit);
                }
            }
            else if(sender.Equals(this.searchButton))
            {
                
                //종목검색창 = jamongCommonClass.Get종목검색창();   //종목검색창 객체 불러오기
                //종목검색창.setOnSearchedItemSelectedListener(new MyOnSearchedItemSelectedListener(this)); //종목 선택 이벤트 등록
                //종목검색창.Show(); //종목검색창 띄우기
                 
            }
        }

        private void TurnNButtonsEnabled(Boolean isEnable)
        {
            n1Button.Enabled = isEnable;
            n3Button.Enabled = isEnable;
            n5Button.Enabled = isEnable;
            n10Button.Enabled = isEnable;
            n15Button.Enabled = isEnable;
            n30Button.Enabled = isEnable;
            n45Button.Enabled = isEnable;
            n60Button.Enabled = isEnable;

            isMinuteSelected = isEnable;
            isTickSelected = false;
        }

        private void RequestDailyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식일봉차트조회", "OPT10081", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 일봉 정보요청 성공");
            else
                Console.WriteLine("주식 일봉 정보요청 실패");
        }

        private void RequestWeeklyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("끝일자", "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식주봉차트조회", "OPT10082", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 주봉 정보요청 성공");
            else
                Console.WriteLine("주식 주봉 정보요청 실패");
        }

        private void RequestMonthlyChart()
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("끝일자", "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식월봉차트조회", "OPT10083", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 월봉 정보요청 성공");
            else
                Console.WriteLine("주식 월봉 정보요청 실패");
        }

        private void RequestMinuteChart(int minuteUnit)
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("틱범위", minuteUnit + "");
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식분봉차트조회", "OPT10080", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 분봉 정보요청 성공");
            else
                Console.WriteLine("주식 분봉 정보요청 실패");
        }

        private void RequestTickChart(int tickUnit)
        {
            axKHOpenAPI1.SetInputValue("종목코드", currentStockCode);
            axKHOpenAPI1.SetInputValue("틱범위", tickUnit.ToString());
            axKHOpenAPI1.SetInputValue("수정주가구분", "1");

            int nRet = axKHOpenAPI1.CommRqData("JM_주식틱봉차트조회", "OPT10079", 0, "1002");

            if (nRet == 0)
                Console.WriteLine("주식 틱봉 정보요청 성공");
            else
                Console.WriteLine("주식 틱봉 정보요청 실패");
        }

        private void RequestStockInfo(string 종목코드)
        {
            axKHOpenAPI1.SetInputValue("종목코드", this.itemCodeTextBox.Text.Trim());

            int nRet = axKHOpenAPI1.CommRqData("JM_주식기본정보요청", "OPT10001", 0, "1003");

            if (nRet == 0)
                Console.WriteLine("주식기본정보요청 성공");
            else
                Console.WriteLine("주식기본정보요청 실패");
        }

        private void KHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "JM_주식일봉차트조회" || e.sRQName == "JM_주식주봉차트조회" || e.sRQName == "JM_주식월봉차트조회" || e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
            {
                try
                {
                    int nCnt = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);

                    priceInfoList = new List<PriceInfoEntityObject>();
                    priceSeries.Points.Clear();
                    volumeSeries.Points.Clear();

                    if(e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
                        MainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0";
                    else
                        MainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";
                    ChartArea priceChartArea = MainChart.ChartAreas["PriceChartArea"];
                    do
                    {
                        priceChartArea.AxisX.ScaleView.ZoomReset();
                    }
                    while (priceChartArea.AxisX.ScaleView.IsZoomed);
                    
                    int maxValue = 0;
                    int minValue = int.MaxValue;

                    for (int nIdx = 0; nIdx < nCnt; nIdx++)
                    {
                        if (e.sRQName == "JM_주식분봉차트조회" || e.sRQName == "JM_주식틱봉차트조회")
                            priceInfoList.Add(new PriceInfoEntityObject()
                            {
                                일자 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "체결시간").Trim(),
                                시가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "시가").Trim())),
                                고가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "고가").Trim())),
                                저가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "저가").Trim())),
                                종가 = Math.Abs(Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "현재가").Trim())),
                                거래량 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "거래량").Trim()),
                            });
                        else
                            priceInfoList.Add(new PriceInfoEntityObject()
                            {
                                일자 = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "일자").Trim(),
                                시가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "시가").Trim()),
                                고가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "고가").Trim()),
                                저가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "저가").Trim()),
                                종가 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "현재가").Trim()),
                                거래량 = Int32.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, nIdx, "거래량").Trim()),
                            });
                        if (priceInfoList[nIdx].고가 > maxValue)
                            maxValue = priceInfoList[nIdx].고가;
                        if (priceInfoList[nIdx].저가 < minValue)
                            minValue = priceInfoList[nIdx].저가;
                      
                        // adding date and high
                        priceSeries.Points.AddXY(priceInfoList[nIdx].일자, priceInfoList[nIdx].고가);
                        // adding low
                        priceSeries.Points[nIdx].YValues[1] = priceInfoList[nIdx].저가;
                        //adding open
                        priceSeries.Points[nIdx].YValues[2] = priceInfoList[nIdx].시가;
                        // adding close
                        priceSeries.Points[nIdx].YValues[3] = priceInfoList[nIdx].종가;

                        priceSeries.Points[nIdx].ToolTip = "일자 : " + priceInfoList[nIdx].일자 + "\n"
                                                          + "시가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].시가) + "\n"
                                                          + "고가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].고가) + "\n"
                                                          + "저가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].저가) + "\n"
                                                          + "종가 : " + String.Format("{0:#,###}", priceInfoList[nIdx].종가) + "\n"
                                                          + "거래량 : " + String.Format("{0:#,###}", priceInfoList[nIdx].거래량);

                        volumeSeries.Points.AddXY(priceInfoList[nIdx].일자, priceInfoList[nIdx].거래량);

                        volumeSeries.Points[nIdx].ToolTip = "일자 : " + priceInfoList[nIdx].일자 + "\n"
                                                           + "거래량 : " + String.Format("{0:#,###}", priceInfoList[nIdx].거래량);

                    }

                    RequestStockInfo(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim());

                    if (nCnt > 0)
                    {
                        priceChartArea.AxisX.ScaleView.ZoomReset();

                        priceChartArea.AxisY.Maximum = maxValue;
                        priceChartArea.AxisY.Minimum = minValue;

                        if (!priceChartArea.AxisX.ScaleView.IsZoomed)
                            ChartAxisViewChanged(MainChart, new ViewEventArgs(priceChartArea.AxisX, 0));
                    }

                }catch(Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
                
            }
            else if(e.sRQName == "JM_주식기본정보요청")
            {
                try
                {
                    int 현재가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                    int 전일대비 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비"));
                    double 등락율 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율").Trim());
                    double 거래량 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                    double 거래대비 = double.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래대비"));
                    int 시가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가"));
                    int 고가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                    int 저가 = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));

                    SetStockInfo(현재가, 전일대비, 등락율, 거래량, 거래대비, 0, 0, 시가, 고가, 저가);
                }catch(Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }
        }

        private void SetStockInfo(int 현재가, int 전일대비, double 등락율, double 거래량, double 거래대비, double 거래회전율, double 거래대금, int 시가, int 고가, int 저가)
        {
            if (전일대비 > 0)
            {
                currentPriceLabel.ForeColor = Color.Red;
                netChangeLabel.ForeColor = Color.Red;
                fluctuationRateLabel.ForeColor = Color.Red;
            }
            else if (전일대비 < 0)
            {
                currentPriceLabel.ForeColor = Color.Blue;
                netChangeLabel.ForeColor = Color.Blue;
                fluctuationRateLabel.ForeColor = Color.Blue;

                현재가 *= -1;
            }

            if (거래대비 > 0)
                volumeChangeLabel.ForeColor = Color.Red;
            else if (거래대비 < 0)
            {
                volumeChangeLabel.ForeColor = Color.Blue;
                거래대비 *= -1;
            }

            if (시가 > 0)
                openPriceLabel.ForeColor = Color.Red;
            else if (시가 < 0)
            {
                openPriceLabel.ForeColor = Color.Blue;
                시가 *= -1;
            }
            if (고가 > 0)
                highPriceLabel.ForeColor = Color.Red;
            else if (고가 < 0)
            {
                highPriceLabel.ForeColor = Color.Blue;
                고가 *= -1;
            }
            if (저가 > 0)
                lowPriceLabel.ForeColor = Color.Red;
            else if (저가 < 0)
            {
                lowPriceLabel.ForeColor = Color.Blue;
                저가 *= -1;
            }

            currentPriceLabel.Text = String.Format("{0:#,###}", 현재가);
            netChangeLabel.Text = String.Format("{0:#,###}", 전일대비);
            fluctuationRateLabel.Text = 등락율 + "%";
            accumulatedVolumeLabel.Text = String.Format("{0:#,###}", 거래량);
            volumeChangeLabel.Text = 거래대비 + "%";
            turnoverRatioLabel.Text = 거래회전율 + "%";
            tradingValueLabel.Text = String.Format("{0:#,###}", 거래대금) + "백만";
            openPriceLabel.Text = String.Format("{0:#,###}", 시가);
            highPriceLabel.Text = String.Format("{0:#,###}", 고가);
            lowPriceLabel.Text = String.Format("{0:#,###}", 저가);
        }

        private void KHOpenAPI_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if (e.sRealType == "주식체결")
            {
                string 종목코드 = e.sRealKey;
                //Console.WriteLine(종목코드);
                if(currentStockCode.Equals(종목코드))
                {
                    int 현재가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 10));
                    int 전일대비 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 11));
                    double 등락율 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 12));
                    double 거래량 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 13));
                    double 거래대비 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 30));
                    double 거래회전율 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 31));
                    double 거래대금 = double.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 14));
                    int 시가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 16));
                    int 고가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 17));
                    int 저가 = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealType, 18));

                    SetStockInfo(현재가, 전일대비, 등락율, 거래량, 거래대비, 거래회전율, 거래대금, 시가, 고가, 저가);
                }
            }
        }

        private void ChartAxisViewChanged(object sender, ViewEventArgs e)
        {
            if(sender.Equals(MainChart))
            {
                try
                {
                    int startPosition = (int)e.Axis.ScaleView.ViewMinimum;
                    int endPosition = (int)e.Axis.ScaleView.ViewMaximum;

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

                        if (priceInfoList[i].고가 > max)
                            max = priceInfoList[i].고가;
                        if (priceInfoList[i].저가 < min)
                            min = priceInfoList[i].저가;

                        if (priceInfoList[i].거래량 > volumeMax)
                            volumeMax = priceInfoList[i].거래량;
                        if (priceInfoList[i].거래량 < volumeMin)
                            volumeMin = priceInfoList[i].거래량;
                    }

                    double offset = 0.2 * (max - min);
                    this.MainChart.ChartAreas[0].AxisY.Maximum = max + offset;
                    this.MainChart.ChartAreas[0].AxisY.Minimum = min - offset;

                    double volumeOffset = 0.2 * (volumeMax - volumeMin);
                    this.MainChart.ChartAreas[1].AxisY.Maximum = volumeMax + volumeOffset;
                    if (volumeMin - volumeOffset > 0)
                        this.MainChart.ChartAreas[1].AxisY.Minimum = volumeMin - volumeOffset;
                    else
                        this.MainChart.ChartAreas[1].AxisY.Minimum = 0;
                }catch(Exception exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }
           
        }

        private void ChartMouseWheel(object sender, MouseEventArgs e)
        {
            Axis axisX = MainChart.ChartAreas[0].AxisX;

            double max = axisX.ScaleView.ViewMaximum;
            double min = axisX.ScaleView.ViewMinimum;
            double sig = (e.Delta > 0) ? 5 : -5;

            double axisValue = axisX.PixelPositionToValue(e.Location.X);
            double ratio = (axisValue - min) / (max - min);
            
            double stPosX = min + (int)(sig * ratio);
            double edPosX = max - (int)(sig * (1 - ratio));
            
            MainChart.ChartAreas[0].AxisX.ScaleView.Zoom(stPosX, edPosX);
        }

        private void ChartMouseMove(object sender, MouseEventArgs e)
        {
            ChartArea priceChartArea = MainChart.ChartAreas[0];
            ChartArea volumeChartArea = MainChart.ChartAreas[1];
            Point mousePoint = new Point(e.X, e.Y);

            if (MainChart.Height * 0.05 < e.Y && e.Y < MainChart.Height * 0.57)
            {
                chartYLabel.Visible = true;
                priceChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);
                priceChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);﻿
                
                
                chartYLabel.Text = String.Format("{0:#,###}", priceChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(MainChart.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else if (MainChart.Height * 0.605 < e.Y && e.Y < MainChart.Height * 0.915)
            {
                chartYLabel.Visible = true;
                volumeChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);﻿
                volumeChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);﻿

                chartYLabel.Text = String.Format("{0:#,###}", volumeChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(MainChart.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else
            {
                chartYLabel.Visible = false;
            }
         }
        
        //class MyOnSearchedItemSelectedListener : OnSearchedItemSelectedListener
        //{
        //    Form1 form1;
        //    public MyOnSearchedItemSelectedListener(Form1 form1)
        //    {
        //        this.form1 = form1;
        //    }
        //    public void OnSelected(string 종목명, string 종목코드)
        //    {
        //        //Console.WriteLine("종목명=" + 종목명 + " 종목코드=" + 종목코드);
        //        form1.itemCodeTextBox.Text = 종목코드;
        //        form1.currentStockCode = 종목코드;
        //        form1.itemNameLabel.Text = form1.axKHOpenAPI1.GetMasterCodeName(form1.currentStockCode);
        //        form1.requestDailyChart();
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class PriceInfoEntityObject
    {
        public String 일자 { get; set; }
        public int 시가 { get; set; }
        public int 고가 { get; set; }
        public int 저가 { get; set; }
        public int 종가 { get; set; }
        public int 거래량 { get; set; }
    }
}
