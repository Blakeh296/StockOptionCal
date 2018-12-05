using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PutOption : Option
    {
        private double _priceMove;
        private double _profitPoint;
        private int _frontedProfit;
        private double _upFrontCost;

        public double PriceMove
        { get { return _priceMove; } set { _priceMove = value; } }

        public double ProfitPoint
        { get { return _profitPoint; } set { _profitPoint = value; } }

        public double UpfrontCost
        { get { return _upFrontCost; } set { _upFrontCost = value; } }

        public int FrontedProfit
        { get { return _frontedProfit; } set { _frontedProfit = 0; } }

        public PutOption()
        {         }

        public void PutBuy()
        {
            double costDivide = (AskPrice - BidPrice) / 2;

            double var1 = costDivide + BidPrice;
            double var2 = StrikePrice - (var1 / 100);

            _upFrontCost = (costDivide + BidPrice) * NumberOfContracts ;
            _profitPoint = var2;
            _priceMove = PricePerShare - var2;
            _frontedProfit = 0;
        }
    }
}
