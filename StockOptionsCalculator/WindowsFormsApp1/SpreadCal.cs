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
        private bool _optn1bysll;
        private bool _optn2bysll;
        private double _premium2;
        private double _strike2;
        private double _countofContracts2;

        public bool Option1BuySell
        { get { return _optn1bysll; } set { _optn1bysll = value; } }

        public bool Option2BuySell
        { get { return _optn2bysll; } set { _optn2bysll = value; } }

        public double Premium2
        { get { return _premium2; } set { _premium2 = value; } }


        private double Strike2
        { get { return _strike2; } set { _strike2 = value; } }

        private double CountofContracts2
        { get { return _countofContracts2; } set { _countofContracts2 = value; } }

        public SpreadCal()
        {        }

        public void VerticalCallSpread()
        {
            if (Option1BuySell == true)
            {
                double s100 = StrikePrice * 100;
                double s200 = Strike2 * 100;
                double eqPt1 = Premium - Premium2 + s100;
                double bePt2 = s100 + UpfrontCost;

                UpfrontCost = Premium + Premium2;
                ProfitPotential = eqPt1 - s200;
                BreakEven = bePt2 / 100;
            }
            else if (Option1BuySell == false)
            {

            }
            
        }
    }
}
