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
        SpreadCal spreadCal = new SpreadCal();

        TrainingSellPuts tspForm = new TrainingSellPuts();
        TrainingBuyPuts tbpForm = new TrainingBuyPuts();
        TrainingBuyCalls tbcForm = new TrainingBuyCalls();

        public Form1()
        { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        { gbPos2.Visible = false; }

        private void TsCalculate_Click(object sender, EventArgs e)
        {
            // feeper == fee per option contract
            /* feeper = contract * feeper;
             FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED */
            //THINK ABOUT DAYS TILL EXPIRATION, OR CHANGING THE LABEL TXT BASED ON THE POSITION
            // Commissions for equity and options trades are $6.95 with a $0.75 fee per options contract
            try
            {
                if (cbSpread.Checked == true)
                {
                    if (cbPos1Buy.Checked == true && cbPos1Sell.Checked != true)
                    { spreadCal.Option1BuySell = true; }
                    else if (cbPos1Sell.Checked == true && cbPos1Buy.Checked != true)
                    { spreadCal.Option1BuySell = false; }

                    if (cbPos2Buy.Checked == true && cbPos2Sell.Checked != true)
                    { spreadCal.Option2BuySell = true; }
                    else if (cbPos2Sell.Checked == true && cbPos2Buy.Checked != true)
                    { spreadCal.Option2BuySell = false; }

                    bool optn1buysell = spreadCal.Option1BuySell;
                    bool optn2buysell = spreadCal.Option2BuySell;

                    /*Vert Call Spread*/
                    if (cbPos1Buy.Checked == true && cbPos1Sell.Checked != true)
                    {
                        if (cbPos2Sell.Checked == true && cbPos2Buy.Checked != true)
                        {
                            if (cbPos1Call.Checked == true && cbPos1Put.Checked != true)
                            {
                                if (cbPos2Call.Checked == true && cbPos2Put.Checked != true)
                                {
                                    spreadCal.PricePerShare = double.Parse(tbPPS.Text);
                                    spreadCal.Premium = double.Parse(tbPos1Premium.Text);
                                    spreadCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                                    spreadCal.StrikePrice = double.Parse(tbPos1Strike.Text);
                                    spreadCal.Premium2 = double.Parse(tbPos2SetPrice.Text);
                                    spreadCal.Strike2 = double.Parse(tbPos2Strike.Text);
                                    spreadCal.CountofContracts2 = int.Parse(tbPos2ContractCount.Text);

                                    spreadCal.VerticalCallSpread();
                                    double belblout = spreadCal.Strike100 + spreadCal.UpfrontCost; /*put this somewhere else*/

                                    lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                    lbOutPut.Items.Add(tbIndexSymbl.Text + " - " + spreadCal.PricePerShare + " PPS (Price Per Share)");
                                    lbOutPut.Items.Add("Buy " + spreadCal.NumberOfContracts + " - " + spreadCal.StrikePrice + " Call @ " + spreadCal.Premium + " to Open");
                                    lbOutPut.Items.Add("Sell " + spreadCal.CountofContracts2 + " - " + spreadCal.Strike2 + " Call @ " + spreadCal.Premium2 + " to Open");
                                    lbOutPut.Items.Add(" ");
                                    lbOutPut.Items.Add("----- " + spreadCal.Prem100 + " - " + spreadCal.Prem200);
                                    lbOutPut.Items.Add("Upfront cost: " + spreadCal.UpfrontCost);
                                    lbOutPut.Items.Add("----- " + spreadCal.UpfrontCost + " + " + spreadCal.Strike100 + " = " + spreadCal.Strike200 + " - " + spreadCal.BE100);
                                    lbOutPut.Items.Add("Potential profit: " + spreadCal.ProfitPotential);
                                    lbOutPut.Items.Add("----- " + spreadCal.Strike100 + " + " + spreadCal.UpfrontCost + " = " + belblout + "/100");
                                    lbOutPut.Items.Add("B/E (Break Even): " + spreadCal.BreakEven);
                                }
                            }
                        }      
                    }
                    /*codehere*/
                }
                else if (cbSpread.Checked != true) /*Think about RADIO BUTTIONS instead of CHECK BOXES*/
                {
                    /*IF BUY AND NOT SELL*/
                    if (cbPos1Buy.Checked == true && cbPos1Sell.Checked != true)
                    {
                        /*IF CALL AND NOT PUT*/
                        if (cbPos1Call.Checked == true && cbPos1Put.Checked != true)
                        {
                            posCal.PricePerShare = double.Parse(tbPPS.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.BuyCall();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                            lbOutPut.Items.Add(tbIndexSymbl.Text + " - " + posCal.PricePerShare.ToString("c") + " Price Per Share");
                            lbOutPut.Items.Add( " Buy " + posCal.NumberOfContracts.ToString() +" - " + posCal.StrikePrice.ToString() + " Call @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Upfront Cost & Max Loss: " + posCal.UpfrontCost.ToString("c"));

                            if (posCal.ITM == false)
                            {
                                lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                                lbOutPut.Items.Add("B/E Price: " + posCal.BreakEven.ToString("c"));
                                lbOutPut.Items.Add("Price Move: " + posCal.PriceMove.ToString("c"));
                            }
                            else
                            {
                                lbOutPut.Items.Add("MAX Potential Profit: " + posCal.ProfitPotential.ToString("c"));
                                lbOutPut.Items.Add("B/E Price: " + posCal.BreakEven.ToString("c"));
                                lbOutPut.Items.Add("Time Value : " + posCal.Time.ToString("c"));
                                lbOutPut.Items.Add("Intrinsic Value: " + posCal.Intrinsic.ToString("c"));
                                lbOutPut.Items.Add("Price Move: " + posCal.PriceMove.ToString("c"));
                            }
                        }
                        /*IF PUT AND NOT CALL*/
                        else if (cbPos1Put.Checked == true && cbPos1Call.Checked != true)
                        {
                            posCal.PricePerShare = double.Parse(tbPPS.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.BuyPut();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                            lbOutPut.Items.Add(tbIndexSymbl.Text + " - " + posCal.PricePerShare.ToString("c") + " Price Per Share ");
                            lbOutPut.Items.Add(" Buy " + posCal.NumberOfContracts.ToString() +
                        " - " + posCal.StrikePrice.ToString() + " put @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
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
                    }
                    /*IF SELL AND NOT BUY*/
                    else if (cbPos1Sell.Checked == true && cbPos1Buy.Checked != true)
                    {
                        /*put not call*/
                        if (cbPos1Put.Checked == true && cbPos1Call.Checked != true)
                        {
                            posCal.PricePerShare = double.Parse(tbPPS.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            //put.AskPrice = double.Parse(txtAsk.Text) * 100;//put.BidPrice = double.Parse(txtBid.Text) * 100;
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.SellPut();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                            lbOutPut.Items.Add(tbIndexSymbl.Text + " - " + posCal.PricePerShare.ToString("c") + " Price Per Share");
                            lbOutPut.Items.Add(" Sell " + posCal.NumberOfContracts.ToString() +
                        " - " + posCal.StrikePrice.ToString() + " Put @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Immediate (ROI) Return of Investment: " + posCal.FrontedProfit.ToString("c"));
                            lbOutPut.Items.Add("Price (BE) Break Even: " + posCal.BreakEven.ToString("c"));
                            lbOutPut.Items.Add("Required Capital: " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add("Buy Back Price: " + posCal.MaxLoss.ToString("c"));
                        }

                        /* CAN ADD ADDITION STATEMENT TO DENY THE SALE OF NAKED CALLS & TELL USER TO TRY A SPREAD INSTEAD */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void lbOutPut_SelectedIndexChanged(object sender, EventArgs e)
        { lbHelp.Text = lbOutPut.Text.ToString(); }

        private void lbHelp_DoubleClick(object sender, EventArgs e)
        { lbOutPut.Items.Clear(); lbHelp.Text = "*HINTSingle Click to read txt. DBL Click to clear results."; }

        private void sellPutToolStripMenuItem_Click(object sender, EventArgs e)
        {   tspForm.ShowDialog();   }

        private void buyPutToolStripMenuItem_Click(object sender, EventArgs e)
        {   tbpForm.ShowDialog();   }

        private void buyCallToolStripMenuItem_Click(object sender, EventArgs e)
        {   tbcForm.ShowDialog();   }


        private void cbSpread_CheckedChanged(object sender, EventArgs e)
        { if (cbSpread.Checked == true) {gbPos2.Visible = true;} else {gbPos2.Visible = false;} }

        
    }
}
