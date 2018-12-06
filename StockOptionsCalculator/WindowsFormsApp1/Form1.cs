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
        Option option = new Option();
        CallOption call = new CallOption();  
        PutOption put = new PutOption();

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
            //THINK ABOUT DAYS TILL EXPIRATION, OR CHANGING THE LABEL TXT BASED ON THE POSITION
            // Made a output location for commision
            // Commissions for equity and options trades are $6.95 with a $0.75 fee per options contract

            try
            {

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
                else if (cbOne.Text == "Buy" && cbTwo.Text == "Put")
                {
                    put.PricePerShare = double.Parse(txtPricePerShare.Text);
                    put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    put.BidPrice = double.Parse(txtBid.Text) * 100;
                    put.NumberOfContracts = int.Parse(txtContract.Text);
                    put.StrikePrice = double.Parse(txtStrike.Text);

                    put.PutBuy();

                    txtUpfrontCost.Text = put.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPoint.Text = put.ProfitPoint.ToString("c"); txtProfitPoint.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPercent.Text = "- " + put.PriceMove.ToString("c"); txtProfitPercent.BackColor = System.Drawing.Color.LightGreen;
                    txtMaxProfit.Text = put.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.Red;

                }
                else if (cbOne.Text == "Sell" && cbTwo.Text == "Put")
                {
                    put.PricePerShare = double.Parse(txtPricePerShare.Text);
                    put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    put.BidPrice = double.Parse(txtBid.Text) * 100;
                    put.NumberOfContracts = int.Parse(txtContract.Text);
                    put.StrikePrice = double.Parse(txtStrike.Text);

                    put.NakedPut();

                    
                    txtMaxProfit.Text = put.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPoint.Text = put.ProfitPoint.ToString("c"); txtProfitPoint.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = put.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtProfitPercent.Text = put.PriceMove.ToString("c"); txtProfitPercent.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
