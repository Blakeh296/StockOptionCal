using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PutOption : Option
    {
        private double _breakEven;
        private double _profitPotential;
        private double _maxLoss;
        private double _frontedProfit;
        private double _upFrontCost;

        public double BreakEven
        { get { return _breakEven; } set { _breakEven = value; } }

        public double ProfitPotential
        { get { return _profitPotential; } set { _profitPotential = value; } }

        public double UpfrontCost
        { get { return _upFrontCost; } set { _upFrontCost = value; } }

        public double FrontedProfit
        { get { return _frontedProfit; } set { _frontedProfit = value; } }

        public double MaxLoss
        { get { return _maxLoss; } set { _maxLoss = value; } }

        public PutOption()
        {        }

        public void PutBuy()
        {
            //double contractCost = (((AskPrice - BidPrice) / 2) + BidPrice);

            //upfront cost is essentially risk
            _upFrontCost = SetPrice * 100;
            _breakEven = StrikePrice - SetPrice;
            _profitPotential = BreakEven * 100;
            _maxLoss = UpfrontCost;
        }

        public void NakedPut()
        {
            //upfront cost is essentially risk
            _frontedProfit = SetPrice * 100;
            _upFrontCost = (StrikePrice * 100) - FrontedProfit;
            _breakEven = UpfrontCost/100;
            _maxLoss = BreakEven * 100;
        }
    }
}
