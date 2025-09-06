using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_.sq_.neg_.exp.incomplete_
{


	/// <summary>
	/// from 0 to x, where x can be negative;
	/// </summary>
	public class OriginatedAround4Dbl
		:
		nilnul.num.real.ext.of_.unary_.OfExt4dblA

	{
		private nilnul.num.real_.PositiveDbl _accuracy;

		public nilnul.num.real_.PositiveDbl accuracy
		{
			get { return _accuracy; }
			set { _accuracy = value; }
		}

		public OriginatedAround4Dbl(nilnul.num.real_.PositiveDbl accuracy)
		{
			_accuracy = accuracy;
		}

		public OriginatedAround4Dbl(double v):this(new real_.PositiveDbl(v))
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
			var converge = new _origined_.op_._bySeries.series.Converge4dbl(par);

			converge.clamp(_accuracy);
			return nilnul.num.real.str_.started._MeanX.Avg(
				converge.current.avowed.lower.mark
				,
				converge.current.avowed.upper.mark
			);
		}

		static public OriginatedAround4Dbl OfThousandth() {
			return new OriginatedAround4Dbl(.001d);
		}
	}
}
