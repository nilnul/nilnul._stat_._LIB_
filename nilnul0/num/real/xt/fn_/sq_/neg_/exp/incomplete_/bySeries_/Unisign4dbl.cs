using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_.bySeries_
{


	/// <summary>
	/// we need to multiply e^-x^2
	/// </summary>
	///
	[Obsolete("failed the test, maybe it's asymptotic?", true)]
	public class Unisign4dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA

	{
		private nilnul.num.real_.PositiveDbl _accuracy;

		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _accuracy; }
			set { _accuracy = value; }
		}

		public Unisign4dbl(nilnul.num.real_.PositiveDbl accuracy)
		{
			_accuracy = accuracy;
		}

		public Unisign4dbl(double v):this(new real_.PositiveDbl(v))
		{
		}

		public override double _op_0ext(double par)
		{
			if (par == double.PositiveInfinity )
			{
				return exp._IntegrateX.AsDbl / 2;
			}
			if (par == double.NegativeInfinity )
			{
				return -exp._IntegrateX.AsDbl / 2;
			}

			/// only when <see cref="par"/> is finite:
			var converge = new bySeries_._unisign.series.Converge4dbl(par);

			converge.clamp(_accuracy);

			return nilnul.num.real.str_.started._MeanX.Avg(
				converge.current.avowed.lower.mark
				,
				converge.current.avowed.upper.mark
			) * Math.Exp( -converge.argSq)
			/2 ; // as this is half;
		}

		static public Unisign4dbl OfThousandth() {
			return new Unisign4dbl(.001d);
		}
	}
}
