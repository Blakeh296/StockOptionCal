namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuickCal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTb_PPS = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_SetPrice = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_Strike = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_Contracts = new System.Windows.Forms.ToolStripTextBox();
            this.TSMenuItem_QuickCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.TsCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellPutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyPutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbSpread = new System.Windows.Forms.CheckBox();
            this.lbOutPut = new System.Windows.Forms.ListBox();
            this.gbPos2 = new System.Windows.Forms.GroupBox();
            this.cbPos2Call = new System.Windows.Forms.CheckBox();
            this.cbPos2Buy = new System.Windows.Forms.CheckBox();
            this.lblStrike = new System.Windows.Forms.Label();
            this.cbPos2Sell = new System.Windows.Forms.CheckBox();
            this.lblPos2SetPrice = new System.Windows.Forms.Label();
            this.cbPos2Put = new System.Windows.Forms.CheckBox();
            this.lblPos2ContractCount = new System.Windows.Forms.Label();
            this.tbPos2ContractCount = new System.Windows.Forms.TextBox();
            this.tbPos2Strike = new System.Windows.Forms.TextBox();
            this.tbPos2SetPrice = new System.Windows.Forms.TextBox();
            this.gbPos1 = new System.Windows.Forms.GroupBox();
            this.cbPos1Call = new System.Windows.Forms.CheckBox();
            this.cbPos1Buy = new System.Windows.Forms.CheckBox();
            this.cbPos1Sell = new System.Windows.Forms.CheckBox();
            this.cbPos1Put = new System.Windows.Forms.CheckBox();
            this.tbPos1ContractCount = new System.Windows.Forms.TextBox();
            this.tbPos1Premium = new System.Windows.Forms.TextBox();
            this.tbPos1Strike = new System.Windows.Forms.TextBox();
            this.lblPos1ContractCount = new System.Windows.Forms.Label();
            this.lblPos1SetPrice = new System.Windows.Forms.Label();
            this.lblPos1Strike = new System.Windows.Forms.Label();
            this.tbIndexSymbl = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblPPS = new System.Windows.Forms.Label();
            this.tbPPS = new System.Windows.Forms.TextBox();
            this.lbHelp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbPos2.SuspendLayout();
            this.gbPos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.tsQuickCal,
            this.TsCalculate,
            this.trainingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(680, 27);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsQuickCal
            // 
            this.tsQuickCal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripSeparator2,
            this.toolStripTb_PPS,
            this.toolStripTb_SetPrice,
            this.toolStripTb_Strike,
            this.toolStripTb_Contracts,
            this.TSMenuItem_QuickCalculate});
            this.tsQuickCal.Name = "tsQuickCal";
            this.tsQuickCal.Size = new System.Drawing.Size(74, 21);
            this.tsQuickCal.Text = "&Quick Cal";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Text = "Buy";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox2.Text = "Call";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripTb_PPS
            // 
            this.toolStripTb_PPS.Name = "toolStripTb_PPS";
            this.toolStripTb_PPS.Size = new System.Drawing.Size(100, 23);
            this.toolStripTb_PPS.Text = "PricePerShare";
            // 
            // toolStripTb_SetPrice
            // 
            this.toolStripTb_SetPrice.Name = "toolStripTb_SetPrice";
            this.toolStripTb_SetPrice.Size = new System.Drawing.Size(100, 23);
            this.toolStripTb_SetPrice.Text = "SetPrice";
            // 
            // toolStripTb_Strike
            // 
            this.toolStripTb_Strike.Name = "toolStripTb_Strike";
            this.toolStripTb_Strike.Size = new System.Drawing.Size(100, 23);
            this.toolStripTb_Strike.Text = "Strike";
            // 
            // toolStripTb_Contracts
            // 
            this.toolStripTb_Contracts.Name = "toolStripTb_Contracts";
            this.toolStripTb_Contracts.Size = new System.Drawing.Size(100, 23);
            this.toolStripTb_Contracts.Text = "Contracts";
            // 
            // TSMenuItem_QuickCalculate
            // 
            this.TSMenuItem_QuickCalculate.Name = "TSMenuItem_QuickCalculate";
            this.TSMenuItem_QuickCalculate.Size = new System.Drawing.Size(181, 22);
            this.TSMenuItem_QuickCalculate.Text = "Do Work";
            this.TSMenuItem_QuickCalculate.Click += new System.EventHandler(this.TSMenuItem_QuickCalculate_Click);
            // 
            // TsCalculate
            // 
            this.TsCalculate.Name = "TsCalculate";
            this.TsCalculate.Size = new System.Drawing.Size(72, 21);
            this.TsCalculate.Text = "&Calculate";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellPutToolStripMenuItem,
            this.buyPutToolStripMenuItem,
            this.buyCallToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.trainingToolStripMenuItem.Text = "&Training";
            // 
            // sellPutToolStripMenuItem
            // 
            this.sellPutToolStripMenuItem.Name = "sellPutToolStripMenuItem";
            this.sellPutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sellPutToolStripMenuItem.Text = "&Sell Put";
            this.sellPutToolStripMenuItem.Click += new System.EventHandler(this.sellPutToolStripMenuItem_Click);
            // 
            // buyPutToolStripMenuItem
            // 
            this.buyPutToolStripMenuItem.Name = "buyPutToolStripMenuItem";
            this.buyPutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.buyPutToolStripMenuItem.Text = "&Buy Put";
            this.buyPutToolStripMenuItem.Click += new System.EventHandler(this.buyPutToolStripMenuItem_Click);
            // 
            // buyCallToolStripMenuItem
            // 
            this.buyCallToolStripMenuItem.Name = "buyCallToolStripMenuItem";
            this.buyCallToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.buyCallToolStripMenuItem.Text = "&Buy Call";
            this.buyCallToolStripMenuItem.Click += new System.EventHandler(this.buyCallToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(494, 360);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 39);
            this.btnRefresh.TabIndex = 37;
            this.btnRefresh.Text = "Calculate/Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbSpread
            // 
            this.cbSpread.AutoSize = true;
            this.cbSpread.Location = new System.Drawing.Point(234, 49);
            this.cbSpread.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpread.Name = "cbSpread";
            this.cbSpread.Size = new System.Drawing.Size(74, 22);
            this.cbSpread.TabIndex = 36;
            this.cbSpread.Text = "Spread";
            this.cbSpread.UseVisualStyleBackColor = true;
            this.cbSpread.CheckedChanged += new System.EventHandler(this.cbSpread_CheckedChanged);
            // 
            // lbOutPut
            // 
            this.lbOutPut.FormattingEnabled = true;
            this.lbOutPut.ItemHeight = 18;
            this.lbOutPut.Location = new System.Drawing.Point(342, 13);
            this.lbOutPut.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutPut.Name = "lbOutPut";
            this.lbOutPut.Size = new System.Drawing.Size(320, 274);
            this.lbOutPut.TabIndex = 35;
            this.lbOutPut.SelectedIndexChanged += new System.EventHandler(this.lbOutPut_SelectedIndexChanged);
            // 
            // gbPos2
            // 
            this.gbPos2.Controls.Add(this.cbPos2Call);
            this.gbPos2.Controls.Add(this.cbPos2Buy);
            this.gbPos2.Controls.Add(this.lblStrike);
            this.gbPos2.Controls.Add(this.cbPos2Sell);
            this.gbPos2.Controls.Add(this.lblPos2SetPrice);
            this.gbPos2.Controls.Add(this.cbPos2Put);
            this.gbPos2.Controls.Add(this.lblPos2ContractCount);
            this.gbPos2.Controls.Add(this.tbPos2ContractCount);
            this.gbPos2.Controls.Add(this.tbPos2Strike);
            this.gbPos2.Controls.Add(this.tbPos2SetPrice);
            this.gbPos2.Location = new System.Drawing.Point(14, 263);
            this.gbPos2.Margin = new System.Windows.Forms.Padding(4);
            this.gbPos2.Name = "gbPos2";
            this.gbPos2.Padding = new System.Windows.Forms.Padding(4);
            this.gbPos2.Size = new System.Drawing.Size(320, 130);
            this.gbPos2.TabIndex = 34;
            this.gbPos2.TabStop = false;
            this.gbPos2.Text = "Position2";
            // 
            // cbPos2Call
            // 
            this.cbPos2Call.AutoSize = true;
            this.cbPos2Call.Location = new System.Drawing.Point(10, 63);
            this.cbPos2Call.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos2Call.Name = "cbPos2Call";
            this.cbPos2Call.Size = new System.Drawing.Size(52, 22);
            this.cbPos2Call.TabIndex = 16;
            this.cbPos2Call.Text = "Call";
            this.cbPos2Call.UseVisualStyleBackColor = true;
            // 
            // cbPos2Buy
            // 
            this.cbPos2Buy.AutoSize = true;
            this.cbPos2Buy.Location = new System.Drawing.Point(10, 33);
            this.cbPos2Buy.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos2Buy.Name = "cbPos2Buy";
            this.cbPos2Buy.Size = new System.Drawing.Size(52, 22);
            this.cbPos2Buy.TabIndex = 14;
            this.cbPos2Buy.Text = "Buy";
            this.cbPos2Buy.UseVisualStyleBackColor = true;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Location = new System.Drawing.Point(157, 67);
            this.lblStrike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(54, 18);
            this.lblStrike.TabIndex = 23;
            this.lblStrike.Text = "Strike :";
            // 
            // cbPos2Sell
            // 
            this.cbPos2Sell.AutoSize = true;
            this.cbPos2Sell.Location = new System.Drawing.Point(70, 33);
            this.cbPos2Sell.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos2Sell.Name = "cbPos2Sell";
            this.cbPos2Sell.Size = new System.Drawing.Size(51, 22);
            this.cbPos2Sell.TabIndex = 15;
            this.cbPos2Sell.Text = "Sell";
            this.cbPos2Sell.UseVisualStyleBackColor = true;
            // 
            // lblPos2SetPrice
            // 
            this.lblPos2SetPrice.AutoSize = true;
            this.lblPos2SetPrice.Location = new System.Drawing.Point(138, 36);
            this.lblPos2SetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos2SetPrice.Name = "lblPos2SetPrice";
            this.lblPos2SetPrice.Size = new System.Drawing.Size(76, 18);
            this.lblPos2SetPrice.TabIndex = 22;
            this.lblPos2SetPrice.Text = "Set Price :";
            // 
            // cbPos2Put
            // 
            this.cbPos2Put.AutoSize = true;
            this.cbPos2Put.Location = new System.Drawing.Point(70, 63);
            this.cbPos2Put.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos2Put.Name = "cbPos2Put";
            this.cbPos2Put.Size = new System.Drawing.Size(49, 22);
            this.cbPos2Put.TabIndex = 17;
            this.cbPos2Put.Text = "Put";
            this.cbPos2Put.UseVisualStyleBackColor = true;
            // 
            // lblPos2ContractCount
            // 
            this.lblPos2ContractCount.AutoSize = true;
            this.lblPos2ContractCount.Location = new System.Drawing.Point(27, 97);
            this.lblPos2ContractCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos2ContractCount.Name = "lblPos2ContractCount";
            this.lblPos2ContractCount.Size = new System.Drawing.Size(185, 18);
            this.lblPos2ContractCount.TabIndex = 21;
            this.lblPos2ContractCount.Text = "# of Contracts Purchased :";
            // 
            // tbPos2ContractCount
            // 
            this.tbPos2ContractCount.Location = new System.Drawing.Point(222, 94);
            this.tbPos2ContractCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2ContractCount.Name = "tbPos2ContractCount";
            this.tbPos2ContractCount.Size = new System.Drawing.Size(85, 24);
            this.tbPos2ContractCount.TabIndex = 18;
            // 
            // tbPos2Strike
            // 
            this.tbPos2Strike.Location = new System.Drawing.Point(222, 62);
            this.tbPos2Strike.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2Strike.Name = "tbPos2Strike";
            this.tbPos2Strike.Size = new System.Drawing.Size(85, 24);
            this.tbPos2Strike.TabIndex = 20;
            // 
            // tbPos2SetPrice
            // 
            this.tbPos2SetPrice.Location = new System.Drawing.Point(222, 30);
            this.tbPos2SetPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2SetPrice.Name = "tbPos2SetPrice";
            this.tbPos2SetPrice.Size = new System.Drawing.Size(85, 24);
            this.tbPos2SetPrice.TabIndex = 19;
            // 
            // gbPos1
            // 
            this.gbPos1.Controls.Add(this.cbPos1Call);
            this.gbPos1.Controls.Add(this.cbPos1Buy);
            this.gbPos1.Controls.Add(this.cbPos1Sell);
            this.gbPos1.Controls.Add(this.cbPos1Put);
            this.gbPos1.Controls.Add(this.tbPos1ContractCount);
            this.gbPos1.Controls.Add(this.tbPos1Premium);
            this.gbPos1.Controls.Add(this.tbPos1Strike);
            this.gbPos1.Controls.Add(this.lblPos1ContractCount);
            this.gbPos1.Controls.Add(this.lblPos1SetPrice);
            this.gbPos1.Controls.Add(this.lblPos1Strike);
            this.gbPos1.Location = new System.Drawing.Point(13, 125);
            this.gbPos1.Margin = new System.Windows.Forms.Padding(4);
            this.gbPos1.Name = "gbPos1";
            this.gbPos1.Padding = new System.Windows.Forms.Padding(4);
            this.gbPos1.Size = new System.Drawing.Size(321, 130);
            this.gbPos1.TabIndex = 33;
            this.gbPos1.TabStop = false;
            this.gbPos1.Text = "Position 1";
            // 
            // cbPos1Call
            // 
            this.cbPos1Call.AutoSize = true;
            this.cbPos1Call.Location = new System.Drawing.Point(8, 60);
            this.cbPos1Call.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos1Call.Name = "cbPos1Call";
            this.cbPos1Call.Size = new System.Drawing.Size(52, 22);
            this.cbPos1Call.TabIndex = 6;
            this.cbPos1Call.Text = "Call";
            this.cbPos1Call.UseVisualStyleBackColor = true;
            // 
            // cbPos1Buy
            // 
            this.cbPos1Buy.AutoSize = true;
            this.cbPos1Buy.Location = new System.Drawing.Point(8, 30);
            this.cbPos1Buy.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos1Buy.Name = "cbPos1Buy";
            this.cbPos1Buy.Size = new System.Drawing.Size(52, 22);
            this.cbPos1Buy.TabIndex = 4;
            this.cbPos1Buy.Text = "Buy";
            this.cbPos1Buy.UseVisualStyleBackColor = true;
            // 
            // cbPos1Sell
            // 
            this.cbPos1Sell.AutoSize = true;
            this.cbPos1Sell.Location = new System.Drawing.Point(68, 30);
            this.cbPos1Sell.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos1Sell.Name = "cbPos1Sell";
            this.cbPos1Sell.Size = new System.Drawing.Size(51, 22);
            this.cbPos1Sell.TabIndex = 5;
            this.cbPos1Sell.Text = "Sell";
            this.cbPos1Sell.UseVisualStyleBackColor = true;
            // 
            // cbPos1Put
            // 
            this.cbPos1Put.AutoSize = true;
            this.cbPos1Put.Location = new System.Drawing.Point(68, 60);
            this.cbPos1Put.Margin = new System.Windows.Forms.Padding(4);
            this.cbPos1Put.Name = "cbPos1Put";
            this.cbPos1Put.Size = new System.Drawing.Size(49, 22);
            this.cbPos1Put.TabIndex = 7;
            this.cbPos1Put.Text = "Put";
            this.cbPos1Put.UseVisualStyleBackColor = true;
            // 
            // tbPos1ContractCount
            // 
            this.tbPos1ContractCount.Location = new System.Drawing.Point(223, 93);
            this.tbPos1ContractCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos1ContractCount.Name = "tbPos1ContractCount";
            this.tbPos1ContractCount.Size = new System.Drawing.Size(85, 24);
            this.tbPos1ContractCount.TabIndex = 8;
            // 
            // tbPos1Premium
            // 
            this.tbPos1Premium.Location = new System.Drawing.Point(223, 28);
            this.tbPos1Premium.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos1Premium.Name = "tbPos1Premium";
            this.tbPos1Premium.Size = new System.Drawing.Size(85, 24);
            this.tbPos1Premium.TabIndex = 9;
            // 
            // tbPos1Strike
            // 
            this.tbPos1Strike.Location = new System.Drawing.Point(223, 61);
            this.tbPos1Strike.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos1Strike.Name = "tbPos1Strike";
            this.tbPos1Strike.Size = new System.Drawing.Size(85, 24);
            this.tbPos1Strike.TabIndex = 10;
            // 
            // lblPos1ContractCount
            // 
            this.lblPos1ContractCount.AutoSize = true;
            this.lblPos1ContractCount.Location = new System.Drawing.Point(27, 96);
            this.lblPos1ContractCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos1ContractCount.Name = "lblPos1ContractCount";
            this.lblPos1ContractCount.Size = new System.Drawing.Size(185, 18);
            this.lblPos1ContractCount.TabIndex = 11;
            this.lblPos1ContractCount.Text = "# of Contracts Purchased :";
            // 
            // lblPos1SetPrice
            // 
            this.lblPos1SetPrice.AutoSize = true;
            this.lblPos1SetPrice.Location = new System.Drawing.Point(136, 31);
            this.lblPos1SetPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos1SetPrice.Name = "lblPos1SetPrice";
            this.lblPos1SetPrice.Size = new System.Drawing.Size(76, 18);
            this.lblPos1SetPrice.TabIndex = 12;
            this.lblPos1SetPrice.Text = "Set Price :";
            // 
            // lblPos1Strike
            // 
            this.lblPos1Strike.AutoSize = true;
            this.lblPos1Strike.Location = new System.Drawing.Point(158, 64);
            this.lblPos1Strike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos1Strike.Name = "lblPos1Strike";
            this.lblPos1Strike.Size = new System.Drawing.Size(54, 18);
            this.lblPos1Strike.TabIndex = 13;
            this.lblPos1Strike.Text = "Strike :";
            // 
            // tbIndexSymbl
            // 
            this.tbIndexSymbl.Location = new System.Drawing.Point(141, 49);
            this.tbIndexSymbl.Margin = new System.Windows.Forms.Padding(4);
            this.tbIndexSymbl.Name = "tbIndexSymbl";
            this.tbIndexSymbl.Size = new System.Drawing.Size(85, 24);
            this.tbIndexSymbl.TabIndex = 32;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(14, 52);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(104, 18);
            this.lblSymbol.TabIndex = 31;
            this.lblSymbol.Text = "Index Symbol :";
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.Location = new System.Drawing.Point(13, 86);
            this.lblPPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(120, 18);
            this.lblPPS.TabIndex = 30;
            this.lblPPS.Text = "Price Per Share :";
            // 
            // tbPPS
            // 
            this.tbPPS.Location = new System.Drawing.Point(141, 83);
            this.tbPPS.Margin = new System.Windows.Forms.Padding(4);
            this.tbPPS.Name = "tbPPS";
            this.tbPPS.Size = new System.Drawing.Size(85, 24);
            this.tbPPS.TabIndex = 29;
            // 
            // lbHelp
            // 
            this.lbHelp.BackColor = System.Drawing.Color.White;
            this.lbHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHelp.Location = new System.Drawing.Point(342, 291);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(320, 65);
            this.lbHelp.TabIndex = 38;
            this.lbHelp.Text = "*HINT DBL Click to clear output.  Single Click to read txt.";
            this.lbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHelp.DoubleClick += new System.EventHandler(this.lbHelp_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(680, 407);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbSpread);
            this.Controls.Add(this.lbOutPut);
            this.Controls.Add(this.gbPos2);
            this.Controls.Add(this.gbPos1);
            this.Controls.Add(this.tbIndexSymbl);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblPPS);
            this.Controls.Add(this.tbPPS);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "StockOptions Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPos2.ResumeLayout(false);
            this.gbPos2.PerformLayout();
            this.gbPos1.ResumeLayout(false);
            this.gbPos1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsQuickCal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsCalculate;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_PPS;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_SetPrice;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_Strike;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_Contracts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_QuickCalculate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox cbSpread;
        private System.Windows.Forms.ListBox lbOutPut;
        private System.Windows.Forms.GroupBox gbPos2;
        private System.Windows.Forms.CheckBox cbPos2Call;
        private System.Windows.Forms.CheckBox cbPos2Buy;
        private System.Windows.Forms.Label lblStrike;
        private System.Windows.Forms.CheckBox cbPos2Sell;
        private System.Windows.Forms.Label lblPos2SetPrice;
        private System.Windows.Forms.CheckBox cbPos2Put;
        private System.Windows.Forms.Label lblPos2ContractCount;
        private System.Windows.Forms.TextBox tbPos2ContractCount;
        private System.Windows.Forms.TextBox tbPos2Strike;
        private System.Windows.Forms.TextBox tbPos2SetPrice;
        private System.Windows.Forms.GroupBox gbPos1;
        private System.Windows.Forms.CheckBox cbPos1Call;
        private System.Windows.Forms.CheckBox cbPos1Buy;
        private System.Windows.Forms.CheckBox cbPos1Sell;
        private System.Windows.Forms.CheckBox cbPos1Put;
        private System.Windows.Forms.TextBox tbPos1ContractCount;
        private System.Windows.Forms.TextBox tbPos1Premium;
        private System.Windows.Forms.TextBox tbPos1Strike;
        private System.Windows.Forms.Label lblPos1ContractCount;
        private System.Windows.Forms.Label lblPos1SetPrice;
        private System.Windows.Forms.Label lblPos1Strike;
        private System.Windows.Forms.TextBox tbIndexSymbl;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.TextBox tbPPS;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellPutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyPutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyCallToolStripMenuItem;
    }
}

