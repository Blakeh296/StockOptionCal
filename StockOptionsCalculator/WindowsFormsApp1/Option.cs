using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

   /* FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED // AKA BROKAGE COMMISSION */

    public class Option
    {
        private double _setPrice;
        private double _pps;
        //private double _ask;
       // private double _bid;
        private double _strike;
        private double _countofcontracts;

        public double PricePerShare
        { get { return _pps; } set { _pps = value; } }

        public double SetPrice
        { get { return _setPrice; } set { _setPrice = value; } }

        //public double AskPrice
        //{ get { return _ask; } set { _ask = value; } }

        //public double BidPrice
        //{ get { return _bid; } set { _bid = value; } }

        public double StrikePrice
        { get { return _strike; } set { _strike = value; } }

        public double NumberOfContracts
        { get { return _countofcontracts; } set { _countofcontracts = value; } }

        public Option()
        {

        }

        public Option(double pricePerShare, double setPrice/*double askPrice, double bidPrice*/, double strikePrice, int countOfContracts)
        {
            _pps = pricePerShare;
            _setPrice = SetPrice;
            //_ask = askPrice;
            //_bid = bidPrice;
            _strike = strikePrice;
            _countofcontracts = countOfContracts;
        }
    }
}
