using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PutOption : Option
    {
        private double _priceMove;
        private double _profitPoint;
        private double _frontedProfit;
        private double _upFrontCost;

        public double PriceMove
        { get { return _priceMove; } set { _priceMove = value; } }

        public double ProfitPoint
        { get { return _profitPoint; } set { _profitPoint = value; } }

        public double UpfrontCost
        { get { return _upFrontCost; } set { _upFrontCost = value; } }

        public double FrontedProfit
        { get { return _frontedProfit; } set { _frontedProfit = value; } }

        public PutOption()
        {        }

        public void PutBuy()
        {
            double contractCost = (((AskPrice - BidPrice) / 2) + BidPrice);

            //upfront cost is essentially risk
            _upFrontCost = contractCost * NumberOfContracts ;
            _profitPoint = PricePerShare - (contractCost / 100);
            _priceMove = (contractCost / 100);
            _frontedProfit = 0;
        }

        public void NakedPut()
        {
            double contractCost = (((AskPrice - BidPrice) / 2) +BidPrice);
           
            //upfront cost is essentially risk
            _upFrontCost = ((PricePerShare * NumberOfContracts) * 100);
            _frontedProfit = contractCost * NumberOfContracts;
            _profitPoint = PricePerShare + (contractCost / 100);
            _priceMove = ProfitPoint - PricePerShare;
        }
    }
}
