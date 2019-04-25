using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /* FIGURE OUT WHAT REVENUE GETS TAKEN WHEN A TRADE IS OPENED AND CLOSED // AKA BROKAGE COMMISSION */

    public class SpreadCal : PosCal
    {
        PosCal posCal = new PosCal();

        private double _setPrice2;
        private double _strike2;
        private double _countofContracts2;

        public double SetPrice2
        { get { return _setPrice2; } set { _setPrice2 = value; } }

        private double Strike2
        { get { return _strike2; } set { _strike2 = value; } }

        private double CountofContracts2
        { get { return _countofContracts2; } set { _countofContracts2 = value; } }

        public SpreadCal()
        {        }

        public void VerticalSpread()
        {
            posCal.FrontedProfit
        }
    }
}
