﻿using System;
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
        private double _capitalRequired;
        private double _frontedProfit;
        private double _upFrontCost;
        private double _priceMove;
        private double _intrinsic;
        private double _time;
        private double _roi;
        private double _ro72;
        private bool _itm;

        //IV CAL VAR
        private double _iv;
        private double _buisDays;
        private double _ivDailyCal;
        private double _ivCustomCal;
        private double _PPSlowDaily;
        private double _PPShighDaily;
        private double _PPShighCustom;
        private double _PPSlowCustom;
        private double _priceChangeDaily;
        private double _priceChangeCustom;

        public double BreakEven
        { get { return _breakEven; } set { _breakEven = value; } }

        public double ProfitPotential
        { get { return _profitPotential; } set { _profitPotential = value; } }

        public double CapitalRequired
        { get { return _capitalRequired; } set { _capitalRequired = value; } }

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

        public double ROI
        { get { return _roi; } set { _roi = value; } }

        public double RO72
        { get { return _ro72; } set { _ro72 = value; } }

        public bool ITM
        { get { return _itm; } set { _itm = value; } }

        //IV CAL//IV CAL//IV CAL//IV CAL//IV CAL//IV CAL//IV CAL//IV CAL//IV CAL
        public double IV
        { get { return _iv; } set { _iv = value; } }

        public double BusinessDays
        { get { return _buisDays; } set { _buisDays = value; } }

        public double IvDailyResult
        { get { return _ivDailyCal; } set { _ivDailyCal = value; } }

        public double IvCustomResult
        { get { return _ivCustomCal; } set { _ivCustomCal = value; } }

        public double PPSlowDaily
        { get { return _PPSlowDaily; } set { _PPSlowDaily = value; } }

        public double PPShighDaily
        { get { return _PPShighDaily; } set { _PPShighDaily = value; } }

        public double PPSlowCustom
        { get { return _PPSlowCustom; } set { _PPSlowCustom = value; } }

        public double PPShighCustom
        { get { return _PPShighCustom; } set { _PPShighCustom = value; } }

        public double PriceChangeDaily
        { get { return _priceChangeDaily; } set { _priceChangeDaily = value; } }

        public double PriceChangeCustom
        { get { return _priceChangeCustom; } set { _priceChangeCustom = value; } }

        public PosCal()
        { }

        public void BuyCall()
        {
            _upFrontCost = (Premium * 100) * NumberOfContracts;
            _breakEven = StrikePrice + Premium;
            _profitPotential = ((PricePerShare - StrikePrice) - Premium) * 100;
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
            _profitPotential = ((StrikePrice - PricePerShare) - Premium) * 100;
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
            double eqRo72P1 = Premium / StrikePrice;
            double eqRo72P2 = eqRo72P1 * 100;
            //upfront cost is essentially risk prem/strike
            _frontedProfit = (Premium * 100) * NumberOfContracts;
            _upFrontCost = ((StrikePrice * 100) - FrontedProfit) * NumberOfContracts;
            _breakEven = StrikePrice - Premium;
            _roi = (FrontedProfit / UpfrontCost) * 100;
            _ro72 = 72/eqRo72P2;
             
        }

        public void IVCal()
        {
            //Calculate Daily IV
            _ivDailyCal = (_iv / 16);
            //Calculate Custom amount of days
            _ivCustomCal = ((_iv / 16) * Math.Sqrt(_buisDays));
            //Calculate how much price with change daily + or -
            _priceChangeDaily = (PricePerShare * _ivDailyCal);
            //Calculate how much price will change in custom range + or -
            _priceChangeCustom = (PricePerShare * _ivCustomCal);
            //Set the price range for the daily
            _PPSlowDaily = PricePerShare - _priceChangeDaily;
            _PPShighDaily = PricePerShare + _priceChangeDaily;
            //Set the price range for custom range
            _PPSlowCustom = PricePerShare - _priceChangeCustom;
            _PPShighCustom = PricePerShare + _priceChangeCustom;
        }
    }
}
