using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num;
using nilnul.num.real;
using nilnul.num.real;
using nilnul.num.real.ext;

namespace nilnul.stat.dist_.borel_.pdf_
{
	/// <summary>
	/// sample: timespan;
	/// 
	/// </summary>
	/// <remarks>
	/// the developers of this class referenced:
	/// 1.http://mathworld.wolfram.com/ExponentialDistribution.html
	/// 
	/// </remarks>
	public class Exp4dbl
		:
		borel_.Pdfable4dblA
		,
		 //nilnul.prob_._continuum_.SupportI
		 //,
		 Borel4dblI
		,
		borel_.Pdf4dblI
		,
		borel_.pdf_.Invertible4dblI
	{

		private nilnul.num.real_.PositiveDblI _rate;

		/// <summary>
		/// on averge, how many would come per a unit of timespan;
		/// </summary>
		public nilnul.num.real_.PositiveDblI rate
		{
			get { return _rate; }
			//set { _rate = value; }
		}


		public Exp4dbl(nilnul.num.real_.PositiveDblI rate)
		{
			_rate = rate;
		}
		public double rateAsDbl
		{
			get
			{
				return _rate.dblen;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public double mean
		{
			get
			{
				return 1 / _rate.dblen;
			}
		}

		public double variance
		{
			get
			{
				return 1 / _rate.dblen * _rate.dblen;
			}
		}



		public override double cdf(double x)
		{
			if (x < 0)
			{
				return 0;
			}
			return 1 - Math.Exp(
				-_rate.dblen * x
			);
		}
	


		public override double sample()
		{
			return -Math.Log(
				1 -
				borel_.pdf_.uniform_._Preportion4dblX.Sample()
			) / this.rateAsDbl;

			//throw new NotImplementedException();
		}


		public double _sample_byComplement()
		{
			//if U is uniform on (0, 1), then so is 1 − U. 
			return -Math.Log(

				borel_.pdf_.uniform_._Preportion4dblX.Sample()
			) / this.rateAsDbl;

			//throw new NotImplementedException();
		}



		public override double density(double sample)
		{
			if (sample < 0)
			{
				return 0;
			}
			return this._rate.dblen * Math.Exp(
				-_rate.dblen * sample
			);
		}

		public override double invert(double cdf)
		{
			nilnul.num.real.be_.nonneg_.leOne.VowDbl.Singleton.vow(cdf);
			//if U is uniform on (0, 1), then so is 1 − U. 
			return -Math.Log(
				1-cdf
			) / this.rateAsDbl;

		}

		
	}
}
