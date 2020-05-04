using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AutoTrader;
using AxKHOpenAPILib;

namespace AutoTrader.View
{
    public partial class MainForm : Form, IMainView
    {
        private string currentStockCode = "";
        private int selectedTickUnit = 1;
        private int selectedMinuteUnit = 240;
        private bool isMinuteSelected = false;
        private bool isTickSelected = false;
        private bool isPriceResize = false;
        private Point MousePoint;
        private double MaxAxisY;
        private double MinAxisY;
        private string endDate;
        private string beginDate;

        public Presenter.StockPresenter Presenter { get; set; }

        public APIExtention kHOpenAPI
        {
            get { return axKHOpenAPI1; }
        }
        public int SelectedMinuteUnit
        {
            get { return selectedMinuteUnit; }
        }
        public Chart MainChart
        {
            get { return mainChart; }
            set { mainChart = value; }
        }
        public Label ItemNameLabel
        {
            get { return itemNameLabel; }
            set { itemNameLabel = value; }
        }
        public Label TotalStockLabel
        {
            get { return totalStockLabel; }
            set { totalStockLabel = value; }
        }
        public Label DistribRatioLabel
        {
            get { return distribRatioLabel; }
            set { distribRatioLabel = value; }
        }
        public Label VolumeChangeLabel
        {
            get { return perTextLabel; }
            set { perTextLabel = value; }
        }
        public Label PerLabel
        {
            get { return perLabel; }
            set { perLabel = value; }
        }
        public Label EpsLabel
        {
            get { return epsLabel; }
            set { epsLabel = value; }
        }
        public Label RoeLabel
        {
            get { return roeLabel; }
            set { roeLabel = value; }
        }
        public Label PbrLabel
        {
            get { return pbrLabel; }
            set { pbrLabel = value; }
        }
        public Label EvLabel
        {
            get { return evLabel; }
            set { evLabel = value; }
        }
        public Label PcpLabel
        {
            get { return pcpLabel; }
            set { pcpLabel = value; }
        }
        public Label DayPcpLabel
        {
            get { return dayPcpLabel; }
            set { dayPcpLabel = value; }
        }
        public Label DayErnLabel
        {
            get { return dayErnLabel; }
            set { dayErnLabel = value; }
        }
        public Label AccPcpLabel
        {
            get { return accPcpLabel; }
            set { accPcpLabel = value; }
        }
        public Label AccErnLabel
        {
            get { return accErnLabel; }
            set { accErnLabel = value; }
        }
        public Label TotBuyLabel
        {
            get { return totBuyLabel; }
            set { totBuyLabel = value; }
        }
        public ListView AssetList
        {
            get { return assetList; }
            set { assetList = value; }
        }
        public ListView StockList
        {
            get { return stockList; }
            set { stockList = value; }
        }
        public ListView FunctionList
        {
            get { return functionList; }
            set { functionList = value; }
        }
        public ComboBox AccountListbox
        {
            get { return accountListbox; }
            set { accountListbox = value; }
        }

        public Series VolumeSeries { get; set; }
        public Series PriceSeries { get; set; }
        public Series IndicatorSeries { get; set; }
        public Series AskSeries { get; set; }
        public Series BidSeries { get; set; }

        public MainForm()
        {
            InitializeComponent();

            PriceSeries = mainChart.Series["priceSeries"];
            PriceSeries["PriceUpColor"] = "Red";
            PriceSeries["PriceDownColor"] = "Blue";
            VolumeSeries = mainChart.Series["volumeSeries"];
            IndicatorSeries = mainChart.Series["indicatorSeries"];

            //AskSeries = OrderBook.Series["askSeries"];
            //BidSeries = OrderBook.Series["bidSeries"];

            mainChart.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";
            mainChart.ChartAreas[1].AxisY.LabelStyle.Format = "#,##0,K";

            new ToolTip().SetToolTip(totalStockTextLabel, "현재가");
            new ToolTip().SetToolTip(totalStockLabel, "전일대비");
            new ToolTip().SetToolTip(distribRatioTextLabel, "등락률");
            new ToolTip().SetToolTip(distribRatioLabel, "누적거래량");
            new ToolTip().SetToolTip(perTextLabel, "전일거래량 대비");
            new ToolTip().SetToolTip(perLabel, "거래량회전률");
            new ToolTip().SetToolTip(epsTextLabel, "거래대금");
            new ToolTip().SetToolTip(roeTextLabel, "시가");
            new ToolTip().SetToolTip(pbrTextLabel, "고가");
            new ToolTip().SetToolTip(evTextLabel, "저가");

            axKHOpenAPI1.OnEventConnect += KHOpenAPI_OnEventConnect;
            axKHOpenAPI1.OnReceiveTrData += KHOpenAPI_OnReceiveTrData;
            axKHOpenAPI1.OnReceiveRealData += KHOpenAPI_OnReceiveRealData;
            axKHOpenAPI1.OnReceiveConditionVer += KHOpenAPI_OnReceiveConditionVer;
            axKHOpenAPI1.OnReceiveTrCondition += KHOpenAPI_OnReceiveTrCondition;
            MainChart.AxisViewChanged += Chart_AxisViewChanged;
            MainChart.MouseWheel += Chart_MouseWheel;
            MainChart.MouseMove += Chart_MouseMove;
            chartYLabel.MouseDown += Label_MouseDown;
            chartYLabel.MouseMove += Label_MouseMove;
            chartYLabel.MouseUp += Label_MouseUp;
            functionList.Click += FunctionList_Click;

            if (axKHOpenAPI1.CommConnect() != 0)
                System.Windows.Forms.MessageBox.Show("로그인 실패");
        }

        private void KHOpenAPI_OnEventConnect(object sender, _DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                string accountCnt = axKHOpenAPI1.GetLoginInfo("ACCOUNT_CNT");
                string[] accountArray = axKHOpenAPI1.GetLoginInfo("ACCLIST").Split(';');
                string userId = axKHOpenAPI1.GetLoginInfo("USER_ID");
                string userName = axKHOpenAPI1.GetLoginInfo("USER_NAME");
                string keySeq = axKHOpenAPI1.GetLoginInfo("KEY_BSECGB");
                string firewall = axKHOpenAPI1.GetLoginInfo("FIREW_SECGB");
                string serverType = axKHOpenAPI1.GetLoginInfo("GetServerGubun");

                List<string> accountList = accountArray.ToList();
                accountList.Remove("");
                accountListbox.DataSource = accountList;
                uidLabel.Text = userId;
                unLabel.Text = userName;
                ksLabel.Text = (keySeq == "0") ? "정상" : "해지";
                fwLabel.Text = (firewall == "0")? "미설정" : (firewall == "1")? "설정" : "해지";
                stLabel.Text = (serverType == "1")? "모의투자" : "실서버";

                axKHOpenAPI1.KOA_Functions(("ShowAccountWindow"), (""));
                Presenter.RequestTotalAsset(accountList[0], "");
                Presenter.RequestAsset(accountList[0], "");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("로그인 실패");
                Application.Exit();
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
            n240Button.Enabled = isEnable;

            isMinuteSelected = isEnable;
            isTickSelected = false;
        }

        private void KHOpenAPI_OnReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            Presenter.UpdateTrData(e);
        }

        private void KHOpenAPI_OnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            Presenter.UpdateRealData(e);
        }

        private void KHOpenAPI_OnReceiveConditionVer(object sender, _DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            if (e.lRet == 1)
            {
                string conditionList = axKHOpenAPI1.GetConditionNameList();
                Presenter.SetConditionView(conditionList);
            }
        }

        private void KHOpenAPI_OnReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            if (e.strCodeList.Length > 0)
            {
                string stockCodeString = e.strCodeList.Remove(e.strCodeList.Length - 1);
                string[] stockCodeArray = stockCodeString.Split(';');

                int index = 1;
                string stockcodes = "";
                foreach(string stockcode in stockCodeArray)
                {
                    stockcodes += stockcode + ';';
                    index++;
                    if(index % 100 == 0 || stockcode == stockCodeArray.Last())
                    {
                        stockcodes.Remove(stockcodes.Length - 1);
                        axKHOpenAPI1.CommKwRqData(stockcodes, 0, index, 0, "조건검색종목", "0");
                        stockcodes = "";
                    }
                }
                if (e.nNext != 0) //연속조회여부 , 320개 이상 더 종목이 있을때 한번 더 조건검색을 요청한다.
                {
                    axKHOpenAPI1.SendCondition("0", e.strConditionName, e.nIndex, 1);//
                }
            }
            else
            {
                MessageBox.Show("검색된 종목이 없습니다.");
            }
        }

        private void Chart_AxisViewChanged(object sender, ViewEventArgs e)
        {
            if (sender.Equals(mainChart))
            {
                int startPosition = (int)e.Axis.ScaleView.ViewMinimum;
                int endPosition = (int)e.Axis.ScaleView.ViewMaximum;
                Presenter.UpdateChartAxis(startPosition, endPosition);
            }
        }

        private void Chart_MouseWheel(object sender, MouseEventArgs e)
        {
            Axis axisX = mainChart.ChartAreas[0].AxisX;

            double max = axisX.ScaleView.ViewMaximum;
            double min = axisX.ScaleView.ViewMinimum;
            int sig = (e.Delta > 0) ? 14 : -8; // 확대 축소 보정

            mainChart.ChartAreas[0].AxisX.ScaleView.Zoom(min + 1, max - sig);
        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            ChartArea priceChartArea = mainChart.ChartAreas[0];
            ChartArea volumeChartArea = mainChart.ChartAreas[1];
            Point mousePoint = new Point(e.X, e.Y);

            if (mainChart.Height * 0.05 < e.Y && e.Y < mainChart.Height * 0.57)
            {
                chartYLabel.Visible = true;
                priceChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);
                priceChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);

                chartYLabel.Text = String.Format("{0:#,###}", priceChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(mainChart.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else if (mainChart.Height * 0.605 < e.Y && e.Y < mainChart.Height * 0.915)
            {
                chartYLabel.Visible = true;
                volumeChartArea.CursorX.SetCursorPixelPosition(mousePoint, true);
                volumeChartArea.CursorY.SetCursorPixelPosition(mousePoint, true);

                chartYLabel.Text = String.Format("{0:#,###}", volumeChartArea.CursorY.Position);
                chartYLabel.Location = new Point((int)(mainChart.Width * 0.9), e.Y - chartYLabel.Height / 2);
            }
            else
            {
                chartYLabel.Visible = false;
            }
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            MaxAxisY = mainChart.ChartAreas[0].AxisY.Maximum;
            MinAxisY = mainChart.ChartAreas[0].AxisY.Minimum;

            MousePoint = e.Location;
            isPriceResize = true;
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPriceResize)
            {
                int DeltaY = (e.Location.Y - MousePoint.Y) * 20;
                if (MaxAxisY + DeltaY > MinAxisY - DeltaY)
                {
                    mainChart.ChartAreas[0].AxisY.Maximum = MaxAxisY + DeltaY;
                    mainChart.ChartAreas[0].AxisY.Minimum = MinAxisY - DeltaY;
                }
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            isPriceResize = false;
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            currentStockCode = this.itemCodeTextBox.Text.Trim();
            itemNameLabel.Text = axKHOpenAPI1.GetMasterCodeName(currentStockCode);
            TurnNButtonsEnabled(true);
            Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
        }

        private void DailyButton_Click(object sender, EventArgs e)
        {
            if (currentStockCode.Length > 0)
            {
                TurnNButtonsEnabled(false);
                Presenter.RequestDailyChart(currentStockCode);
            }
        }

        private void WeeklyButton_Click(object sender, EventArgs e)
        {
            if (currentStockCode.Length > 0)
            {
                TurnNButtonsEnabled(false);
                Presenter.RequestWeeklyChart(currentStockCode);
            }
        }

        private void MonthlyButton_Click(object sender, EventArgs e)
        {
            if (currentStockCode.Length > 0)
            {
                TurnNButtonsEnabled(false);
                Presenter.RequestMonthlyChart(currentStockCode);
            }
        }

        private void MinuteButton_Click(object sender, EventArgs e)
        {
            if (currentStockCode.Length > 0)
            {
                TurnNButtonsEnabled(true);
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
        }

        private void TickButton_Click(object sender, EventArgs e)
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
                n240Button.Enabled = false;

                isMinuteSelected = false;
                isTickSelected = true;

                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N1Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 1;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
            else if (isTickSelected)
            {
                selectedTickUnit = 1;
                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N3Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 3;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
            else if (isTickSelected)
            {
                selectedTickUnit = 3;
                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N5Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 5;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
            else if (isTickSelected)
            {
                selectedTickUnit = 5;
                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N10Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 10;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
            else if (isTickSelected)
            {
                selectedTickUnit = 10;
                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N15Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 15;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
        }

        private void N30Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 30;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
            else if (isTickSelected)
            {
                selectedTickUnit = 30;
                Presenter.RequestTickChart(currentStockCode, selectedTickUnit);
            }
        }

        private void N45Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 45;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
        }

        private void N60Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 60;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
        }

        private void N240Button_Click(object sender, EventArgs e)
        {
            if (isMinuteSelected)
            {
                selectedMinuteUnit = 240;
                Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
            }
        }

        private void ConditionButton_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.GetConditionLoad();
        }

        private void StockList_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = stockList.SelectedItems[0];
            currentStockCode = firstSelectedItem.Text;
            itemNameLabel.Text = axKHOpenAPI1.GetMasterCodeName(currentStockCode);
            TurnNButtonsEnabled(true);
            Presenter.RequestMinuteChart(currentStockCode, selectedMinuteUnit);
        }

        private void FunctionList_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = functionList.SelectedItems[0];
            switch (firstSelectedItem.Text)
            {
                case "뉴스":
                    Presenter.RequestNewsUrl(currentStockCode, beginDate, endDate);
                    break;
                case "네이버증권":
                    Presenter.RequestNaverUrl(currentStockCode);
                    break;
                case "팍스넷":
                    Presenter.RequestPaxnetUrl(currentStockCode);
                    break;
                case "공시정보":
                    Presenter.RequestDart(currentStockCode, beginDate, endDate);
                    break;

            }
        }
    }
}
