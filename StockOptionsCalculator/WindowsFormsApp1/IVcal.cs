using System;

public class IVcal : Option
{
	private double _iv;
	private double _buisDays;
	private double _ivDailyCal;
	private double _ivCustomCal;
	private double _PPSlow;
	private double _PPShigh;

	public double IV
	{ get { return _iv; } set { _iv = value; } }

	public double BusinessDays
	{ get { return _buisDays; } set { _buisDays = value; } }

	public double IvDailyResult
	{ get { return _ivDailyCal; } set { _ivDailyCal = value; } }

	public double IvCustomResult
	{ get { return _ivCustomCal; } set { _ivCustomCal = value; } }

	public double PPSlow
	{ get { return _PPSlow; } set { _PPSlow = value; } }

	public double PPShigh
	{ get { return _PPShigh; } set { _PPShigh = value; } }

	public IvCal()
	{ }

	public void IvDailyCal()
	{
		_ivDailyCal = _iv / 16;
		_PPSlow = Pric
	}

	public void IvCustomCal()
	{ 
		_ivCustomCal = (_iv/16)*Math.Sqrt(_buisDays)
	}
}
