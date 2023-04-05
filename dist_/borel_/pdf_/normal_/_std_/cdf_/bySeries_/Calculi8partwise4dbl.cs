using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdf_.normal_._std_.cdf_.bySeries_
{


	/// <summary>
	/// we need to multiply e^-x^2
	/// </summary>
	public class Calculi8partwise4dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA

	{
		private nilnul.num.real_.PositiveDbl _accuracy;

		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _accuracy; }
			set { _accuracy = value; }
		}

		public Calculi8partwise4dbl(nilnul.num.real_.PositiveDbl accuracy)
		{
			_accuracy = accuracy;
		}

		public Calculi8partwise4dbl(double v):this(new num.real_.PositiveDbl(v))
		{
		}

		public override double _op_0ext(double par)
		{
			if (par == double.PositiveInfinity )
			{
				return 1;
			}
			if (par == double.NegativeInfinity )
			{
				return 0;
			}

			/// only when <see cref="par"/> is finite:
			var converge = new bySeries_._calculi8partwise.series.Converge4dbl(par);

			converge.clamp(_accuracy);

			return .5
				+
				nilnul.num.real.str_.started._MeanX.Avg(
					converge.current.avowed.lower.mark
					,
					converge.current.avowed.upper.mark
				) * Math.Exp( -converge.argSq/2)

			/ Math.Sqrt( num.real_._Tau4dblX.FULL) ; // as this is half;
		}

		static public Calculi8partwise4dbl OfThousandth() {
			return new Calculi8partwise4dbl(.001d);
		}
	}
}
