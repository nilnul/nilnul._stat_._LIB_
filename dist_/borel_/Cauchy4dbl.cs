using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_
{
	/// <summary>
	/// chiSquared
	/// </summary>
	public class Cauchy4dbl
		:
		nilnul.obj.Box1<
			nilnul.num.real_.PositiveDblI
			>
		,
		IBorel
	{
		private double _location;

		public double location
		{
			get { return _location; }
			set { _location = value; }
		}

		public Cauchy4dbl(double location0, PositiveDblI val) : base(val)
		{
			_location = location0;
		}
		public Cauchy4dbl(double location0, PositiveDbl val) : this(location0, (PositiveDblI)val)
		{
		}
		public Cauchy4dbl(double x, double y):this(x, new PositiveDbl(y))
		{

		}

		public Cauchy4dbl():this(0, 1)
		{

		}

		public double density(double sample) {
			var boxedAsDbl = boxed.dblen.ee;
			return 1 / (
				Math.PI *boxedAsDbl
				*(
					1+
					nilnul.num.real.op_.unary_.Square.Singleton.op
					(
						(sample-location) / boxedAsDbl
					)
				)
			);
		}

		public double cumulative(double sample) {
			var boxedAsDbl = boxed.dblen.ee;
			return 1 / 	Math.PI *boxedAsDbl
				*
				Math.Atan
				(
					
						(sample-location) / boxedAsDbl
					
				)
				+
				0.5
			;
		}

	}
}
