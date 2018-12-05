using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbOne.Text = "Buy";
            cbTwo.Text = "Call";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // feeper == fee per option contract
            /* feeper = contract * feeper;
             FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED */
            // Standard TextBox Variables

            double pricePerShare;
            double frontedProfit;
            double priceFlux;
            double ask;
            double bid;
            int contract;
            double contract100;
            double strike;
            double var1;
            double var2;
            double varDivide;
            double varPlus;
            double commission = 6.95; // Made a output location for commision
            double feeper = 0.75;
            double pricemove;
            // Commissions for equity and options trades are $6.95 with a $0.75 fee per options contract

            try
            {
                CallOption call = new CallOption();  // WORK IN PROGRESS  

                if (cbOne.Text == "Buy" && cbTwo.Text == "Call")
                {
                    call.PricePerShare = double.Parse(txtPricePerShare.Text);
                    call.AskPrice = double.Parse(txtAsk.Text) * 100;
                    call.BidPrice = double.Parse(txtBid.Text) * 100;
                    call.NumberOfContracts = int.Parse(txtContract.Text);
                    call.StrikePrice = double.Parse(txtStrike.Text);

                    call.CallBuy();

                    txtProfitPercent.Text = call.PriceMove.ToString("c"); txtProfitPercent.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = call.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPoint.Text = call.ProfitPoint.ToString("c"); txtProfitPoint.BackColor = System.Drawing.Color.LightGreen;
                    txtMaxProfit.Text = call.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.Red;


                }
                else if (cbOne.Text == "Sell" && cbTwo.Text == "Call")
                {

                }
                else if (cbTwo.Text == "Put" && cbOne.Text == "Buy") //  NEEDS WORK,  PUT OPTION CLASS DOESNT WORK
                {
                    PutOption put = new PutOption();

                    put.PricePerShare = double.Parse(txtPricePerShare.Text);
                    // Save the textbox strings in variabes * 100 to reflect actual cost
                    put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    put.BidPrice = double.Parse(txtBid.Text) * 100;
                    put.NumberOfContracts = int.Parse(txtContract.Text);
                    put.StrikePrice = double.Parse(txtStrike.Text);
                    // feeper == fee per option contract
                    //feeper = contract * feeper;
                    // Multiply contract by 100 to represent 100 Stock shares
                    //contract100 = contract * 100;

                    txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = put.UpfrontCost.ToString("c");

                    txtProfitPoint.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPoint.Text = put.ProfitPoint.ToString("c");


                    txtProfitPercent.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPercent.Text = put.PriceMove.ToString("c");

                    txtMaxProfit.BackColor = System.Drawing.Color.Red;
                    txtMaxProfit.Text = put.FrontedProfit.ToString("c");

                }
                else if (cbTwo.Text == "Put" && cbOne.Text == "Sell")
                {
                    

                    pricePerShare = double.Parse(txtPricePerShare.Text);
                    // Save the textbox strings in variabes * 100 to reflect actual cost
                    ask = double.Parse(txtAsk.Text) * 100;
                    bid = double.Parse(txtBid.Text) * 100;
                    contract = int.Parse(txtContract.Text);
                    // feeper == fee per option contract
                    feeper = contract * feeper;
                    // Multiply contract by 100 to represent 100 Stock shares
                    contract100 = contract * 100;
                    strike = double.Parse(txtStrike.Text);

                    // Subtract the larger number from the smallest
                    var1 = ask - bid;
                    // divide the number by 2 to get the average
                    varDivide = (var1 / 2);
                    // add that number to the smallest original number
                    varPlus = varDivide + bid;

                    frontedProfit = varPlus * contract;

                    txtMaxProfit.BackColor = System.Drawing.Color.LightGreen;
                    txtMaxProfit.Text = frontedProfit.ToString("c");
                    // divided down to compute break even
                    frontedProfit = frontedProfit / contract / 100;
                    // break even calculated
                    pricemove = strike - frontedProfit;

                    txtProfitPoint.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPoint.Text = pricemove.ToString("c");
                    // reset this variable
                    frontedProfit = varPlus * contract;

                    contract100 = contract * 100;

                    var2 = strike * contract100;
                    txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = var2.ToString("c");

                    // divided down to compute break even
                    frontedProfit = frontedProfit / contract / 100;

                    

                    txtProfitPercent.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPercent.Text = frontedProfit.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
