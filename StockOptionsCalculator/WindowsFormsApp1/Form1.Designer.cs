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
            this.pPSPricePerShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPPSts = new System.Windows.Forms.ToolStripTextBox();
            this.indexSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbIndexSymblTs = new System.Windows.Forms.ToolStripTextBox();
            this.TsCalculate = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.gbPos2.SuspendLayout();
            this.gbPos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsCalculate,
            this.tbPPSts,
            this.pPSPricePerShareToolStripMenuItem,
            this.tbIndexSymblTs,
            this.indexSymbolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-11, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(549, 29);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pPSPricePerShareToolStripMenuItem
            // 
            this.pPSPricePerShareToolStripMenuItem.Name = "pPSPricePerShareToolStripMenuItem";
            this.pPSPricePerShareToolStripMenuItem.Size = new System.Drawing.Size(153, 23);
            this.pPSPricePerShareToolStripMenuItem.Text = ": PPS (Price per Share) ";
            // 
            // tbPPSts
            // 
            this.tbPPSts.Name = "tbPPSts";
            this.tbPPSts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPPSts.Size = new System.Drawing.Size(100, 23);
            // 
            // indexSymbolToolStripMenuItem
            // 
            this.indexSymbolToolStripMenuItem.Name = "indexSymbolToolStripMenuItem";
            this.indexSymbolToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.indexSymbolToolStripMenuItem.Text = ": Index Symbol ";
            // 
            // tbIndexSymblTs
            // 
            this.tbIndexSymblTs.Name = "tbIndexSymblTs";
            this.tbIndexSymblTs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbIndexSymblTs.Size = new System.Drawing.Size(100, 23);
            // 
            // TsCalculate
            // 
            this.TsCalculate.Name = "TsCalculate";
            this.TsCalculate.Size = new System.Drawing.Size(72, 23);
            this.TsCalculate.Text = "&Calculate";
            this.TsCalculate.Click += new System.EventHandler(this.TsCalculate_Click);
            // 
            // cbSpread
            // 
            this.cbSpread.AutoSize = true;
            this.cbSpread.Location = new System.Drawing.Point(8, 1);
            this.cbSpread.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpread.Name = "cbSpread";
            this.cbSpread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbSpread.Size = new System.Drawing.Size(74, 22);
            this.cbSpread.TabIndex = 36;
            this.cbSpread.Text = "Spread";
            this.cbSpread.UseVisualStyleBackColor = true;
            this.cbSpread.CheckedChanged += new System.EventHandler(this.cbSpread_CheckedChanged);
            // 
            // lbOutPut
            // 
            this.lbOutPut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutPut.FormattingEnabled = true;
            this.lbOutPut.HorizontalScrollbar = true;
            this.lbOutPut.ItemHeight = 18;
            this.lbOutPut.Location = new System.Drawing.Point(3, 33);
            this.lbOutPut.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutPut.Name = "lbOutPut";
            this.lbOutPut.Size = new System.Drawing.Size(237, 130);
            this.lbOutPut.TabIndex = 35;
            this.lbOutPut.DoubleClick += new System.EventHandler(this.lbOutPut_DoubleClick);
            // 
            // gbPos2
            // 
            this.gbPos2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPos2.BackColor = System.Drawing.Color.Gainsboro;
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
            this.gbPos2.Location = new System.Drawing.Point(248, 171);
            this.gbPos2.Margin = new System.Windows.Forms.Padding(4);
            this.gbPos2.Name = "gbPos2";
            this.gbPos2.Padding = new System.Windows.Forms.Padding(4);
            this.gbPos2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPos2.Size = new System.Drawing.Size(300, 130);
            this.gbPos2.TabIndex = 34;
            this.gbPos2.TabStop = false;
            this.gbPos2.Text = "Position2";
            // 
            // cbPos2Call
            // 
            this.cbPos2Call.AutoSize = true;
            this.cbPos2Call.Location = new System.Drawing.Point(19, 63);
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
            this.cbPos2Buy.Location = new System.Drawing.Point(19, 33);
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
            this.lblStrike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStrike.Size = new System.Drawing.Size(54, 18);
            this.lblStrike.TabIndex = 23;
            this.lblStrike.Text = "Strike :";
            // 
            // cbPos2Sell
            // 
            this.cbPos2Sell.AutoSize = true;
            this.cbPos2Sell.Location = new System.Drawing.Point(79, 33);
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
            this.lblPos2SetPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPos2SetPrice.Size = new System.Drawing.Size(76, 18);
            this.lblPos2SetPrice.TabIndex = 22;
            this.lblPos2SetPrice.Text = "Set Price :";
            // 
            // cbPos2Put
            // 
            this.cbPos2Put.AutoSize = true;
            this.cbPos2Put.Location = new System.Drawing.Point(81, 63);
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
            this.lblPos2ContractCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPos2ContractCount.Size = new System.Drawing.Size(185, 18);
            this.lblPos2ContractCount.TabIndex = 21;
            this.lblPos2ContractCount.Text = "# of Contracts Purchased :";
            // 
            // tbPos2ContractCount
            // 
            this.tbPos2ContractCount.Location = new System.Drawing.Point(222, 94);
            this.tbPos2ContractCount.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2ContractCount.Name = "tbPos2ContractCount";
            this.tbPos2ContractCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos2ContractCount.Size = new System.Drawing.Size(68, 24);
            this.tbPos2ContractCount.TabIndex = 18;
            this.tbPos2ContractCount.Text = "1";
            this.tbPos2ContractCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPos2Strike
            // 
            this.tbPos2Strike.Location = new System.Drawing.Point(222, 62);
            this.tbPos2Strike.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2Strike.Name = "tbPos2Strike";
            this.tbPos2Strike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos2Strike.Size = new System.Drawing.Size(68, 24);
            this.tbPos2Strike.TabIndex = 20;
            this.tbPos2Strike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPos2SetPrice
            // 
            this.tbPos2SetPrice.Location = new System.Drawing.Point(222, 30);
            this.tbPos2SetPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos2SetPrice.Name = "tbPos2SetPrice";
            this.tbPos2SetPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos2SetPrice.Size = new System.Drawing.Size(68, 24);
            this.tbPos2SetPrice.TabIndex = 19;
            this.tbPos2SetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPos1
            // 
            this.gbPos1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPos1.BackColor = System.Drawing.Color.Gainsboro;
            this.gbPos1.Controls.Add(this.cbPos1Call);
            this.gbPos1.Controls.Add(this.cbSpread);
            this.gbPos1.Controls.Add(this.cbPos1Buy);
            this.gbPos1.Controls.Add(this.cbPos1Sell);
            this.gbPos1.Controls.Add(this.cbPos1Put);
            this.gbPos1.Controls.Add(this.tbPos1ContractCount);
            this.gbPos1.Controls.Add(this.tbPos1Premium);
            this.gbPos1.Controls.Add(this.tbPos1Strike);
            this.gbPos1.Controls.Add(this.lblPos1ContractCount);
            this.gbPos1.Controls.Add(this.lblPos1SetPrice);
            this.gbPos1.Controls.Add(this.lblPos1Strike);
            this.gbPos1.Location = new System.Drawing.Point(248, 33);
            this.gbPos1.Margin = new System.Windows.Forms.Padding(4);
            this.gbPos1.Name = "gbPos1";
            this.gbPos1.Padding = new System.Windows.Forms.Padding(4);
            this.gbPos1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbPos1.Size = new System.Drawing.Size(301, 130);
            this.gbPos1.TabIndex = 33;
            this.gbPos1.TabStop = false;
            this.gbPos1.Text = "Position 1";
            // 
            // cbPos1Call
            // 
            this.cbPos1Call.AutoSize = true;
            this.cbPos1Call.Location = new System.Drawing.Point(17, 61);
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
            this.cbPos1Buy.Location = new System.Drawing.Point(17, 31);
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
            this.cbPos1Sell.Location = new System.Drawing.Point(77, 30);
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
            this.cbPos1Put.Location = new System.Drawing.Point(77, 61);
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
            this.tbPos1ContractCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos1ContractCount.Size = new System.Drawing.Size(68, 24);
            this.tbPos1ContractCount.TabIndex = 8;
            this.tbPos1ContractCount.Text = "1";
            this.tbPos1ContractCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPos1Premium
            // 
            this.tbPos1Premium.Location = new System.Drawing.Point(223, 28);
            this.tbPos1Premium.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos1Premium.Name = "tbPos1Premium";
            this.tbPos1Premium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos1Premium.Size = new System.Drawing.Size(68, 24);
            this.tbPos1Premium.TabIndex = 9;
            this.tbPos1Premium.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPos1Strike
            // 
            this.tbPos1Strike.Location = new System.Drawing.Point(223, 61);
            this.tbPos1Strike.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos1Strike.Name = "tbPos1Strike";
            this.tbPos1Strike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPos1Strike.Size = new System.Drawing.Size(68, 24);
            this.tbPos1Strike.TabIndex = 10;
            this.tbPos1Strike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPos1ContractCount
            // 
            this.lblPos1ContractCount.AutoSize = true;
            this.lblPos1ContractCount.Location = new System.Drawing.Point(27, 96);
            this.lblPos1ContractCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPos1ContractCount.Name = "lblPos1ContractCount";
            this.lblPos1ContractCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.lblPos1SetPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.lblPos1Strike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPos1Strike.Size = new System.Drawing.Size(54, 18);
            this.lblPos1Strike.TabIndex = 13;
            this.lblPos1Strike.Text = "Strike :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(553, 171);
            this.Controls.Add(this.lbOutPut);
            this.Controls.Add(this.gbPos2);
            this.Controls.Add(this.gbPos1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.ToolStripMenuItem TsCalculate;
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
        private System.Windows.Forms.ToolStripTextBox tbIndexSymblTs;
        private System.Windows.Forms.ToolStripTextBox tbPPSts;
        private System.Windows.Forms.ToolStripMenuItem indexSymbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPSPricePerShareToolStripMenuItem;
    }
}

