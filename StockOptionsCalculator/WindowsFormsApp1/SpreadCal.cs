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
        private double _prem100;
        private double _prem200;
        private double _strike100;
        private double _strike200;
        private double _be100;

        public bool Option1BuySell
        { get { return _optn1bysll; } set { _optn1bysll = value; } }

        public bool Option2BuySell
        { get { return _optn2bysll; } set { _optn2bysll = value; } }

        public double Premium2
        { get { return _premium2; } set { _premium2 = value; } }

        public double Strike2
        { get { return _strike2; } set { _strike2 = value; } }

        public double CountofContracts2
        { get { return _countofContracts2; } set { _countofContracts2 = value; } }

        public double Prem100
        { get { return _prem100; } set { _prem100 = value; } }

        public double Prem200
        { get { return _prem200; } set { _prem200 = value; } }

        public double Strike100
        { get { return _strike100; } set { _strike100 = value; } }

        public double Strike200
        { get { return _strike200; } set { _strike200 = value; } }

        public double BE100
        { get { return _be100; } set { _be100 = value; } }

        public SpreadCal()
        {        }

        public void VerticalCallSpread()
        {
            if (Option1BuySell == true)
            {
                _prem100 = Premium * 100;
                _prem200 = Premium2 * 100;

                _strike100 = StrikePrice * 100;
                _strike200 = Strike2 * 100;

                double eqPt1 = Prem100 - Prem200 + Strike100;

                UpfrontCost = (Premium - Premium2) * 100;
                CapitalRequired = Strike200 - UpfrontCost;
                double bePt2 = Strike100 + UpfrontCost;
                BreakEven = bePt2 / 100;
                BE100 = BreakEven * 100;
                ProfitPotential = Strike200 - BE100;
                
            }
            else if (Option1BuySell == false)
            {

            }
            
        }
    }
}
