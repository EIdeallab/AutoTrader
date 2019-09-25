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
            System.Windows.Forms.TabPage buyTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dealTab = new System.Windows.Forms.TabControl();
            this.sellTab = new System.Windows.Forms.TabPage();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            buyTab = new System.Windows.Forms.TabPage();
            buyTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.dealTab.SuspendLayout();
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
            // buyTab
            // 
            buyTab.Controls.Add(this.tableLayoutPanel5);
            buyTab.Location = new System.Drawing.Point(4, 22);
            buyTab.Name = "buyTab";
            buyTab.Padding = new System.Windows.Forms.Padding(3);
            buyTab.Size = new System.Drawing.Size(264, 138);
            buyTab.TabIndex = 0;
            buyTab.Text = "매수";
            buyTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.78788F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.21212F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(264, 138);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문가능";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "매수가격";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "주문수량";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "비율설정";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "주문총액";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(0, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(76, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "매수";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(76, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 7;
            // 
            // dealTab
            // 
            this.dealTab.Controls.Add(buyTab);
            this.dealTab.Controls.Add(this.sellTab);
            this.dealTab.Location = new System.Drawing.Point(3, 161);
            this.dealTab.Multiline = true;
            this.dealTab.Name = "dealTab";
            this.dealTab.SelectedIndex = 0;
            this.dealTab.Size = new System.Drawing.Size(272, 164);
            this.dealTab.TabIndex = 1;
            // 
            // sellTab
            // 
            this.sellTab.Location = new System.Drawing.Point(4, 22);
            this.sellTab.Name = "sellTab";
            this.sellTab.Padding = new System.Windows.Forms.Padding(3);
            this.sellTab.Size = new System.Drawing.Size(264, 138);
            this.sellTab.TabIndex = 1;
            this.sellTab.Text = "매도";
            this.sellTab.UseVisualStyleBackColor = true;
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 617);
            this.axKHOpenAPI1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(73, 23);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(88, 0);
            this.requestButton.Margin = new System.Windows.Forms.Padding(0);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(52, 27);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 506);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 19;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 27);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // dailyButton
            // 
            this.dailyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.dailyButton.Location = new System.Drawing.Point(280, 0);
            this.dailyButton.Margin = new System.Windows.Forms.Padding(0);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(35, 27);
            this.dailyButton.TabIndex = 4;
            this.dailyButton.Text = "일";
            this.dailyButton.UseVisualStyleBackColor = true;
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(315, 0);
            this.weeklyButton.Margin = new System.Windows.Forms.Padding(0);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(35, 27);
            this.weeklyButton.TabIndex = 5;
            this.weeklyButton.Text = "주";
            this.weeklyButton.UseVisualStyleBackColor = true;
            // 
            // monthlyButton
            // 
            this.monthlyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.monthlyButton.Location = new System.Drawing.Point(350, 0);
            this.monthlyButton.Margin = new System.Windows.Forms.Padding(0);
            this.monthlyButton.Name = "monthlyButton";
            this.monthlyButton.Size = new System.Drawing.Size(35, 27);
            this.monthlyButton.TabIndex = 6;
            this.monthlyButton.Text = "월";
            this.monthlyButton.UseVisualStyleBackColor = true;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(3, 2);
            this.itemCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(82, 21);
            this.itemCodeTextBox.TabIndex = 8;
            // 
            // minuteButton
            // 
            this.minuteButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minuteButton.Location = new System.Drawing.Point(385, 0);
            this.minuteButton.Margin = new System.Windows.Forms.Padding(0);
            this.minuteButton.Name = "minuteButton";
            this.minuteButton.Size = new System.Drawing.Size(35, 27);
            this.minuteButton.TabIndex = 9;
            this.minuteButton.Text = "분";
            this.minuteButton.UseVisualStyleBackColor = true;
            // 
            // tickButton
            // 
            this.tickButton.Location = new System.Drawing.Point(420, 0);
            this.tickButton.Margin = new System.Windows.Forms.Padding(0);
            this.tickButton.Name = "tickButton";
            this.tickButton.Size = new System.Drawing.Size(35, 27);
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
            this.n1Button.Location = new System.Drawing.Point(456, 1);
            this.n1Button.Margin = new System.Windows.Forms.Padding(1);
            this.n1Button.Name = "n1Button";
            this.n1Button.Size = new System.Drawing.Size(33, 25);
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
            this.n3Button.Location = new System.Drawing.Point(491, 1);
            this.n3Button.Margin = new System.Windows.Forms.Padding(1);
            this.n3Button.Name = "n3Button";
            this.n3Button.Size = new System.Drawing.Size(33, 25);
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
            this.n5Button.Location = new System.Drawing.Point(526, 1);
            this.n5Button.Margin = new System.Windows.Forms.Padding(1);
            this.n5Button.Name = "n5Button";
            this.n5Button.Size = new System.Drawing.Size(33, 25);
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
            this.n10Button.Location = new System.Drawing.Point(561, 1);
            this.n10Button.Margin = new System.Windows.Forms.Padding(1);
            this.n10Button.Name = "n10Button";
            this.n10Button.Size = new System.Drawing.Size(33, 25);
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
            this.n15Button.Location = new System.Drawing.Point(596, 1);
            this.n15Button.Margin = new System.Windows.Forms.Padding(1);
            this.n15Button.Name = "n15Button";
            this.n15Button.Size = new System.Drawing.Size(33, 25);
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
            this.n30Button.Location = new System.Drawing.Point(631, 1);
            this.n30Button.Margin = new System.Windows.Forms.Padding(1);
            this.n30Button.Name = "n30Button";
            this.n30Button.Size = new System.Drawing.Size(33, 25);
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
            this.n45Button.Location = new System.Drawing.Point(666, 1);
            this.n45Button.Margin = new System.Windows.Forms.Padding(1);
            this.n45Button.Name = "n45Button";
            this.n45Button.Size = new System.Drawing.Size(33, 25);
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
            this.n60Button.Location = new System.Drawing.Point(701, 1);
            this.n60Button.Margin = new System.Windows.Forms.Padding(1);
            this.n60Button.Name = "n60Button";
            this.n60Button.Size = new System.Drawing.Size(33, 25);
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
            this.itemNameLabel.Location = new System.Drawing.Point(195, 2);
            this.itemNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(82, 23);
            this.itemNameLabel.TabIndex = 19;
            this.itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(140, 0);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(52, 27);
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
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 442);
            this.panel1.TabIndex = 3;
            // 
            // chartYLabel
            // 
            this.chartYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartYLabel.BackColor = System.Drawing.Color.NavajoWhite;
            this.chartYLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartYLabel.Location = new System.Drawing.Point(748, 28);
            this.chartYLabel.Name = "chartYLabel";
            this.chartYLabel.Size = new System.Drawing.Size(71, 19);
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
            this.MainChart.Location = new System.Drawing.Point(0, 2);
            this.MainChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "PriceChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Name = "priceSeries";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "volumeChartArea";
            series2.Name = "volumeSeries";
            this.MainChart.Series.Add(series1);
            this.MainChart.Series.Add(series2);
            this.MainChart.Size = new System.Drawing.Size(829, 434);
            this.MainChart.TabIndex = 1;
            this.MainChart.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 13;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(832, 23);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lowPriceLabel
            // 
            this.lowPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowPriceLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.lowPriceLabel.Location = new System.Drawing.Point(747, 0);
            this.lowPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lowPriceLabel.Name = "lowPriceLabel";
            this.lowPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lowPriceLabel.Size = new System.Drawing.Size(87, 23);
            this.lowPriceLabel.TabIndex = 12;
            this.lowPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.FloralWhite;
            this.label12.Location = new System.Drawing.Point(716, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 23);
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
            this.highPriceLabel.Location = new System.Drawing.Point(646, 0);
            this.highPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.highPriceLabel.Name = "highPriceLabel";
            this.highPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.highPriceLabel.Size = new System.Drawing.Size(70, 23);
            this.highPriceLabel.TabIndex = 10;
            this.highPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.FloralWhite;
            this.label10.Location = new System.Drawing.Point(615, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 23);
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
            this.openPriceLabel.Location = new System.Drawing.Point(545, 0);
            this.openPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.openPriceLabel.Name = "openPriceLabel";
            this.openPriceLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.openPriceLabel.Size = new System.Drawing.Size(70, 23);
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
            this.currentPriceLabel.Size = new System.Drawing.Size(70, 23);
            this.currentPriceLabel.TabIndex = 0;
            this.currentPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // netChangeLabel
            // 
            this.netChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netChangeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.netChangeLabel.Location = new System.Drawing.Point(70, 0);
            this.netChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.netChangeLabel.Name = "netChangeLabel";
            this.netChangeLabel.Size = new System.Drawing.Size(70, 23);
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
            this.fluctuationRateLabel.Location = new System.Drawing.Point(140, 0);
            this.fluctuationRateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fluctuationRateLabel.Name = "fluctuationRateLabel";
            this.fluctuationRateLabel.Size = new System.Drawing.Size(62, 23);
            this.fluctuationRateLabel.TabIndex = 2;
            this.fluctuationRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accumulatedVolumeLabel
            // 
            this.accumulatedVolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accumulatedVolumeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.accumulatedVolumeLabel.Location = new System.Drawing.Point(202, 0);
            this.accumulatedVolumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accumulatedVolumeLabel.Name = "accumulatedVolumeLabel";
            this.accumulatedVolumeLabel.Size = new System.Drawing.Size(94, 23);
            this.accumulatedVolumeLabel.TabIndex = 3;
            this.accumulatedVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turnoverRatioLabel
            // 
            this.turnoverRatioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.turnoverRatioLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.turnoverRatioLabel.Location = new System.Drawing.Point(364, 0);
            this.turnoverRatioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.turnoverRatioLabel.Name = "turnoverRatioLabel";
            this.turnoverRatioLabel.Size = new System.Drawing.Size(49, 23);
            this.turnoverRatioLabel.TabIndex = 5;
            this.turnoverRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // volumeChangeLabel
            // 
            this.volumeChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeChangeLabel.BackColor = System.Drawing.Color.FloralWhite;
            this.volumeChangeLabel.Location = new System.Drawing.Point(296, 0);
            this.volumeChangeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.volumeChangeLabel.Name = "volumeChangeLabel";
            this.volumeChangeLabel.Size = new System.Drawing.Size(68, 23);
            this.volumeChangeLabel.TabIndex = 4;
            this.volumeChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tradingValueLabel
            // 
            this.tradingValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradingValueLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tradingValueLabel.Location = new System.Drawing.Point(413, 0);
            this.tradingValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tradingValueLabel.Name = "tradingValueLabel";
            this.tradingValueLabel.Size = new System.Drawing.Size(101, 23);
            this.tradingValueLabel.TabIndex = 6;
            this.tradingValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Location = new System.Drawing.Point(514, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 23);
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
            this.tableLayoutPanel4.Controls.Add(this.dealTab, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(843, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.17518F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.82482F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(278, 506);
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
            this.OrderBook.Location = new System.Drawing.Point(3, 330);
            this.OrderBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.OrderBook.Size = new System.Drawing.Size(272, 173);
            this.OrderBook.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(76, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(76, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 21);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 514);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "종합차트";
            this.Load += new System.EventHandler(this.Form1_Load);
            buyTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.dealTab.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage sellTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl dealTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

