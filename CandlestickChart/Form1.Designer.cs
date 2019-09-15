namespace CandlestickChart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
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
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartYLabel = new System.Windows.Forms.Label();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lowPriceLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.highPriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openPriceLabel = new System.Windows.Forms.Label();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.netChangeLabel = new System.Windows.Forms.Label();
            this.fluctuationRateLabel = new System.Windows.Forms.Label();
            this.accumulatedVolumeLabel = new System.Windows.Forms.Label();
            this.turnoverRatioLabel = new System.Windows.Forms.Label();
            this.volumeChangeLabel = new System.Windows.Forms.Label();
            this.tradingValueLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.OrderBook = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBook)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 617);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(73, 23);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(100, 0);
            this.requestButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(59, 34);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "조회";
            this.requestButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 633);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 19;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
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
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(951, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dailyButton
            // 
            this.dailyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dailyButton.Location = new System.Drawing.Point(320, 0);
            this.dailyButton.Margin = new System.Windows.Forms.Padding(0);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(40, 34);
            this.dailyButton.TabIndex = 4;
            this.dailyButton.Text = "일";
            this.dailyButton.UseVisualStyleBackColor = true;
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(360, 0);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(0);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(40, 34);
            this.weeklyButton.TabIndex = 5;
            this.weeklyButton.Text = "주";
            this.weeklyButton.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            this.monthlyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.monthlyButton.Location = new System.Drawing.Point(400, 0);
            this.monthlyButton.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(40, 34);
            this.monthlyButton.TabIndex = 6;
            this.monthlyButton.Text = "월";
            this.monthlyButton.UseVisualStyleBackColor = true;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(3, 3);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(94, 25);
            this.itemCodeTextBox.TabIndex = 8;
            // 
            // minuteButton
            // 
            this.minuteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minuteButton.Location = new System.Drawing.Point(440, 0);
            this.minuteButton.Margin = new System.Windows.Forms.Padding(0);
            this.minuteButton.Name = "minuteButton";
            this.minuteButton.Size = new System.Drawing.Size(40, 34);
            this.minuteButton.TabIndex = 9;
            this.minuteButton.Text = "분";
            this.minuteButton.UseVisualStyleBackColor = true;
            // 
            // tickButton
            // 
            this.tickButton.Location = new System.Drawing.Point(480, 0);
            this.tickButton.Margin = new System.Windows.Forms.Padding(0);
            this.tickButton.Name = "tickButton";
            this.tickButton.Size = new System.Drawing.Size(40, 34);
            this.tickButton.TabIndex = 10;
            this.tickButton.Text = "틱";
            this.tickButton.UseVisualStyleBackColor = true;
            // 
            // n1Button
            // 
            this.n1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n1Button.Enabled = false;
            this.n1Button.Location = new System.Drawing.Point(521, 1);
            this.n1Button.Margin = new System.Windows.Forms.Padding(1);
            this.n1Button.Name = "n1Button";
            this.n1Button.Size = new System.Drawing.Size(38, 32);
            this.n1Button.TabIndex = 11;
            this.n1Button.Text = "1";
            this.n1Button.UseVisualStyleBackColor = true;
            // 
            // n3Button
            // 
            this.n3Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n3Button.Enabled = false;
            this.n3Button.Location = new System.Drawing.Point(561, 1);
            this.n3Button.Margin = new System.Windows.Forms.Padding(1);
            this.n3Button.Name = "n3Button";
            this.n3Button.Size = new System.Drawing.Size(38, 32);
            this.n3Button.TabIndex = 12;
            this.n3Button.Text = "3";
            this.n3Button.UseVisualStyleBackColor = true;
            // 
            // n5Button
            // 
            this.n5Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n5Button.Enabled = false;
            this.n5Button.Location = new System.Drawing.Point(601, 1);
            this.n5Button.Margin = new System.Windows.Forms.Padding(1);
            this.n5Button.Name = "n5Button";
            this.n5Button.Size = new System.Drawing.Size(38, 32);
            this.n5Button.TabIndex = 13;
            this.n5Button.Text = "5";
            this.n5Button.UseVisualStyleBackColor = true;
            // 
            // n10Button
            // 
            this.n10Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n10Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n10Button.Enabled = false;
            this.n10Button.Location = new System.Drawing.Point(641, 1);
            this.n10Button.Margin = new System.Windows.Forms.Padding(1);
            this.n10Button.Name = "n10Button";
            this.n10Button.Size = new System.Drawing.Size(38, 32);
            this.n10Button.TabIndex = 14;
            this.n10Button.Text = "10";
            this.n10Button.UseVisualStyleBackColor = true;
            // 
            // n15Button
            // 
            this.n15Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n15Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.n15Button.Enabled = false;
            this.n15Button.Location = new System.Drawing.Point(681, 1);
            this.n15Button.Margin = new System.Windows.Forms.Padding(1);
            this.n15Button.Name = "n15Button";
            this.n15Button.Size = new System.Drawing.Size(38, 32);
            this.n15Button.TabIndex = 15;
            this.n15Button.Text = "15";
            this.n15Button.UseVisualStyleBackColor = true;
            // 
            // n30Button
            // 
            this.n30Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n30Button.Enabled = false;
            this.n30Button.Location = new System.Drawing.Point(721, 1);
            this.n30Button.Margin = new System.Windows.Forms.Padding(1);
            this.n30Button.Name = "n30Button";
            this.n30Button.Size = new System.Drawing.Size(38, 32);
            this.n30Button.TabIndex = 16;
            this.n30Button.Text = "30";
            this.n30Button.UseVisualStyleBackColor = true;
            // 
            // n45Button
            // 
            this.n45Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n45Button.Enabled = false;
            this.n45Button.Location = new System.Drawing.Point(761, 1);
            this.n45Button.Margin = new System.Windows.Forms.Padding(1);
            this.n45Button.Name = "n45Button";
            this.n45Button.Size = new System.Drawing.Size(38, 32);
            this.n45Button.TabIndex = 17;
            this.n45Button.Text = "45";
            this.n45Button.UseVisualStyleBackColor = true;
            // 
            // n60Button
            // 
            this.n60Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.n60Button.Enabled = false;
            this.n60Button.Location = new System.Drawing.Point(801, 1);
            this.n60Button.Margin = new System.Windows.Forms.Padding(1);
            this.n60Button.Name = "n60Button";
            this.n60Button.Size = new System.Drawing.Size(38, 32);
            this.n60Button.TabIndex = 18;
            this.n60Button.Text = "60";
            this.n60Button.UseVisualStyleBackColor = true;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemNameLabel.ForeColor = System.Drawing.Color.White;
            this.itemNameLabel.Location = new System.Drawing.Point(223, 3);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(94, 28);
            this.itemNameLabel.TabIndex = 19;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(160, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(60, 34);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chartYLabel);
            this.panel1.Controls.Add(this.MainChart);
            this.panel1.Location = new System.Drawing.Point(3, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 552);
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
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignWithChartArea = "volumeChartArea";
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.ScrollBar.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 92.36364F;
            chartArea1.InnerPlotPosition.Width = 90.32448F;
            chartArea1.InnerPlotPosition.X = 1.675532F;
            chartArea1.InnerPlotPosition.Y = 3.818182F;
            chartArea1.Name = "PriceChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 55F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chartArea2.AxisX.IsReversed = true;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 80.86906F;
            chartArea2.InnerPlotPosition.Width = 90.32448F;
            chartArea2.InnerPlotPosition.X = 1.675532F;
            chartArea2.InnerPlotPosition.Y = 4.999996F;
            chartArea2.Name = "volumeChartArea";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 38F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 59F;
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.ChartAreas.Add(chartArea2);
            this.MainChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainChart.Location = new System.Drawing.Point(0, 3);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "PriceChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Name = "priceSeries";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "volumeChartArea";
            series2.Name = "volumeSeries";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Size = new System.Drawing.Size(949, 543);
            this.MainChart.TabIndex = 1;
            this.MainChart.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 13;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.Controls.Add(this.lowPriceLabel, 12, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 11, 0);
            this.tableLayoutPanel3.Controls.Add(this.highPriceLabel, 10, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.openPriceLabel, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.currentPriceLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.netChangeLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.fluctuationRateLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.accumulatedVolumeLabel, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.turnoverRatioLabel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.volumeChangeLabel, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tradingValueLabel, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(951, 29);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lowPriceLabel
            // 
            this.lowPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.lowPriceLabel.Location = new System.Drawing.Point(852, 0);
            this.lowPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lowPriceLabel.Name = "lowPriceLabel";
            this.lowPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lowPriceLabel.Size = new System.Drawing.Size(99, 29);
            this.lowPriceLabel.TabIndex = 12;
            this.lowPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FloralWhite;
            this.label12.Location = new System.Drawing.Point(817, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 29);
            this.label12.TabIndex = 11;
            this.label12.Text = "저";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // highPriceLabel
            // 
            this.highPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.highPriceLabel.Location = new System.Drawing.Point(737, 0);
            this.highPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.highPriceLabel.Name = "highPriceLabel";
            this.highPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.highPriceLabel.Size = new System.Drawing.Size(80, 29);
            this.highPriceLabel.TabIndex = 10;
            this.highPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(702, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "고";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openPriceLabel
            // 
            this.openPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.openPriceLabel.Location = new System.Drawing.Point(622, 0);
            this.openPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.openPriceLabel.Name = "openPriceLabel";
            this.openPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.openPriceLabel.Size = new System.Drawing.Size(80, 29);
            this.openPriceLabel.TabIndex = 8;
            this.openPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentPriceLabel
            // 
            this.currentPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPriceLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.currentPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.currentPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(80, 29);
            this.currentPriceLabel.TabIndex = 0;
            this.currentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // netChangeLabel
            // 
            this.netChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netChangeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.netChangeLabel.Location = new System.Drawing.Point(80, 0);
            this.netChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.netChangeLabel.Name = "netChangeLabel";
            this.netChangeLabel.Size = new System.Drawing.Size(80, 29);
            this.netChangeLabel.TabIndex = 1;
            this.netChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fluctuationRateLabel
            // 
            this.fluctuationRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fluctuationRateLabel.AutoSize = true;
            this.fluctuationRateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fluctuationRateLabel.Location = new System.Drawing.Point(160, 0);
            this.fluctuationRateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fluctuationRateLabel.Name = "fluctuationRateLabel";
            this.fluctuationRateLabel.Size = new System.Drawing.Size(71, 29);
            this.fluctuationRateLabel.TabIndex = 2;
            this.fluctuationRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accumulatedVolumeLabel
            // 
            this.accumulatedVolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accumulatedVolumeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.accumulatedVolumeLabel.Location = new System.Drawing.Point(231, 0);
            this.accumulatedVolumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accumulatedVolumeLabel.Name = "accumulatedVolumeLabel";
            this.accumulatedVolumeLabel.Size = new System.Drawing.Size(107, 29);
            this.accumulatedVolumeLabel.TabIndex = 3;
            this.accumulatedVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turnoverRatioLabel
            // 
            this.turnoverRatioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turnoverRatioLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.turnoverRatioLabel.Location = new System.Drawing.Point(416, 0);
            this.turnoverRatioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.turnoverRatioLabel.Name = "turnoverRatioLabel";
            this.turnoverRatioLabel.Size = new System.Drawing.Size(56, 29);
            this.turnoverRatioLabel.TabIndex = 5;
            this.turnoverRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // volumeChangeLabel
            // 
            this.volumeChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeChangeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.volumeChangeLabel.Location = new System.Drawing.Point(338, 0);
            this.volumeChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.volumeChangeLabel.Name = "volumeChangeLabel";
            this.volumeChangeLabel.Size = new System.Drawing.Size(78, 29);
            this.volumeChangeLabel.TabIndex = 4;
            this.volumeChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tradingValueLabel
            // 
            this.tradingValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradingValueLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tradingValueLabel.Location = new System.Drawing.Point(472, 0);
            this.tradingValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tradingValueLabel.Name = "tradingValueLabel";
            this.tradingValueLabel.Size = new System.Drawing.Size(115, 29);
            this.tradingValueLabel.TabIndex = 6;
            this.tradingValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(587, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "시";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.88679F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.11321F));
            this.tableLayoutPanel4.Controls.Add(this.OrderBook, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(963, 7);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82482F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(318, 633);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // OrderBook
            // 
            chartArea3.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.OrderBook.ChartAreas.Add(chartArea3);
            this.OrderBook.Location = new System.Drawing.Point(3, 414);
            this.OrderBook.Name = "OrderBook";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Name = "askSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Name = "bidSeries";
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series4.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            this.OrderBook.Series.Add(series3);
            this.OrderBook.Series.Add(series4);
            this.OrderBook.Size = new System.Drawing.Size(312, 216);
            this.OrderBook.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 643);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "종합차트";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Label chartYLabel;
        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button monthlyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Label netChangeLabel;
        private System.Windows.Forms.Label fluctuationRateLabel;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.Label accumulatedVolumeLabel;
        private System.Windows.Forms.Label turnoverRatioLabel;
        private System.Windows.Forms.Label volumeChangeLabel;
        private System.Windows.Forms.Label tradingValueLabel;
        private System.Windows.Forms.Label lowPriceLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label highPriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label openPriceLabel;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart OrderBook;
    }
}

