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
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100; //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.SetPrice = double.Parse(toolStripTb_SetPrice.Text);
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.BuyCall();

                    txtUpfrontCost.Text = posCal.UpfrontCost.ToString("c"); 
                    txtBreakEven.Text = posCal.BreakEven.ToString("c"); 

                    if (posCal.ITM == false)
                    {
                        label4.Text = "Max Potential"; txtMaxLoss.Text = posCal.ProfitPotential.ToString("c");
                        label6.Text = "Price Move"; txtMaxProfit.Text = posCal.PriceMove.ToString("c");
                    }
                    else
                    {
                        label4.Text = "Time Value"; txtMaxLoss.Text = "- " + posCal.Time.ToString("c"); 
                        label6.Text = "Intrinsic Value"; txtMaxProfit.Text = posCal.Intrinsic.ToString("c");
                    }
                    
                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Call")
                {

                }
                else if (toolStripComboBox1.Text == "Buy" && toolStripComboBox2.Text == "Put")
                {
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100; //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.SetPrice = double.Parse(toolStripTb_SetPrice.Text);
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.BuyPut();

                    txtUpfrontCost.Text = posCal.UpfrontCost.ToString("c");
                    txtBreakEven.Text = posCal.BreakEven.ToString("c");

                    if (posCal.ITM == false)
                    { label4.Text = "Max Potential"; txtMaxLoss.Text = posCal.ProfitPotential.ToString("c");
                        label6.Text = "Price Move"; txtMaxProfit.Text = posCal.PriceMove.ToString("c");
                    }
                    else { label4.Text = "Intrinsic Value"; txtMaxLoss.Text = "- " + posCal.Intrinsic.ToString("c");
                        label6.Text = "Time Value"; txtMaxProfit.Text = posCal.Time.ToString("c");
                    }
                }
                else if (toolStripComboBox1.Text == "Sell" && toolStripComboBox2.Text == "Put")
                {
                    posCal.PricePerShare = double.Parse(toolStripTb_PPS.Text);
                    posCal.SetPrice = double.Parse(toolStripTb_SetPrice.Text);
                    //put.AskPrice = double.Parse(txtAsk.Text) * 100;
                    //put.BidPrice = double.Parse(txtBid.Text) * 100;
                    posCal.NumberOfContracts = int.Parse(toolStripTb_Contracts.Text);
                    posCal.StrikePrice = double.Parse(toolStripTb_Strike.Text);

                    posCal.SellPut();

                    txtMaxProfit.Text = posCal.FrontedProfit.ToString("c"); txtMaxProfit.BackColor = System.Drawing.Color.LightGreen;
                    txtBreakEven.Text = posCal.BreakEven.ToString("c"); txtBreakEven.BackColor = System.Drawing.Color.LightGreen;
                    txtUpfrontCost.Text = posCal.UpfrontCost.ToString("c"); txtUpfrontCost.BackColor = System.Drawing.Color.LightBlue;
                    txtMaxLoss.Text = posCal.MaxLoss.ToString("c"); txtMaxLoss.BackColor = System.Drawing.Color.LightBlue;
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
