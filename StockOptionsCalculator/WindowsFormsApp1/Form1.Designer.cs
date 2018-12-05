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
            this.buttonCalculate = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStrike
            // 
            this.txtStrike.Location = new System.Drawing.Point(141, 163);
            this.txtStrike.Name = "txtStrike";
            this.txtStrike.Size = new System.Drawing.Size(100, 20);
            this.txtStrike.TabIndex = 0;
            this.txtStrike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(258, 119);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(100, 20);
            this.txtBid.TabIndex = 1;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(141, 119);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.Size = new System.Drawing.Size(100, 20);
            this.txtAsk.TabIndex = 2;
            this.txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAsk
            // 
            this.labelAsk.AutoSize = true;
            this.labelAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAsk.Location = new System.Drawing.Point(141, 100);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(34, 16);
            this.labelAsk.TabIndex = 6;
            this.labelAsk.Text = "Ask";
            // 
            // labelBid
            // 
            this.labelBid.AutoSize = true;
            this.labelBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBid.Location = new System.Drawing.Point(258, 100);
            this.labelBid.Name = "labelBid";
            this.labelBid.Size = new System.Drawing.Size(31, 16);
            this.labelBid.TabIndex = 7;
            this.labelBid.Text = "Bid";
            // 
            // labelStrike
            // 
            this.labelStrike.AutoSize = true;
            this.labelStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrike.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStrike.Location = new System.Drawing.Point(140, 147);
            this.labelStrike.Name = "labelStrike";
            this.labelStrike.Size = new System.Drawing.Size(88, 16);
            this.labelStrike.TabIndex = 8;
            this.labelStrike.Text = "Strike Price";
            // 
            // lblUpFrontCosts
            // 
            this.lblUpFrontCosts.AutoSize = true;
            this.lblUpFrontCosts.Location = new System.Drawing.Point(26, 22);
            this.lblUpFrontCosts.Name = "lblUpFrontCosts";
            this.lblUpFrontCosts.Size = new System.Drawing.Size(66, 13);
            this.lblUpFrontCosts.TabIndex = 10;
            this.lblUpFrontCosts.Text = "Upfront Risk";
            // 
            // txtUpfrontCost
            // 
            this.txtUpfrontCost.Location = new System.Drawing.Point(14, 38);
            this.txtUpfrontCost.Name = "txtUpfrontCost";
            this.txtUpfrontCost.Size = new System.Drawing.Size(100, 20);
            this.txtUpfrontCost.TabIndex = 9;
            this.txtUpfrontCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCalculate.Location = new System.Drawing.Point(368, 255);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 11;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // cbOne
            // 
            this.cbOne.FormattingEnabled = true;
            this.cbOne.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.cbOne.Location = new System.Drawing.Point(6, 6);
            this.cbOne.Name = "cbOne";
            this.cbOne.Size = new System.Drawing.Size(121, 21);
            this.cbOne.TabIndex = 12;
            // 
            // cbTwo
            // 
            this.cbTwo.FormattingEnabled = true;
            this.cbTwo.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.cbTwo.Location = new System.Drawing.Point(133, 6);
            this.cbTwo.Name = "cbTwo";
            this.cbTwo.Size = new System.Drawing.Size(121, 21);
            this.cbTwo.TabIndex = 13;
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(258, 163);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 20);
            this.txtContract.TabIndex = 14;
            this.txtContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(255, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Contract (Times 100)";
            // 
            // txtProfitPoint
            // 
            this.txtProfitPoint.Location = new System.Drawing.Point(14, 75);
            this.txtProfitPoint.Name = "txtProfitPoint";
            this.txtProfitPoint.Size = new System.Drawing.Size(100, 20);
            this.txtProfitPoint.TabIndex = 16;
            this.txtProfitPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Break Even Point";
            // 
            // txtPricePerShare
            // 
            this.txtPricePerShare.Location = new System.Drawing.Point(258, 77);
            this.txtPricePerShare.Name = "txtPricePerShare";
            this.txtPricePerShare.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerShare.TabIndex = 18;
            this.txtPricePerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(255, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price per share";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxProfit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProfitPercent);
            this.groupBox1.Controls.Add(this.txtProfitPoint);
            this.groupBox1.Controls.Add(this.txtUpfrontCost);
            this.groupBox1.Controls.Add(this.lblUpFrontCosts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 114);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Upfront Profit";
            // 
            // txtMaxProfit
            // 
            this.txtMaxProfit.Location = new System.Drawing.Point(151, 75);
            this.txtMaxProfit.Name = "txtMaxProfit";
            this.txtMaxProfit.Size = new System.Drawing.Size(100, 20);
            this.txtMaxProfit.TabIndex = 20;
            this.txtMaxProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Amount till Profitability";
            // 
            // txtProfitPercent
            // 
            this.txtProfitPercent.Location = new System.Drawing.Point(151, 38);
            this.txtProfitPercent.Name = "txtProfitPercent";
            this.txtProfitPercent.Size = new System.Drawing.Size(100, 20);
            this.txtProfitPercent.TabIndex = 18;
            this.txtProfitPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 225);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.txtBid);
            this.tabPage1.Controls.Add(this.txtStrike);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbTwo);
            this.tabPage1.Controls.Add(this.txtAsk);
            this.tabPage1.Controls.Add(this.cbOne);
            this.tabPage1.Controls.Add(this.txtPricePerShare);
            this.tabPage1.Controls.Add(this.labelAsk);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelBid);
            this.tabPage1.Controls.Add(this.txtContract);
            this.tabPage1.Controls.Add(this.labelStrike);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Position 1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Position 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(255, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price per share";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Call",
            "Put"});
            this.comboBox1.Location = new System.Drawing.Point(133, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.comboBox2.Location = new System.Drawing.Point(6, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(258, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 30;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(141, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ask";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(255, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Contract (Times 100)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(258, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Bid";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(258, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 28;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(140, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Strike Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(761, 369);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "StockOptions Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.Button buttonCalculate;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxProfit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
    }
}

