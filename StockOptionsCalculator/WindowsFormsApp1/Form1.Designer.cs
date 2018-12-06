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
            this.txtStrike = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.labelAsk = new System.Windows.Forms.Label();
            this.labelBid = new System.Windows.Forms.Label();
            this.labelStrike = new System.Windows.Forms.Label();
            this.lblUpFrontCosts = new System.Windows.Forms.Label();
            this.txtUpfrontCost = new System.Windows.Forms.TextBox();
            this.cbOne = new System.Windows.Forms.ComboBox();
            this.cbTwo = new System.Windows.Forms.ComboBox();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfitPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPricePerShare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfitPercent = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpgDefault = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabpgPos2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxSpread = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.spreadCalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpgDefault.SuspendLayout();
            this.tabpgPos2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStrike
            // 
            this.txtStrike.BackColor = System.Drawing.Color.White;
            this.txtStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStrike.Location = new System.Drawing.Point(10, 171);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(81, 22);
            this.txtStrike.TabIndex = 0;
            this.txtStrike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.Color.White;
            this.txtBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBid.Location = new System.Drawing.Point(185, 127);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(81, 22);
            this.txtBid.TabIndex = 1;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAsk
            // 
            this.txtAsk.BackColor = System.Drawing.Color.White;
            this.txtAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsk.Location = new System.Drawing.Point(10, 129);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.Size = new System.Drawing.Size(81, 22);
            this.txtAsk.TabIndex = 2;
            this.txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAsk
            // 
            this.labelAsk.AutoSize = true;
            this.labelAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsk.ForeColor = System.Drawing.Color.White;
            this.labelAsk.Location = new System.Drawing.Point(38, 110);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(34, 16);
            this.labelAsk.TabIndex = 6;
            this.labelAsk.Text = "Ask";
            // 
            // labelBid
            // 
            this.labelBid.AutoSize = true;
            this.labelBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBid.ForeColor = System.Drawing.Color.White;
            this.labelBid.Location = new System.Drawing.Point(213, 108);
            this.labelBid.Name = "labelBid";
            this.labelBid.Size = new System.Drawing.Size(31, 16);
            this.labelBid.TabIndex = 7;
            this.labelBid.Text = "Bid";
            // 
            // labelStrike
            // 
            this.labelStrike.AutoSize = true;
            this.labelStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrike.ForeColor = System.Drawing.Color.White;
            this.labelStrike.Location = new System.Drawing.Point(7, 152);
            this.labelStrike.Name = "labelStrike";
            this.labelStrike.Size = new System.Drawing.Size(88, 16);
            this.labelStrike.TabIndex = 8;
            this.labelStrike.Text = "Strike Price";
            // 
            // lblUpFrontCosts
            // 
            this.lblUpFrontCosts.AutoSize = true;
            this.lblUpFrontCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpFrontCosts.Location = new System.Drawing.Point(11, 18);
            this.lblUpFrontCosts.Name = "lblUpFrontCosts";
            this.lblUpFrontCosts.Size = new System.Drawing.Size(93, 16);
            this.lblUpFrontCosts.TabIndex = 10;
            this.lblUpFrontCosts.Text = "Upfront Risk";
            // 
            // txtUpfrontCost
            // 
            this.txtUpfrontCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpfrontCost.Location = new System.Drawing.Point(14, 38);
            this.txtUpfrontCost.Name = "txtUpfrontCost";
            this.txtUpfrontCost.Size = new System.Drawing.Size(100, 22);
            this.txtUpfrontCost.TabIndex = 9;
            this.txtUpfrontCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbOne
            // 
            this.cbOne.BackColor = System.Drawing.SystemColors.Window;
            this.cbOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOne.FormattingEnabled = true;
            this.cbOne.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.cbOne.Location = new System.Drawing.Point(10, 25);
            this.cbOne.Name = "cbOne";
            this.cbOne.Size = new System.Drawing.Size(108, 24);
            this.cbOne.TabIndex = 12;
            // 
            // cbTwo
            // 
            this.cbTwo.BackColor = System.Drawing.Color.White;
            this.cbTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTwo.FormattingEnabled = true;
            this.cbTwo.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.cbTwo.Location = new System.Drawing.Point(158, 25);
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.Size = new System.Drawing.Size(108, 24);
            this.cbTwo.TabIndex = 13;
            // 
            // txtContract
            // 
            this.txtContract.BackColor = System.Drawing.Color.White;
            this.txtContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContract.Location = new System.Drawing.Point(185, 171);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(81, 22);
            this.txtContract.TabIndex = 14;
            this.txtContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contracts";
            // 
            // txtProfitPoint
            // 
            this.txtProfitPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitPoint.Location = new System.Drawing.Point(14, 80);
            this.txtProfitPoint.Name = "txtProfitPoint";
            this.txtProfitPoint.Size = new System.Drawing.Size(100, 22);
            this.txtProfitPoint.TabIndex = 16;
            this.txtProfitPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Break Even Point";
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.BackColor = System.Drawing.Color.White;
            this.txtPricePerShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerShare.Location = new System.Drawing.Point(97, 82);
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(81, 22);
            this.txtPricePerShare.TabIndex = 18;
            this.txtPricePerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price per share";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxProfit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProfitPercent);
            this.groupBox1.Controls.Add(this.txtProfitPoint);
            this.groupBox1.Controls.Add(this.txtUpfrontCost);
            this.groupBox1.Controls.Add(this.lblUpFrontCosts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 114);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Upfront Profit";
            // 
            // txtMaxProfit
            // 
            this.txtMaxProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxProfit.Location = new System.Drawing.Point(151, 80);
            this.txtMaxProfit.Name = "txtMaxProfit";
            this.txtMaxProfit.Size = new System.Drawing.Size(100, 22);
            this.txtMaxProfit.TabIndex = 20;
            this.txtMaxProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Amount till Profitability";
            // 
            // txtProfitPercent
            // 
            this.txtProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitPercent.Location = new System.Drawing.Point(151, 38);
            this.txtProfitPercent.Name = "txtProfitPercent";
            this.txtProfitPercent.Size = new System.Drawing.Size(100, 22);
            this.txtProfitPercent.TabIndex = 18;
            this.txtProfitPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpgDefault);
            this.tabControl1.Controls.Add(this.tabpgPos2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 225);
            this.tabControl1.TabIndex = 21;
            // 
            // tabpgDefault
            // 
            this.tabpgDefault.BackColor = System.Drawing.Color.Black;
            this.tabpgDefault.Controls.Add(this.label12);
            this.tabpgDefault.Controls.Add(this.label5);
            this.tabpgDefault.Controls.Add(this.txtBid);
            this.tabpgDefault.Controls.Add(this.txtStrike);
            this.tabpgDefault.Controls.Add(this.label3);
            this.tabpgDefault.Controls.Add(this.cbTwo);
            this.tabpgDefault.Controls.Add(this.txtAsk);
            this.tabpgDefault.Controls.Add(this.cbOne);
            this.tabpgDefault.Controls.Add(this.txtPricePerShare);
            this.tabpgDefault.Controls.Add(this.labelAsk);
            this.tabpgDefault.Controls.Add(this.label1);
            this.tabpgDefault.Controls.Add(this.labelBid);
            this.tabpgDefault.Controls.Add(this.txtContract);
            this.tabpgDefault.Controls.Add(this.labelStrike);
            this.tabpgDefault.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabpgDefault.Location = new System.Drawing.Point(4, 22);
            this.tabpgDefault.Name = "tabpgDefault";
            this.tabpgDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDefault.Size = new System.Drawing.Size(285, 199);
            this.tabpgDefault.TabIndex = 0;
            this.tabpgDefault.Text = "Default Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Buy/Sell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(182, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Call/Put";
            // 
            // tabpgPos2
            // 
            this.tabpgPos2.BackColor = System.Drawing.Color.Black;
            this.tabpgPos2.Controls.Add(this.label7);
            this.tabpgPos2.Controls.Add(this.label8);
            this.tabpgPos2.Controls.Add(this.textBox1);
            this.tabpgPos2.Controls.Add(this.textBox2);
            this.tabpgPos2.Controls.Add(this.label9);
            this.tabpgPos2.Controls.Add(this.comboBox1);
            this.tabpgPos2.Controls.Add(this.textBox3);
            this.tabpgPos2.Controls.Add(this.comboBox2);
            this.tabpgPos2.Controls.Add(this.textBox4);
            this.tabpgPos2.Controls.Add(this.label10);
            this.tabpgPos2.Controls.Add(this.label11);
            this.tabpgPos2.Controls.Add(this.label13);
            this.tabpgPos2.Controls.Add(this.textBox5);
            this.tabpgPos2.Controls.Add(this.label14);
            this.tabpgPos2.Location = new System.Drawing.Point(4, 22);
            this.tabpgPos2.Name = "tabpgPos2";
            this.tabpgPos2.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgPos2.Size = new System.Drawing.Size(285, 199);
            this.tabpgPos2.TabIndex = 1;
            this.tabpgPos2.Text = "Position 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.spreadCalculateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 25);
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
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.calculateToolStripMenuItem.Text = "&Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(331, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 199);
            this.listBox1.TabIndex = 23;
            // 
            // checkBoxSpread
            // 
            this.checkBoxSpread.AutoSize = true;
            this.checkBoxSpread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpread.ForeColor = System.Drawing.Color.White;
            this.checkBoxSpread.Location = new System.Drawing.Point(331, 41);
            this.checkBoxSpread.Name = "checkBoxSpread";
            this.checkBoxSpread.Size = new System.Drawing.Size(78, 20);
            this.checkBoxSpread.TabIndex = 24;
            this.checkBoxSpread.Text = "Spread";
            this.checkBoxSpread.UseVisualStyleBackColor = true;
            this.checkBoxSpread.CheckedChanged += new System.EventHandler(this.checkBoxSpread_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(29, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Buy/Sell";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(182, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Call/Put";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(185, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 22);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(10, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(83, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Price per share";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.comboBox1.Location = new System.Drawing.Point(158, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 24);
            this.comboBox1.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(10, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 22);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.comboBox2.Location = new System.Drawing.Point(10, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(97, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 22);
            this.textBox4.TabIndex = 32;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(38, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ask";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Contracts";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(213, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Bid";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(185, 171);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 22);
            this.textBox5.TabIndex = 30;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(7, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Strike Price";
            // 
            // spreadCalculateToolStripMenuItem
            // 
            this.spreadCalculateToolStripMenuItem.Name = "spreadCalculateToolStripMenuItem";
            this.spreadCalculateToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.spreadCalculateToolStripMenuItem.Text = "&Calculate Spread";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(616, 388);
            this.Controls.Add(this.checkBoxSpread);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "StockOptions Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabpgDefault.ResumeLayout(false);
            this.tabpgDefault.PerformLayout();
            this.tabpgPos2.ResumeLayout(false);
            this.tabpgPos2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStrike;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.Label labelAsk;
        private System.Windows.Forms.Label labelBid;
        private System.Windows.Forms.Label labelStrike;
        private System.Windows.Forms.Label lblUpFrontCosts;
        private System.Windows.Forms.TextBox txtUpfrontCost;
        private System.Windows.Forms.ComboBox cbOne;
        private System.Windows.Forms.ComboBox cbTwo;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfitPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPricePerShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfitPercent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpgDefault;
        private System.Windows.Forms.TabPage tabpgPos2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxProfit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSpread;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem spreadCalculateToolStripMenuItem;
    }
}

