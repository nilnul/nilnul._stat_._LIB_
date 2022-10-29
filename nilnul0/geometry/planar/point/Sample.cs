using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using point = nilnul.geometry.planar.point;

namespace nilnul.geometry.planar.point
{
	/// <summary>
	/// sample a point from the origin to this.
	/// </summary>
	public class _Sample
	{

		static public Point4dbl Eval(double x, double y)
		{
			var withinShift = nilnul.prob.RandomX._NextDouble_nonNeg(
					nilnul.geometry.planar.point._DeviationX.Deviation(x, y)
			);
			return point._ScaleX.Eval(
				x,y,withinShift
			);
		}
	}

	static public class SampleX
	{
		static public Point4dbl Sample(this Point4dbl p) {
			return _Sample.Eval(p.x, p.y);
		}
	}
}
