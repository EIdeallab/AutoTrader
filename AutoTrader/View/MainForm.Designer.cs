namespace AutoTrader.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage conditionPage;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "뉴스",
            ""}, "news.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("네이버증권", "naver.png");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("팍스넷", "paxnet.png");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("공시정보", "dart.png");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stockList = new System.Windows.Forms.ListView();
            this.stockCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.upDownRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dealTab = new System.Windows.Forms.TabControl();
            this.userPage = new System.Windows.Forms.TabPage();
            this.userInfoLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.totBuyLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.stLabel = new System.Windows.Forms.Label();
            this.ksLabel = new System.Windows.Forms.Label();
            this.fwLabel = new System.Windows.Forms.Label();
            this.unLabel = new System.Windows.Forms.Label();
            this.uidLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accountListbox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pcpLabel = new System.Windows.Forms.Label();
            this.dayPcpLabel = new System.Windows.Forms.Label();
            this.dayErnLabel = new System.Windows.Forms.Label();
            this.accPcpLabel = new System.Windows.Forms.Label();
            this.accErnLabel = new System.Windows.Forms.Label();
            this.assetPage = new System.Windows.Forms.TabPage();
            this.AssetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.assetList = new System.Windows.Forms.ListView();
            this.assetName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averagePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.evalAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earnings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.earningPer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.requestButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dailyButton = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.monthlyButton = new System.Windows.Forms.Button();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.minuteButton = new System.Windows.Forms.Button();
            this.tickButton = new System.Windows.Forms.Button();
            this.n1Button = new System.Windows.Forms.Button();
            this.n3Button = new System.Windows.Forms.Button();
            this.n5Button = new System.Windows.Forms.Button();
            this.n10Button = new System.Windows.Forms.Button();
            this.n15Button = new System.Windows.Forms.Button();
            this.n30Button = new System.Windows.Forms.Button();
            this.n45Button = new System.Windows.Forms.Button();
            this.n60Button = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.conditionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartYLabel = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.evTextLabel = new System.Windows.Forms.Label();
            this.pbrLabel = new System.Windows.Forms.Label();
            this.pbrTextLabel = new System.Windows.Forms.Label();
            this.roeLabel = new System.Windows.Forms.Label();
            this.roeTextLabel = new System.Windows.Forms.Label();
            this.totalStockTextLabel = new System.Windows.Forms.Label();
            this.totalStockLabel = new System.Windows.Forms.Label();
            this.distribRatioTextLabel = new System.Windows.Forms.Label();
            this.distribRatioLabel = new System.Windows.Forms.Label();
            this.perLabel = new System.Windows.Forms.Label();
            this.perTextLabel = new System.Windows.Forms.Label();
            this.epsTextLabel = new System.Windows.Forms.Label();
            this.epsLabel = new System.Windows.Forms.Label();
            this.evLabel = new System.Windows.Forms.Label();
            this.SideLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ActionTab = new System.Windows.Forms.TabControl();
            this.FunctionPage = new System.Windows.Forms.TabPage();
            this.functionList = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.OptionPage = new System.Windows.Forms.TabPage();
            this.axKHOpenAPI1 = new AutoTrader.APIExtention();
            conditionPage = new System.Windows.Forms.TabPage();
            conditionPage.SuspendLayout();
            this.dealTab.SuspendLayout();
            this.userPage.SuspendLayout();
            this.userInfoLayoutPanel.SuspendLayout();
            this.assetPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssetChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SideLayoutPanel.SuspendLayout();
            this.ActionTab.SuspendLayout();
            this.FunctionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionPage
            // 
            conditionPage.Controls.Add(this.stockList);
            conditionPage.Controls.Add(this.dateTimePicker1);
            conditionPage.Location = new System.Drawing.Point(4, 25);
            conditionPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            conditionPage.Name = "conditionPage";
            conditionPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            conditionPage.Size = new System.Drawing.Size(310, 413);
            conditionPage.TabIndex = 0;
            conditionPage.Text = "조건식종목";
            conditionPage.UseVisualStyleBackColor = true;
            // 
            // stockList
            // 
            this.stockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stockCode,
            this.stockName,
            this.upDownRate,
            this.volume});
            this.stockList.HideSelection = false;
            this.stockList.Location = new System.Drawing.Point(0, 24);
            this.stockList.Name = "stockList";
            this.stockList.Size = new System.Drawing.Size(307, 389);
            this.stockList.TabIndex = 1;
            this.stockList.UseCompatibleStateImageBehavior = false;
            this.stockList.View = System.Windows.Forms.View.Details;
            this.stockList.Click += new System.EventHandler(this.StockList_Click);
            // 
            // stockCode
            // 
            this.stockCode.Text = "종목코드";
            this.stockCode.Width = 80;
            // 
            // stockName
            // 
            this.stockName.Text = "종목명";
            this.stockName.Width = 100;
            // 
            // upDownRate
            // 
            this.upDownRate.Text = "등락율";
            // 
            // volume
            // 
            this.volume.Text = "거래량";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(307, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dealTab
            // 
            this.dealTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dealTab.Controls.Add(conditionPage);
            this.dealTab.Controls.Add(this.userPage);
            this.dealTab.Controls.Add(this.assetPage);
            this.dealTab.Location = new System.Drawing.Point(0, 0);
            this.dealTab.Margin = new System.Windows.Forms.Padding(0);
            this.dealTab.Multiline = true;
            this.dealTab.Name = "dealTab";
            this.dealTab.SelectedIndex = 0;
            this.dealTab.Size = new System.Drawing.Size(318, 442);
            this.dealTab.TabIndex = 1;
            // 
            // userPage
            // 
            this.userPage.Controls.Add(this.userInfoLayoutPanel);
            this.userPage.Location = new System.Drawing.Point(4, 25);
            this.userPage.Name = "userPage";
            this.userPage.Padding = new System.Windows.Forms.Padding(3);
            this.userPage.Size = new System.Drawing.Size(310, 413);
            this.userPage.TabIndex = 2;
            this.userPage.Text = "유저정보";
            this.userPage.UseVisualStyleBackColor = true;
            // 
            // userInfoLayoutPanel
            // 
            this.userInfoLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoLayoutPanel.BackColor = System.Drawing.Color.White;
            this.userInfoLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.userInfoLayoutPanel.ColumnCount = 2;
            this.userInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.43648F));
            this.userInfoLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.56352F));
            this.userInfoLayoutPanel.Controls.Add(this.totBuyLabel, 1, 12);
            this.userInfoLayoutPanel.Controls.Add(this.label17, 0, 12);
            this.userInfoLayoutPanel.Controls.Add(this.label16, 0, 11);
            this.userInfoLayoutPanel.Controls.Add(this.label15, 0, 10);
            this.userInfoLayoutPanel.Controls.Add(this.stLabel, 1, 6);
            this.userInfoLayoutPanel.Controls.Add(this.ksLabel, 1, 5);
            this.userInfoLayoutPanel.Controls.Add(this.fwLabel, 1, 4);
            this.userInfoLayoutPanel.Controls.Add(this.unLabel, 1, 3);
            this.userInfoLayoutPanel.Controls.Add(this.uidLabel, 1, 2);
            this.userInfoLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.userInfoLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.userInfoLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.userInfoLayoutPanel.Controls.Add(this.label4, 0, 2);
            this.userInfoLayoutPanel.Controls.Add(this.label5, 0, 3);
            this.userInfoLayoutPanel.Controls.Add(this.label6, 0, 4);
            this.userInfoLayoutPanel.Controls.Add(this.label7, 0, 5);
            this.userInfoLayoutPanel.Controls.Add(this.label9, 0, 6);
            this.userInfoLayoutPanel.Controls.Add(this.accountListbox, 1, 1);
            this.userInfoLayoutPanel.Controls.Add(this.label11, 0, 7);
            this.userInfoLayoutPanel.Controls.Add(this.label13, 0, 8);
            this.userInfoLayoutPanel.Controls.Add(this.label14, 0, 9);
            this.userInfoLayoutPanel.Controls.Add(this.pcpLabel, 1, 7);
            this.userInfoLayoutPanel.Controls.Add(this.dayPcpLabel, 1, 8);
            this.userInfoLayoutPanel.Controls.Add(this.dayErnLabel, 1, 9);
            this.userInfoLayoutPanel.Controls.Add(this.accPcpLabel, 1, 10);
            this.userInfoLayoutPanel.Controls.Add(this.accErnLabel, 1, 11);
            this.userInfoLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userInfoLayoutPanel.Name = "userInfoLayoutPanel";
            this.userInfoLayoutPanel.RowCount = 13;
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.userInfoLayoutPanel.Size = new System.Drawing.Size(307, 413);
            this.userInfoLayoutPanel.TabIndex = 0;
            // 
            // totBuyLabel
            // 
            this.totBuyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totBuyLabel.AutoSize = true;
            this.totBuyLabel.Location = new System.Drawing.Point(204, 385);
            this.totBuyLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totBuyLabel.Name = "totBuyLabel";
            this.totBuyLabel.Size = new System.Drawing.Size(15, 15);
            this.totBuyLabel.TabIndex = 25;
            this.totBuyLabel.Text = "-";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 385);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "총매입금";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 349);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "누적투자손익";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 318);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "누적투자원금";
            // 
            // stLabel
            // 
            this.stLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stLabel.AutoSize = true;
            this.stLabel.Location = new System.Drawing.Point(204, 194);
            this.stLabel.Margin = new System.Windows.Forms.Padding(0);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(15, 15);
            this.stLabel.TabIndex = 13;
            this.stLabel.Text = "-";
            // 
            // ksLabel
            // 
            this.ksLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ksLabel.AutoSize = true;
            this.ksLabel.Location = new System.Drawing.Point(204, 163);
            this.ksLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ksLabel.Name = "ksLabel";
            this.ksLabel.Size = new System.Drawing.Size(15, 15);
            this.ksLabel.TabIndex = 12;
            this.ksLabel.Text = "-";
            // 
            // fwLabel
            // 
            this.fwLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fwLabel.AutoSize = true;
            this.fwLabel.Location = new System.Drawing.Point(204, 132);
            this.fwLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fwLabel.Name = "fwLabel";
            this.fwLabel.Size = new System.Drawing.Size(15, 15);
            this.fwLabel.TabIndex = 11;
            this.fwLabel.Text = "-";
            // 
            // unLabel
            // 
            this.unLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(204, 101);
            this.unLabel.Margin = new System.Windows.Forms.Padding(0);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(15, 15);
            this.unLabel.TabIndex = 10;
            this.unLabel.Text = "-";
            // 
            // uidLabel
            // 
            this.uidLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uidLabel.AutoSize = true;
            this.uidLabel.Location = new System.Drawing.Point(204, 70);
            this.uidLabel.Margin = new System.Windows.Forms.Padding(0);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(15, 15);
            this.uidLabel.TabIndex = 9;
            this.uidLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "계좌번호";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "정보";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "항목";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "유저 ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "이름";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "방화벽";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "키보드보안";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "서버 타입";
            // 
            // accountListbox
            // 
            this.accountListbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.accountListbox.FormattingEnabled = true;
            this.accountListbox.IntegralHeight = false;
            this.accountListbox.ItemHeight = 16;
            this.accountListbox.Location = new System.Drawing.Point(118, 32);
            this.accountListbox.Margin = new System.Windows.Forms.Padding(0);
            this.accountListbox.Name = "accountListbox";
            this.accountListbox.Size = new System.Drawing.Size(188, 22);
            this.accountListbox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 225);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "예수금";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 256);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "당일투자원금";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 287);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "당일투자손익";
            // 
            // pcpLabel
            // 
            this.pcpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcpLabel.AutoSize = true;
            this.pcpLabel.Location = new System.Drawing.Point(204, 225);
            this.pcpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pcpLabel.Name = "pcpLabel";
            this.pcpLabel.Size = new System.Drawing.Size(15, 15);
            this.pcpLabel.TabIndex = 18;
            this.pcpLabel.Text = "-";
            // 
            // dayPcpLabel
            // 
            this.dayPcpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayPcpLabel.AutoSize = true;
            this.dayPcpLabel.Location = new System.Drawing.Point(204, 256);
            this.dayPcpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dayPcpLabel.Name = "dayPcpLabel";
            this.dayPcpLabel.Size = new System.Drawing.Size(15, 15);
            this.dayPcpLabel.TabIndex = 19;
            this.dayPcpLabel.Text = "-";
            // 
            // dayErnLabel
            // 
            this.dayErnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayErnLabel.AutoSize = true;
            this.dayErnLabel.Location = new System.Drawing.Point(204, 287);
            this.dayErnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dayErnLabel.Name = "dayErnLabel";
            this.dayErnLabel.Size = new System.Drawing.Size(15, 15);
            this.dayErnLabel.TabIndex = 20;
            this.dayErnLabel.Text = "-";
            // 
            // accPcpLabel
            // 
            this.accPcpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accPcpLabel.AutoSize = true;
            this.accPcpLabel.Location = new System.Drawing.Point(204, 318);
            this.accPcpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accPcpLabel.Name = "accPcpLabel";
            this.accPcpLabel.Size = new System.Drawing.Size(15, 15);
            this.accPcpLabel.TabIndex = 21;
            this.accPcpLabel.Text = "-";
            // 
            // accErnLabel
            // 
            this.accErnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accErnLabel.AutoSize = true;
            this.accErnLabel.Location = new System.Drawing.Point(204, 349);
            this.accErnLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accErnLabel.Name = "accErnLabel";
            this.accErnLabel.Size = new System.Drawing.Size(15, 15);
            this.accErnLabel.TabIndex = 23;
            this.accErnLabel.Text = "-";
            // 
            // assetPage
            // 
            this.assetPage.Controls.Add(this.AssetChart);
            this.assetPage.Controls.Add(this.assetList);
            this.assetPage.Location = new System.Drawing.Point(4, 25);
            this.assetPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assetPage.Name = "assetPage";
            this.assetPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assetPage.Size = new System.Drawing.Size(310, 413);
            this.assetPage.TabIndex = 1;
            this.assetPage.Text = "보유자산";
            this.assetPage.UseVisualStyleBackColor = true;
            // 
            // AssetChart
            // 
            this.AssetChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.AssetChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AssetChart.Legends.Add(legend1);
            this.AssetChart.Location = new System.Drawing.Point(4, 4);
            this.AssetChart.Margin = new System.Windows.Forms.Padding(0);
            this.AssetChart.Name = "AssetChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.AssetChart.Series.Add(series1);
            this.AssetChart.Size = new System.Drawing.Size(303, 172);
            this.AssetChart.TabIndex = 1;
            this.AssetChart.Text = "chart1";
            // 
            // assetList
            // 
            this.assetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetList.AutoArrange = false;
            this.assetList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.assetName,
            this.quantity,
            this.averagePrice,
            this.buyAmount,
            this.evalAmount,
            this.earnings,
            this.earningPer});
            this.assetList.HideSelection = false;
            this.assetList.Location = new System.Drawing.Point(2, 176);
            this.assetList.Margin = new System.Windows.Forms.Padding(0);
            this.assetList.Name = "assetList";
            this.assetList.Size = new System.Drawing.Size(307, 237);
            this.assetList.TabIndex = 0;
            this.assetList.UseCompatibleStateImageBehavior = false;
            this.assetList.View = System.Windows.Forms.View.Details;
            // 
            // assetName
            // 
            this.assetName.Text = "종목명";
            this.assetName.Width = 70;
            // 
            // quantity
            // 
            this.quantity.Text = "수량";
            this.quantity.Width = 50;
            // 
            // averagePrice
            // 
            this.averagePrice.Text = "평단가";
            this.averagePrice.Width = 70;
            // 
            // buyAmount
            // 
            this.buyAmount.Text = "매수금액";
            this.buyAmount.Width = 70;
            // 
            // evalAmount
            // 
            this.evalAmount.Text = "평가금액";
            this.evalAmount.Width = 70;
            // 
            // earnings
            // 
            this.earnings.Text = "손익금액";
            this.earnings.Width = 70;
            // 
            // earningPer
            // 
            this.earningPer.Text = "손익률";
            this.earningPer.Width = 70;
            // 
            // requestButton
            // 
            this.requestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestButton.Location = new System.Drawing.Point(101, 0);
            this.requestButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(69, 34);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "조회";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 632);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 19;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.requestButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dailyButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.weeklyButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.monthlyButton, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemCodeTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.minuteButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.tickButton, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.n1Button, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.n3Button, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.n5Button, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.n10Button, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.n15Button, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.n30Button, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.n45Button, 15, 0);
            this.tableLayoutPanel2.Controls.Add(this.n60Button, 16, 0);
            this.tableLayoutPanel2.Controls.Add(this.itemNameLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.conditionButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(951, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dailyButton
            // 
            this.dailyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dailyButton.Location = new System.Drawing.Point(340, 0);
            this.dailyButton.Margin = new System.Windows.Forms.Padding(0);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(40, 34);
            this.dailyButton.TabIndex = 4;
            this.dailyButton.Text = "일";
            this.dailyButton.UseVisualStyleBackColor = true;
            this.dailyButton.Click += new System.EventHandler(this.DailyButton_Click);
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(380, 0);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(0);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(40, 34);
            this.weeklyButton.TabIndex = 5;
            this.weeklyButton.Text = "주";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.WeeklyButton_Click);
            // 
            // monthlyButton
            // 
            this.monthlyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.monthlyButton.Location = new System.Drawing.Point(420, 0);
            this.monthlyButton.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(40, 34);
            this.monthlyButton.TabIndex = 6;
            this.monthlyButton.Text = "월";
            this.monthlyButton.UseVisualStyleBackColor = true;
            this.monthlyButton.Click += new System.EventHandler(this.MonthlyButton_Click);
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCodeTextBox.Location = new System.Drawing.Point(3, 2);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(95, 25);
            this.itemCodeTextBox.TabIndex = 8;
            // 
            // minuteButton
            // 
            this.minuteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minuteButton.Location = new System.Drawing.Point(460, 0);
            this.minuteButton.Margin = new System.Windows.Forms.Padding(0);
            this.minuteButton.Name = "minuteButton";
            this.minuteButton.Size = new System.Drawing.Size(40, 34);
            this.minuteButton.TabIndex = 9;
            this.minuteButton.Text = "분";
            this.minuteButton.UseVisualStyleBackColor = true;
            this.minuteButton.Click += new System.EventHandler(this.MinuteButton_Click);
            // 
            // tickButton
            // 
            this.tickButton.Location = new System.Drawing.Point(500, 0);
            this.tickButton.Margin = new System.Windows.Forms.Padding(0);
            this.tickButton.Name = "tickButton";
            this.tickButton.Size = new System.Drawing.Size(40, 34);
            this.tickButton.TabIndex = 10;
            this.tickButton.Text = "틱";
            this.tickButton.UseVisualStyleBackColor = true;
            this.tickButton.Click += new System.EventHandler(this.TickButton_Click);
            // 
            // n1Button
            // 
            this.n1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n1Button.Enabled = false;
            this.n1Button.Location = new System.Drawing.Point(541, 1);
            this.n1Button.Margin = new System.Windows.Forms.Padding(1);
            this.n1Button.Name = "n1Button";
            this.n1Button.Size = new System.Drawing.Size(38, 32);
            this.n1Button.TabIndex = 11;
            this.n1Button.Text = "1";
            this.n1Button.UseVisualStyleBackColor = true;
            this.n1Button.Click += new System.EventHandler(this.N1Button_Click);
            // 
            // n3Button
            // 
            this.n3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n3Button.Enabled = false;
            this.n3Button.Location = new System.Drawing.Point(581, 1);
            this.n3Button.Margin = new System.Windows.Forms.Padding(1);
            this.n3Button.Name = "n3Button";
            this.n3Button.Size = new System.Drawing.Size(38, 32);
            this.n3Button.TabIndex = 12;
            this.n3Button.Text = "3";
            this.n3Button.UseVisualStyleBackColor = true;
            this.n3Button.Click += new System.EventHandler(this.N3Button_Click);
            // 
            // n5Button
            // 
            this.n5Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n5Button.Enabled = false;
            this.n5Button.Location = new System.Drawing.Point(621, 1);
            this.n5Button.Margin = new System.Windows.Forms.Padding(1);
            this.n5Button.Name = "n5Button";
            this.n5Button.Size = new System.Drawing.Size(38, 32);
            this.n5Button.TabIndex = 13;
            this.n5Button.Text = "5";
            this.n5Button.UseVisualStyleBackColor = true;
            this.n5Button.Click += new System.EventHandler(this.N5Button_Click);
            // 
            // n10Button
            // 
            this.n10Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n10Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n10Button.Enabled = false;
            this.n10Button.Location = new System.Drawing.Point(661, 1);
            this.n10Button.Margin = new System.Windows.Forms.Padding(1);
            this.n10Button.Name = "n10Button";
            this.n10Button.Size = new System.Drawing.Size(38, 32);
            this.n10Button.TabIndex = 14;
            this.n10Button.Text = "10";
            this.n10Button.UseVisualStyleBackColor = true;
            this.n10Button.Click += new System.EventHandler(this.N10Button_Click);
            // 
            // n15Button
            // 
            this.n15Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n15Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n15Button.Enabled = false;
            this.n15Button.Location = new System.Drawing.Point(701, 1);
            this.n15Button.Margin = new System.Windows.Forms.Padding(1);
            this.n15Button.Name = "n15Button";
            this.n15Button.Size = new System.Drawing.Size(38, 32);
            this.n15Button.TabIndex = 15;
            this.n15Button.Text = "15";
            this.n15Button.UseVisualStyleBackColor = true;
            this.n15Button.Click += new System.EventHandler(this.N15Button_Click);
            // 
            // n30Button
            // 
            this.n30Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n30Button.Enabled = false;
            this.n30Button.Location = new System.Drawing.Point(741, 1);
            this.n30Button.Margin = new System.Windows.Forms.Padding(1);
            this.n30Button.Name = "n30Button";
            this.n30Button.Size = new System.Drawing.Size(38, 32);
            this.n30Button.TabIndex = 16;
            this.n30Button.Text = "30";
            this.n30Button.UseVisualStyleBackColor = true;
            this.n30Button.Click += new System.EventHandler(this.N30Button_Click);
            // 
            // n45Button
            // 
            this.n45Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n45Button.Enabled = false;
            this.n45Button.Location = new System.Drawing.Point(781, 1);
            this.n45Button.Margin = new System.Windows.Forms.Padding(1);
            this.n45Button.Name = "n45Button";
            this.n45Button.Size = new System.Drawing.Size(38, 32);
            this.n45Button.TabIndex = 17;
            this.n45Button.Text = "45";
            this.n45Button.UseVisualStyleBackColor = true;
            this.n45Button.Click += new System.EventHandler(this.N45Button_Click);
            // 
            // n60Button
            // 
            this.n60Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n60Button.Enabled = false;
            this.n60Button.Location = new System.Drawing.Point(821, 1);
            this.n60Button.Margin = new System.Windows.Forms.Padding(1);
            this.n60Button.Name = "n60Button";
            this.n60Button.Size = new System.Drawing.Size(38, 32);
            this.n60Button.TabIndex = 18;
            this.n60Button.Text = "60";
            this.n60Button.UseVisualStyleBackColor = true;
            this.n60Button.Click += new System.EventHandler(this.N60Button_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(242, 2);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(95, 30);
            this.itemNameLabel.TabIndex = 19;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditionButton
            // 
            this.conditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionButton.Location = new System.Drawing.Point(170, 0);
            this.conditionButton.Margin = new System.Windows.Forms.Padding(0);
            this.conditionButton.Name = "conditionButton";
            this.conditionButton.Size = new System.Drawing.Size(69, 34);
            this.conditionButton.TabIndex = 20;
            this.conditionButton.Text = "조건식";
            this.conditionButton.UseVisualStyleBackColor = true;
            this.conditionButton.Click += new System.EventHandler(this.ConditionButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartYLabel);
            this.panel1.Controls.Add(this.mainChart);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 553);
            this.panel1.TabIndex = 3;
            // 
            // chartYLabel
            // 
            this.chartYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartYLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.chartYLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartYLabel.Location = new System.Drawing.Point(856, 35);
            this.chartYLabel.Name = "chartYLabel";
            this.chartYLabel.Size = new System.Drawing.Size(81, 23);
            this.chartYLabel.TabIndex = 5;
            this.chartYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartYLabel.Visible = false;
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainChart.BorderlineColor = System.Drawing.Color.LightGray;
            this.mainChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AlignWithChartArea = "volumeChartArea";
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.ScrollBar.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 92.36364F;
            chartArea2.InnerPlotPosition.Width = 90.32448F;
            chartArea2.InnerPlotPosition.X = 1.675532F;
            chartArea2.InnerPlotPosition.Y = 3.818182F;
            chartArea2.Name = "PriceChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 55F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 3F;
            chartArea3.AxisX.IsReversed = true;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 80.86906F;
            chartArea3.InnerPlotPosition.Width = 90.32448F;
            chartArea3.InnerPlotPosition.X = 1.675532F;
            chartArea3.InnerPlotPosition.Y = 4.999996F;
            chartArea3.Name = "volumeChartArea";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 38F;
            chartArea3.Position.Width = 94F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 59F;
            this.mainChart.ChartAreas.Add(chartArea2);
            this.mainChart.ChartAreas.Add(chartArea3);
            this.mainChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainChart.Location = new System.Drawing.Point(0, 2);
            this.mainChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainChart.Name = "mainChart";
            series2.ChartArea = "PriceChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Name = "priceSeries";
            series2.YValuesPerPoint = 4;
            series3.ChartArea = "volumeChartArea";
            series3.Name = "volumeSeries";
            series3.YValuesPerPoint = 4;
            this.mainChart.Series.Add(series2);
            this.mainChart.Series.Add(series3);
            this.mainChart.Size = new System.Drawing.Size(954, 549);
            this.mainChart.TabIndex = 1;
            this.mainChart.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 14;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel3.Controls.Add(this.evTextLabel, 12, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbrLabel, 11, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbrTextLabel, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.roeLabel, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.roeTextLabel, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.totalStockTextLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.totalStockLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.distribRatioTextLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.distribRatioLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.perLabel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.perTextLabel, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.epsTextLabel, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.epsLabel, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.evLabel, 13, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 42);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(951, 29);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // evTextLabel
            // 
            this.evTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.evTextLabel.Location = new System.Drawing.Point(820, 0);
            this.evTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.evTextLabel.Name = "evTextLabel";
            this.evTextLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.evTextLabel.Size = new System.Drawing.Size(50, 29);
            this.evTextLabel.TabIndex = 12;
            this.evTextLabel.Text = "EV";
            this.evTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbrLabel
            // 
            this.pbrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbrLabel.Location = new System.Drawing.Point(740, 0);
            this.pbrLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pbrLabel.Name = "pbrLabel";
            this.pbrLabel.Size = new System.Drawing.Size(80, 29);
            this.pbrLabel.TabIndex = 11;
            this.pbrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbrTextLabel
            // 
            this.pbrTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.pbrTextLabel.Location = new System.Drawing.Point(690, 0);
            this.pbrTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pbrTextLabel.Name = "pbrTextLabel";
            this.pbrTextLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pbrTextLabel.Size = new System.Drawing.Size(50, 29);
            this.pbrTextLabel.TabIndex = 10;
            this.pbrTextLabel.Text = "PBR";
            this.pbrTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roeLabel
            // 
            this.roeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roeLabel.Location = new System.Drawing.Point(610, 0);
            this.roeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.roeLabel.Name = "roeLabel";
            this.roeLabel.Size = new System.Drawing.Size(80, 29);
            this.roeLabel.TabIndex = 9;
            this.roeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roeTextLabel
            // 
            this.roeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roeTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.roeTextLabel.Location = new System.Drawing.Point(560, 0);
            this.roeTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.roeTextLabel.Name = "roeTextLabel";
            this.roeTextLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.roeTextLabel.Size = new System.Drawing.Size(50, 29);
            this.roeTextLabel.TabIndex = 8;
            this.roeTextLabel.Text = "ROE";
            this.roeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalStockTextLabel
            // 
            this.totalStockTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalStockTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.totalStockTextLabel.Location = new System.Drawing.Point(0, 0);
            this.totalStockTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalStockTextLabel.Name = "totalStockTextLabel";
            this.totalStockTextLabel.Size = new System.Drawing.Size(70, 29);
            this.totalStockTextLabel.TabIndex = 0;
            this.totalStockTextLabel.Text = "시가총액";
            this.totalStockTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalStockLabel
            // 
            this.totalStockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalStockLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalStockLabel.Location = new System.Drawing.Point(70, 0);
            this.totalStockLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalStockLabel.Name = "totalStockLabel";
            this.totalStockLabel.Size = new System.Drawing.Size(80, 29);
            this.totalStockLabel.TabIndex = 1;
            this.totalStockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distribRatioTextLabel
            // 
            this.distribRatioTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distribRatioTextLabel.AutoSize = true;
            this.distribRatioTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.distribRatioTextLabel.Location = new System.Drawing.Point(150, 0);
            this.distribRatioTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distribRatioTextLabel.Name = "distribRatioTextLabel";
            this.distribRatioTextLabel.Size = new System.Drawing.Size(70, 29);
            this.distribRatioTextLabel.TabIndex = 2;
            this.distribRatioTextLabel.Text = "유통비율";
            this.distribRatioTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distribRatioLabel
            // 
            this.distribRatioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distribRatioLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.distribRatioLabel.Location = new System.Drawing.Point(220, 0);
            this.distribRatioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distribRatioLabel.Name = "distribRatioLabel";
            this.distribRatioLabel.Size = new System.Drawing.Size(80, 29);
            this.distribRatioLabel.TabIndex = 3;
            this.distribRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perLabel
            // 
            this.perLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perLabel.Location = new System.Drawing.Point(350, 0);
            this.perLabel.Margin = new System.Windows.Forms.Padding(0);
            this.perLabel.Name = "perLabel";
            this.perLabel.Size = new System.Drawing.Size(80, 29);
            this.perLabel.TabIndex = 5;
            this.perLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perTextLabel
            // 
            this.perTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.perTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.perTextLabel.Location = new System.Drawing.Point(300, 0);
            this.perTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.perTextLabel.Name = "perTextLabel";
            this.perTextLabel.Size = new System.Drawing.Size(50, 29);
            this.perTextLabel.TabIndex = 4;
            this.perTextLabel.Text = "PER";
            this.perTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epsTextLabel
            // 
            this.epsTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.epsTextLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.epsTextLabel.Location = new System.Drawing.Point(430, 0);
            this.epsTextLabel.Margin = new System.Windows.Forms.Padding(0);
            this.epsTextLabel.Name = "epsTextLabel";
            this.epsTextLabel.Size = new System.Drawing.Size(50, 29);
            this.epsTextLabel.TabIndex = 6;
            this.epsTextLabel.Text = "EPS";
            this.epsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epsLabel
            // 
            this.epsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.epsLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.epsLabel.Location = new System.Drawing.Point(480, 0);
            this.epsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.epsLabel.Name = "epsLabel";
            this.epsLabel.Size = new System.Drawing.Size(80, 29);
            this.epsLabel.TabIndex = 7;
            this.epsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evLabel
            // 
            this.evLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evLabel.AutoSize = true;
            this.evLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.evLabel.Location = new System.Drawing.Point(870, 0);
            this.evLabel.Margin = new System.Windows.Forms.Padding(0);
            this.evLabel.Name = "evLabel";
            this.evLabel.Size = new System.Drawing.Size(81, 29);
            this.evLabel.TabIndex = 13;
            this.evLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideLayoutPanel
            // 
            this.SideLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SideLayoutPanel.ColumnCount = 1;
            this.SideLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SideLayoutPanel.Controls.Add(this.dealTab, 0, 0);
            this.SideLayoutPanel.Controls.Add(this.ActionTab, 0, 1);
            this.SideLayoutPanel.Location = new System.Drawing.Point(963, 8);
            this.SideLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SideLayoutPanel.Name = "SideLayoutPanel";
            this.SideLayoutPanel.RowCount = 2;
            this.SideLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.SideLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SideLayoutPanel.Size = new System.Drawing.Size(318, 632);
            this.SideLayoutPanel.TabIndex = 5;
            // 
            // ActionTab
            // 
            this.ActionTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionTab.Controls.Add(this.FunctionPage);
            this.ActionTab.Controls.Add(this.OptionPage);
            this.ActionTab.Location = new System.Drawing.Point(0, 442);
            this.ActionTab.Margin = new System.Windows.Forms.Padding(0);
            this.ActionTab.Name = "ActionTab";
            this.ActionTab.SelectedIndex = 0;
            this.ActionTab.Size = new System.Drawing.Size(318, 190);
            this.ActionTab.TabIndex = 2;
            // 
            // FunctionPage
            // 
            this.FunctionPage.Controls.Add(this.functionList);
            this.FunctionPage.Location = new System.Drawing.Point(4, 25);
            this.FunctionPage.Name = "FunctionPage";
            this.FunctionPage.Padding = new System.Windows.Forms.Padding(3);
            this.FunctionPage.Size = new System.Drawing.Size(310, 161);
            this.FunctionPage.TabIndex = 0;
            this.FunctionPage.Text = "기능";
            this.FunctionPage.UseVisualStyleBackColor = true;
            // 
            // functionList
            // 
            this.functionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionList.HideSelection = false;
            this.functionList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.functionList.LargeImageList = this.iconList;
            this.functionList.Location = new System.Drawing.Point(0, 0);
            this.functionList.Margin = new System.Windows.Forms.Padding(0);
            this.functionList.Name = "functionList";
            this.functionList.Size = new System.Drawing.Size(310, 161);
            this.functionList.TabIndex = 0;
            this.functionList.UseCompatibleStateImageBehavior = false;
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "dart.png");
            this.iconList.Images.SetKeyName(1, "naver.png");
            this.iconList.Images.SetKeyName(2, "news.png");
            this.iconList.Images.SetKeyName(3, "paxnet.png");
            // 
            // OptionPage
            // 
            this.OptionPage.Location = new System.Drawing.Point(4, 25);
            this.OptionPage.Name = "OptionPage";
            this.OptionPage.Size = new System.Drawing.Size(310, 161);
            this.OptionPage.TabIndex = 1;
            this.OptionPage.Text = "옵션";
            this.OptionPage.UseVisualStyleBackColor = true;
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 617);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(91, 29);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 642);
            this.Controls.Add(this.SideLayoutPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "종합차트";
            conditionPage.ResumeLayout(false);
            this.dealTab.ResumeLayout(false);
            this.userPage.ResumeLayout(false);
            this.userInfoLayoutPanel.ResumeLayout(false);
            this.userInfoLayoutPanel.PerformLayout();
            this.assetPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssetChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.SideLayoutPanel.ResumeLayout(false);
            this.ActionTab.ResumeLayout(false);
            this.FunctionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoTrader.APIExtention axKHOpenAPI1;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Label chartYLabel;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button monthlyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label totalStockTextLabel;
        private System.Windows.Forms.Label totalStockLabel;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.Label evTextLabel;
        private System.Windows.Forms.Label pbrLabel;
        private System.Windows.Forms.Label pbrTextLabel;
        private System.Windows.Forms.Label roeLabel;
        private System.Windows.Forms.Label roeTextLabel;
        private System.Windows.Forms.Label epsLabel;
        private System.Windows.Forms.Button minuteButton;
        private System.Windows.Forms.Button tickButton;
        private System.Windows.Forms.Button n1Button;
        private System.Windows.Forms.Button n3Button;
        private System.Windows.Forms.Button n5Button;
        private System.Windows.Forms.Button n10Button;
        private System.Windows.Forms.Button n15Button;
        private System.Windows.Forms.Button n30Button;
        private System.Windows.Forms.Button n45Button;
        private System.Windows.Forms.Button n60Button;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Button conditionButton;
        private System.Windows.Forms.TableLayoutPanel SideLayoutPanel;
        private System.Windows.Forms.TabPage assetPage;
        private System.Windows.Forms.TabControl dealTab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView stockList;
        private System.Windows.Forms.TabPage userPage;
        private System.Windows.Forms.TableLayoutPanel userInfoLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label fwLabel;
        private System.Windows.Forms.Label ksLabel;
        private System.Windows.Forms.Label stLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox accountListbox;
        private System.Windows.Forms.ListView assetList;
        private System.Windows.Forms.ColumnHeader assetName;
        private System.Windows.Forms.ColumnHeader evalAmount;
        private System.Windows.Forms.ColumnHeader earningPer;
        private System.Windows.Forms.DataVisualization.Charting.Chart AssetChart;
        private System.Windows.Forms.ColumnHeader buyAmount;
        private System.Windows.Forms.ColumnHeader earnings;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label pcpLabel;
        private System.Windows.Forms.Label dayPcpLabel;
        private System.Windows.Forms.Label dayErnLabel;
        private System.Windows.Forms.Label accPcpLabel;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader averagePrice;
        private System.Windows.Forms.Label totBuyLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label accErnLabel;
        private System.Windows.Forms.Label distribRatioTextLabel;
        private System.Windows.Forms.Label distribRatioLabel;
        private System.Windows.Forms.Label perLabel;
        private System.Windows.Forms.Label perTextLabel;
        private System.Windows.Forms.Label epsTextLabel;
        private System.Windows.Forms.Label evLabel;
        private System.Windows.Forms.ColumnHeader stockCode;
        private System.Windows.Forms.ColumnHeader stockName;
        private System.Windows.Forms.ColumnHeader upDownRate;
        private System.Windows.Forms.ColumnHeader volume;
        private System.Windows.Forms.TabControl ActionTab;
        private System.Windows.Forms.TabPage FunctionPage;
        private System.Windows.Forms.TabPage OptionPage;
        private System.Windows.Forms.ListView functionList;
        private System.Windows.Forms.ImageList iconList;
    }
}

