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
        { gbPos2.Visible = false; gbIV.Visible = false; lbOutPut.Items.Add("***DBL Click To Clear Work***"); }

        private void TsCalculate_Click(object sender, EventArgs e)
        {
            // feeper == fee per option contract
            /* feeper = contract * feeper;
             FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED */
            //THINK ABOUT DAYS TILL EXPIRATION, OR CHANGING THE LABEL TXT BASED ON THE POSITION
            // Commissions for equity and options trades are $6.95 with a $0.75 fee per options contract
            try
            {
                if (cbIV.Checked == true)
                {

                    posCal.PricePerShare = double.Parse(tbPPSts.Text);
                    posCal.IV = double.Parse(tbIV.Text);
                    posCal.BusinessDays = double.Parse(tbIVdays.Text);
                    posCal.IVCal();
                    lbOutPut.Items.Add("IV Daily for "+tbIndexSymblTs.Text+ " : " + Math.Round(posCal.IvDailyResult, 2) + "IV Custom :" + Math.Round(posCal.IvCustomResult,2));
                }

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
                                    spreadCal.PricePerShare = double.Parse(tbPPSts.Text);
                                    spreadCal.Premium = double.Parse(tbPos1Premium.Text);
                                    spreadCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                                    spreadCal.StrikePrice = double.Parse(tbPos1Strike.Text);
                                    spreadCal.Premium2 = double.Parse(tbPos2SetPrice.Text);
                                    spreadCal.Strike2 = double.Parse(tbPos2Strike.Text);
                                    spreadCal.CountofContracts2 = int.Parse(tbPos2ContractCount.Text);

                                    spreadCal.VerticalCallSpread();
                                    double belblout = spreadCal.Strike100 + spreadCal.UpfrontCost; /*put this somewhere else*/

                                    lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                    lbOutPut.Items.Add("Index: " + tbIndexSymblTs.Text + " - " + spreadCal.PricePerShare.ToString("c") + " PPS");
                                    lbOutPut.Items.Add("Buy " + spreadCal.NumberOfContracts + " - " + spreadCal.StrikePrice + " Call @ " + spreadCal.Premium + " to Open");
                                    lbOutPut.Items.Add("Sell " + spreadCal.CountofContracts2 + " - " + spreadCal.Strike2 + " Call @ " + spreadCal.Premium2 + " to Open");
                                    lbOutPut.Items.Add(" ");
                                    lbOutPut.Items.Add("Upfront cost: " + spreadCal.UpfrontCost.ToString("c"));
                                    lbOutPut.Items.Add("----- " + spreadCal.Prem100.ToString("c") + " - " + spreadCal.Prem200.ToString("c") + " = " + spreadCal.UpfrontCost);
                                    lbOutPut.Items.Add(" ");
                                    lbOutPut.Items.Add("Capital Required: " + spreadCal.CapitalRequired.ToString("c"));
                                    lbOutPut.Items.Add("----- " + spreadCal.Strike200.ToString("c") + " - " + spreadCal.UpfrontCost.ToString("c") + " = " + spreadCal.CapitalRequired);
                                    lbOutPut.Items.Add(" ");
                                    lbOutPut.Items.Add("Potential profit: " + spreadCal.ProfitPotential.ToString("c"));
                                    lbOutPut.Items.Add("----- " + spreadCal.Strike200.ToString("c") + " - " + spreadCal.BE100.ToString("c") + " ( " + spreadCal.BreakEven + " x 100 ) = " + spreadCal.ProfitPotential);
                                    lbOutPut.Items.Add(" ");
                                    lbOutPut.Items.Add("B/E (Break Even): " + spreadCal.BreakEven.ToString("c"));
                                    lbOutPut.Items.Add("----- " + spreadCal.Strike100.ToString("c") + " + " + spreadCal.UpfrontCost.ToString("c") + " = " + belblout.ToString("c") + "/100" + " = " + spreadCal.BreakEven);
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
                            posCal.PricePerShare = double.Parse(tbPPSts.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.BuyCall();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                            lbOutPut.Items.Add("Index: " + tbIndexSymblTs.Text + " - " + posCal.PricePerShare.ToString("c") + " PPS ");
                            lbOutPut.Items.Add( " Buy " + posCal.NumberOfContracts.ToString() +" - " + posCal.StrikePrice.ToString() + " Call @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Upfront Cost & Max Loss: " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add("----- 'Premium' " + posCal.Premium.ToString("c") + " x '#ofContracts' " + posCal.NumberOfContracts + " x 100 = " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("B/E Price: " + posCal.BreakEven.ToString("c"));
                            lbOutPut.Items.Add("----- 'Strike' " + posCal.StrikePrice.ToString("c") + " + 'Premium' " + posCal.Premium.ToString("c") + " = " + posCal.BreakEven.ToString("c"));
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Price Move till B/E: " + posCal.PriceMove.ToString("c"));
                            lbOutPut.Items.Add("----- 'B/E' " + posCal.BreakEven.ToString("c") + " - 'PPS' " + posCal.PricePerShare.ToString("c") + " = " + posCal.PriceMove.ToString("c"));
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Profit Prediction (on Close):  " + posCal.ProfitPotential.ToString("c"));
                            lbOutPut.Items.Add("----- (( 'PPS' " + posCal.PricePerShare.ToString("c") + " - 'Strike' " + posCal.StrikePrice.ToString("c") + ") - 'Premium' " + posCal.Premium.ToString("c") + ") * 100 = " + posCal.ProfitPotential.ToString("c"));
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Potential Profit: Unlimited 'The sky's the Limit'");
                            lbOutPut.Items.Add(" ");

                            if (posCal.ITM == true)
                            {
                                lbOutPut.Items.Add("Intrinsic Value: " + posCal.Intrinsic.ToString("c"));
                                lbOutPut.Items.Add("----- 'PPS' " + posCal.PricePerShare.ToString("c") + " - 'Strike' " + posCal.StrikePrice.ToString("c") + " = " + posCal.Intrinsic.ToString("c"));
                                lbOutPut.Items.Add(" ");
                                lbOutPut.Items.Add("Time Value : " + posCal.Time.ToString("c"));
                                lbOutPut.Items.Add("----- 'UpfrontCost' " + posCal.UpfrontCost.ToString("c") + " - 'Intrinsic' " + posCal.Intrinsic.ToString("c") + " = " + posCal.Time.ToString("c"));
                            }
                        }
                        /*IF PUT AND NOT CALL*/
                        else if (cbPos1Put.Checked == true && cbPos1Call.Checked != true)
                        {
                            posCal.PricePerShare = double.Parse(tbPPSts.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.BuyPut();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                            lbOutPut.Items.Add("Index: " + tbIndexSymblTs.Text + " - " + posCal.PricePerShare.ToString("c") + " PPS ");
                            lbOutPut.Items.Add("Buy " + posCal.NumberOfContracts.ToString() + " - " + posCal.StrikePrice.ToString("c") + " put @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Upfront Cost: " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add("----- 'Premium' " + posCal.Premium.ToString("c") + " x 100 = " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("B/E 'Break Even': " + posCal.BreakEven.ToString("c"));
                            lbOutPut.Items.Add("----- 'Strike' " + posCal.StrikePrice.ToString("c") + " - 'Premium' " + posCal.Premium.ToString("c") + " = " + posCal.BreakEven);
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Potential Profit (On Close): " + posCal.ProfitPotential.ToString("c"));
                            lbOutPut.Items.Add("----- (( 'Strike' " + posCal.StrikePrice.ToString("c") + " - 'PPS' " + posCal.PricePerShare.ToString("c") + " ) - " + posCal.Premium.ToString("c") + ") * 100 = " + posCal.ProfitPotential.ToString("c"));
                            /*FIX THIS ^*/
                            lbOutPut.Items.Add("");
                            lbOutPut.Items.Add("Price Move until B/E: " + posCal.PriceMove.ToString("c"));
                            lbOutPut.Items.Add("----- -1 x ( 'PPS' " + posCal.PricePerShare.ToString("c") + " - 'B/E' " + posCal.BreakEven.ToString("c") +") = " + posCal.PriceMove.ToString("c"));
                            if (posCal.ITM == true)
                            {
                                lbOutPut.Items.Add("");
                                lbOutPut.Items.Add("Intrinsic Value: " + posCal.Intrinsic.ToString("c"));
                                lbOutPut.Items.Add("----- 'Strike' " + posCal.StrikePrice.ToString("c") + " - 'PPS' " + posCal.PricePerShare.ToString("c") + " = " + posCal.Intrinsic.ToString("c"));
                                lbOutPut.Items.Add("");
                                lbOutPut.Items.Add("Time Value" + posCal.Time.ToString("c"));
                                lbOutPut.Items.Add("----- 'UpfrontCost' " + posCal.UpfrontCost.ToString("c") + " - 'intrinsic' " + posCal.Intrinsic.ToString("c") + " = " + posCal.Time.ToString("c"));
                            }
                        }
                    }
                    /*IF SELL AND NOT BUY*/
                    else if (cbPos1Sell.Checked == true && cbPos1Buy.Checked != true)
                    {
                        /*put not call*/
                        if (cbPos1Put.Checked == true && cbPos1Call.Checked != true)
                        {
                            posCal.PricePerShare = double.Parse(tbPPSts.Text);
                            posCal.Premium = double.Parse(tbPos1Premium.Text);
                            //put.AskPrice = double.Parse(txtAsk.Text) * 100;//put.BidPrice = double.Parse(txtBid.Text) * 100;
                            posCal.NumberOfContracts = int.Parse(tbPos1ContractCount.Text);
                            posCal.StrikePrice = double.Parse(tbPos1Strike.Text);

                            posCal.SellPut();

                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                            lbOutPut.Items.Add("Index: "+tbIndexSymblTs.Text + " - " + posCal.PricePerShare.ToString("c") + " Per Share");
                            lbOutPut.Items.Add(" Sell " + posCal.NumberOfContracts.ToString() + " - " + posCal.StrikePrice.ToString() + " Put @ " + posCal.Premium.ToString("c") + " to open");
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Immediate (ROI) Return on Investment: " + posCal.FrontedProfit.ToString("c"));
                            lbOutPut.Items.Add("----- ('Premium' " + posCal.Premium.ToString("c") + " x 100) x '#ofContracts' " + posCal.NumberOfContracts + " = " + posCal.FrontedProfit.ToString());
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Price (BE) Break Even: " + posCal.BreakEven.ToString("c"));
                            lbOutPut.Items.Add("----- 'Strike' " + posCal.StrikePrice.ToString("c") + " - 'Premium' " + posCal.Premium + " = " + posCal.BreakEven.ToString());
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Required Capital: " + posCal.UpfrontCost.ToString("c"));
                            lbOutPut.Items.Add("----- (('Strike'" + posCal.StrikePrice.ToString("c") + " x 100) - 'immROI'" + posCal.FrontedProfit.ToString("c") + ") x '#ofContracts' " + posCal.NumberOfContracts.ToString() + " = " + posCal.UpfrontCost.ToString());
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("% ROI: " + posCal.ROI.ToString(".00") + "%");
                            lbOutPut.Items.Add("----- ('ImmROI' " + posCal.FrontedProfit.ToString("c") + " / " + posCal.UpfrontCost.ToString("c") + ") x 100 = " + posCal.ROI.ToString());
                            lbOutPut.Items.Add(" ");
                            lbOutPut.Items.Add("Rule of 72's: " + posCal.RO72.ToString(".00") + " years");
                            lbOutPut.Items.Add("----- 72 / ('Premium' " + posCal.Premium.ToString("c") + " / 'Strike' " + posCal.StrikePrice.ToString("c") + " ) x 100 = " + posCal.RO72.ToString(".00"));
                        }

                        if(cbPos1Call.Checked == true && cbPos1Put.Checked != true)
                        {
                            lbOutPut.Items.Add("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                            lbOutPut.Items.Add("The Sale of naked calls is not prohibited due to being extra risky, try create a spread instead ");
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

       /* private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { Application.Exit(); } NO NEED FOR THIS ATM */

        /*private void sellPutToolStripMenuItem_Click(object sender, EventArgs e)
        {   tspForm.ShowDialog();   }

        private void buyPutToolStripMenuItem_Click(object sender, EventArgs e)
        {   tbpForm.ShowDialog();   }

        private void buyCallToolStripMenuItem_Click(object sender, EventArgs e)
        {   tbcForm.ShowDialog();   }*/


        private void cbSpread_CheckedChanged(object sender, EventArgs e)
        { if (cbSpread.Checked == true) {gbPos2.Visible = true; this.Height = 356; this.Width = 716; } else {gbPos2.Visible = false; this.Height = 215; this.Width = 569;} }

        private void cbIV_CheckedChanged(object sender, EventArgs e)
        { if (cbIV.Checked == true) { gbPos1.Visible = false; gbIV.Visible = true; } else { gbIV.Visible = false; gbPos1.Visible = true; } }
        

        private void lbOutPut_DoubleClick(object sender, EventArgs e)
        { lbOutPut.Items.Clear(); lbOutPut.Items.Add("***DBL CLICK To Clear Work***"); }
    }
}
