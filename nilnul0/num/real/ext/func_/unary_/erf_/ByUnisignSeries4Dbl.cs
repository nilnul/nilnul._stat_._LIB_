using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_.erf_

{
	///mathworld.wolfram.com/Erf.html
	///says for x le1le 1, that is, x is very small, then we can use this; maybe it's an asymptotic series;
	/// and it there gives another series that is accurate, and is not denoted as for number far less than one;
	/// 
	///
	/// due to our test, we find it fails when x=0.2;
	///
	/// and at:  https://en.wikipedia.org/wiki/Normal_distribution
	/// <summary>
	/// from 0 to x, where x is in [-inf, +inf], so the range is [-1,1]
	/// </summary>
	///
	[Obsolete("failed the test, maybe it's asymptotic?",true)]
	public class ByUnisignSeries4Dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA
	{


		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _sqNegExpIncomplete.accuracy; }
		}

		private nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_.Unisign4dbl _sqNegExpIncomplete;

		public nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_.Unisign4dbl sqNegExpIncomplete
		{
			get { return _sqNegExpIncomplete; }
			set { _sqNegExpIncomplete = value; }
		}

		public ByUnisignSeries4Dbl(nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_.Unisign4dbl accuracy)
		{
			_sqNegExpIncomplete = accuracy;
		}

		public ByUnisignSeries4Dbl(nilnul.num.real_.PositiveDbl accuracy) : this(
			new sq_.neg_.exp.incomplete_.bySeries_.Unisign4dbl(accuracy)
		)
		{
		}

		public ByUnisignSeries4Dbl(double v) : this(new real_.PositiveDbl(v))
		{
		}


		/// <summary>
		/// an integral of exp(-t^2)|<see cref="Integrand4dbl"/>; from 0 to x;
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public  double _op_0extNonneg(double par)
		{
			return _op_0ext(par);
		}

		static public readonly double InvertSqrtPi = 1 / nilnul.num.real_.unison_.tau.half._SqrtX.AsDbl;
		static public readonly double Twice_InvertSqrtPi = 2 / nilnul.num.real_.unison_.tau.half._SqrtX.AsDbl;
		public override double _op_0ext(double par)
		{
			return Twice_InvertSqrtPi
				*
				_sqNegExpIncomplete._op_0ext(par);
			/// todo:
			//throw new NotImplementedException();
		}


		static public ByUnisignSeries4Dbl OfThousandth()
		{
			return new ByUnisignSeries4Dbl(.001);
		}


	}
}
