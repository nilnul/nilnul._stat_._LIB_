using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num;
using nilnul.num.real;
using nilnul.num.real;


namespace nilnul.prob_.continuum
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// the developers of this class referenced:
	/// 1.http://mathworld.wolfram.com/ExponentialDistribution.html
	/// 
	/// </remarks>
	public class Exp
		: nilnul.prob_._continuum_.SupportI
		,
		_continuum_.CumulativeDensityI
	{
		public nilnul.num.real.ext.Interval support
		{
			get
			{
				return  nilnul.num.real.ext.Interval.CreateLeftCloseRightInf(
					 new nilnul.num.real_.Quotient( 0)
				);
				throw new NotImplementedException();
			}
		}
		private nilnul.num.real_.Positive _rate;

		public nilnul.num.real_.Positive rate
		{
			get { return _rate; }
			//set { _rate = value; }
		}


		public Exp(nilnul.num.real_.Positive rate  )
		{
			_rate = rate;
		}

		public num.RealI cumulativeDensity(num.RealI x)
		{

			return 1 -
				nilnul.num.real.op_.unary_.Exp.Singleton.op(

					nilnul.num.real.op_.unary_.Neg.Singleton.op(
						nilnul.num.real.op_.binary_.Multi.Singleton.op(
							_rate.en,x
						)
					)
			).ToReal();

		}
	}
}
