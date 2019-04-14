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
            this.lblUpFrontCosts = new System.Windows.Forms.Label();
            this.txtUpfrontCost = new System.Windows.Forms.TextBox();
            this.txtBreakEven = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxProfit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxLoss = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spreadCalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTb_PPS = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_SetPrice = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_Strike = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTb_Contracts = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem_Calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpFrontCosts
            // 
            this.lblUpFrontCosts.AutoSize = true;
            this.lblUpFrontCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpFrontCosts.Location = new System.Drawing.Point(11, 18);
            this.lblUpFrontCosts.Name = "lblUpFrontCosts";
            this.lblUpFrontCosts.Size = new System.Drawing.Size(93, 16);
            this.lblUpFrontCosts.TabIndex = 10;
            this.lblUpFrontCosts.Text = "Upfront Cost";
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
            // txtBreakEven
            // 
            this.txtBreakEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakEven.Location = new System.Drawing.Point(14, 80);
            this.txtBreakEven.Name = "txtBreakEven";
            this.txtBreakEven.Size = new System.Drawing.Size(100, 22);
            this.txtBreakEven.TabIndex = 16;
            this.txtBreakEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaxProfit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaxLoss);
            this.groupBox1.Controls.Add(this.txtBreakEven);
            this.groupBox1.Controls.Add(this.txtUpfrontCost);
            this.groupBox1.Controls.Add(this.lblUpFrontCosts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Upfront Profit";
            // 
            // txtMaxProfit
            // 
            this.txtMaxProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxProfit.Location = new System.Drawing.Point(179, 80);
            this.txtMaxProfit.Name = "txtMaxProfit";
            this.txtMaxProfit.Size = new System.Drawing.Size(100, 22);
            this.txtMaxProfit.TabIndex = 20;
            this.txtMaxProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(197, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max loss";
            // 
            // txtMaxLoss
            // 
            this.txtMaxLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxLoss.Location = new System.Drawing.Point(179, 38);
            this.txtMaxLoss.Name = "txtMaxLoss";
            this.txtMaxLoss.Size = new System.Drawing.Size(100, 22);
            this.txtMaxLoss.TabIndex = 18;
            this.txtMaxLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menuStrip1.Size = new System.Drawing.Size(291, 25);
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
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripComboBox2,
            this.toolStripSeparator2,
            this.toolStripTb_PPS,
            this.toolStripTb_SetPrice,
            this.toolStripTb_Strike,
            this.toolStripTb_Contracts,
            this.toolStripMenuItem_Calculate});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.calculateToolStripMenuItem.Text = "Do Work";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // spreadCalculateToolStripMenuItem
            // 
            this.spreadCalculateToolStripMenuItem.Name = "spreadCalculateToolStripMenuItem";
            this.spreadCalculateToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.spreadCalculateToolStripMenuItem.Text = "&Calculate Spread";
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
            // toolStripMenuItem_Calculate
            // 
            this.toolStripMenuItem_Calculate.Name = "toolStripMenuItem_Calculate";
            this.toolStripMenuItem_Calculate.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem_Calculate.Text = "Do Work";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(291, 140);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "StockOptions Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUpFrontCosts;
        private System.Windows.Forms.TextBox txtUpfrontCost;
        private System.Windows.Forms.TextBox txtBreakEven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxLoss;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxProfit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spreadCalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_PPS;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_SetPrice;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_Strike;
        private System.Windows.Forms.ToolStripTextBox toolStripTb_Contracts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Calculate;
    }
}

