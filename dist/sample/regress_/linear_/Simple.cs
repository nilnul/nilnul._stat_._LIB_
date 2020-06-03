using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist.sample.regress_.linear_
{
	static public class _SimpleX
	{
		static public (double, double) Regress(
			nilnul.geometry.planar.point.bag.be_.plural.En points
		) {

			var xBar = points.ee.Sum(weighted => weighted.Key.x * (ulong)weighted.Value.en) / (ulong) points.ee.cardinality.en;

			var yBar = points.ee.Sum(weighted => weighted.Key.y * (ulong)weighted.Value.en) / (ulong) points.ee.cardinality.en;

			var varianceSum = points.ee.Sum(
				weighted => nilnul.num.real.op_.unary_.Square.Singleton.op( weighted.Key.x -xBar ) * (ulong)weighted.Value.en
			) ;

			var covarianceSum = points.ee.Sum(
				weighted => ( weighted.Key.x -xBar ) *  ( weighted.Key.y -yBar )* (ulong)weighted.Value.en
			) ;

			var slope = covarianceSum / varianceSum;
			
			return (
			 yBar - slope * xBar
			 ,
			 slope
			);

		}

		public static (double, double) Regress(IEnumerable<(double, double)> enumerable)
		{

			return Regress(
				new geometry.planar.point.bag.be_.plural.En(
					new geometry.planar.point.BagDbl(
						enumerable.Select(
							x=> new geometry.planar.PointDbl(x.Item1,x.Item2)
						)
					)
				)
			);
		}
	}
}
