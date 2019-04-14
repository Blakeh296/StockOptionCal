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
           /* cbOne.Text = "Buy";
            cbTwo.Text = "Call";

            checkBoxSpread.Checked = false;
            spreadCalculateToolStripMenuItem.Visible = false; */
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
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
                   /* call.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //call.AskPrice = double.Parse(txtAsk.Text) * 100;
                    //call.BidPrice = double.Parse(txtBid.Text) * 100;
                    call.NumberOfContracts = int.Parse(txtContract.Text);
                    call.StrikePrice = double.Parse(txtStrike.Text);

                    call.CallBuy();

                    txtMaxLoss.Text = call.PriceMove.ToString("c"); txtMaxLoss.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = call.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightGreen;
                    txtBreakEven.Text = call.ProfitPoint.ToString("c"); txtBreakEven.BackColor = System.Drawing.Color.LightGreen;
                    txtMaxProfit.Text = call.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.Red;
               */
                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Call")
                {

                }
                else if (toolStripComboBox1.Text == "Buy" && toolStripComboBox2.Text == "Put")
                {
                    put.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    put.SetPrice = double.Parse(toolStripTb_SetPrice.Text);
                    put.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    put.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    put.PutBuy();

                    txtUpfrontCost.Text = put.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.Yellow;
                    txtMaxLoss.Text = "- " + put.MaxLoss.ToString("c"); txtMaxLoss.BackColor = System.Drawing.Color.Yellow;
                    txtBreakEven.Text = put.BreakEven.ToString("c"); txtBreakEven.BackColor = System.Drawing.Color.LightGreen; 
                    label6.Text = "Profit on Exp.";
                    txtMaxProfit.Text = put.ProfitPotential.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.LightGreen;

                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Put")
                {
                    put.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    put.SetPrice = double.Parse(toolStripTb_SetPrice.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    put.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    put.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    put.NakedPut();

                    txtMaxProfit.Text = put.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.LightGreen;
                    txtBreakEven.Text = put.BreakEven.ToString("c"); txtBreakEven.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = put.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightBlue;
                    txtMaxLoss.Text = put.MaxLoss.ToString("c"); txtMaxLoss.BackColor = System.Drawing.Color.LightBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
