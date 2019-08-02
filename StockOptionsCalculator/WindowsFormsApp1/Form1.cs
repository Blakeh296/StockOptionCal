﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Option option = new Option();
        PosCal posCal = new PosCal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* cbOne.Text = "Buy";
            cbTwo.Text = "Call";

            checkBoxSpread.Checked = false;
            spreadCalculateToolStripMenuItem.Visible = false; */
        }

        private void TSMenuItem_QuickCalculate_Click(object sender, EventArgs e)
        {
            // feeper == fee per option contract
            /* feeper = contract * feeper;
             FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED */
            // Standard TextBox Variables
            //THINK ABOUT DAYS TILL EXPIRATION, OR CHANGING THE LABEL TXT BASED ON THE POSITION
            // Made a output location for commision
            // Commissions for equity and options trades are $6.95 with a $0.75 fee per options contract

            try
            {

                if (toolStripComboBox1.Text == "Buy" && toolStripComboBox2.Text == "Call")
                {
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100; //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.Premium = double.Parse(toolStripTb_SetPrice.Text);
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.BuyCall();

                    lbOutPut.Items.Clear();
                    lbOutPut.Items.Add("Upfront Cost: " + posCal.UpfrontCost.ToString("c"));
                    lbOutPut.Items.Add("B/E Price: " + posCal.BreakEven.ToString("c"));

                    if (posCal.ITM == false)
                    {
                        lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                        lbOutPut.Items.Add("Price Move: " + posCal.PriceMove.ToString("c"));
                    }
                    else
                    {
                        lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                        lbOutPut.Items.Add("Time Value : " + posCal.Time.ToString("c"));
                        lbOutPut.Items.Add("Intrinsic Value: " + posCal.Intrinsic.ToString("c"));
                    }

                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Call")
                {

                }
                else if (toolStripComboBox1.Text == "Buy" && toolStripComboBox2.Text == "Put")
                {
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100; //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.Premium = double.Parse(toolStripTb_SetPrice.Text);
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.BuyPut();

                    lbOutPut.Items.Clear();
                    lbOutPut.Items.Add("Upfront Cost: " + posCal.UpfrontCost.ToString("c"));
                    lbOutPut.Items.Add("Break Even: " + posCal.BreakEven.ToString("c"));

                    if (posCal.ITM == false)
                    {
                        lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                        lbOutPut.Items.Add("Price Move: " + posCal.PriceMove.ToString("c"));
                    }
                    else
                    {
                        lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                        lbOutPut.Items.Add("Intrinsic Value: " + posCal.Intrinsic.ToString("c"));
                        lbOutPut.Items.Add("Time Value" + posCal.Time.ToString("c"));
                    }
                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Put")
                {
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    posCal.Premium = double.Parse(toolStripTb_SetPrice.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.SellPut();

                    lbOutPut.Items.Add("Immediate (ROI) Return of Investment: " +posCal.FrontedProfit.ToString("c"));
                    lbOutPut.Items.Add("Price (BE) Break Even: "+posCal.BreakEven.ToString("c"));
                    lbOutPut.Items.Add("Required Capital: "+ posCal.UpfrontCost.ToString("c"));
                    lbOutPut.Items.Add("Buy Back Price: "+ posCal.MaxLoss.ToString("c"));
                    //txtMaxLoss.Text = posCal.MaxLoss.ToString("c"); txtMaxLoss.BackColor = System.Drawing.Color.LightBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbOutPut_DoubleClick(object sender, EventArgs e)
        {
            lbOutPut.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbOutPut_MouseHover(object sender, EventArgs e)
        {
            
        }

        /* private void checkBoxSpread_CheckedChanged(object sender, EventArgs e)
         {
             if (checkBoxSpread.Checked == true)
                 spreadCalculateToolStripMenuItem.Visible = true;
             else if (checkBoxSpread.Checked == false)
                 spreadCalculateToolStripMenuItem.Visible = false;
         }*/
    }
}
