using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PosCal : Option
    {
        private double _breakEven;
        private double _profitPotential;
        private double _maxLoss;
        private double _frontedProfit;
        private double _upFrontCost;
        private double _priceMove;
        private double _intrinsic;
        private double _time;
        private bool _itm;

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

        public double Intrinsic
        { get { return _intrinsic; } set { _intrinsic = value; } }

        public double Time
        { get { return _time; } set { _time = value; } }

        public double PriceMove
        { get { return _priceMove; } set { _priceMove = value; } }

        public bool ITM
        { get { return _itm; } set { _itm = value; } }

        public PosCal()
        { }

        public void BuyCall()
        {
            _upFrontCost = (Premium * 100) * NumberOfContracts;
            _breakEven = StrikePrice + Premium;
            _profitPotential = (BreakEven * 100) * NumberOfContracts;
            _maxLoss = UpfrontCost;
            _priceMove = (BreakEven - PricePerShare);

            if (StrikePrice < PricePerShare)
            {
                _itm = true; _intrinsic = (PricePerShare - StrikePrice);
                _time = UpfrontCost - Intrinsic;
            }
            else
            { _itm = false; _intrinsic = 0; _time = 0; }
        }
        public void BuyPut()
        {
            //double contractCost = (((AskPrice - BidPrice) / 2) + BidPrice);

            //upfront cost is essentially risk
            _upFrontCost = (Premium * 100) * NumberOfContracts;
            _breakEven = StrikePrice - Premium;
            _profitPotential = (StrikePrice * 100) - UpfrontCost;
            _maxLoss = UpfrontCost;
            _priceMove = -1 * (PricePerShare - BreakEven);

            if (StrikePrice > PricePerShare)
            {
                _itm = true; _intrinsic = StrikePrice - PricePerShare;
                _time = UpfrontCost - Intrinsic;
            }
            else
            { _itm = false; _intrinsic = 0; _time = 0; }
        }

        public void SellPut()
        {
            //upfront cost is essentially risk
            _frontedProfit = Premium * 100;
            _upFrontCost = (StrikePrice * 100) - FrontedProfit;
            _breakEven = UpfrontCost/100;
            _maxLoss = UpfrontCost;
        }
    }
}
