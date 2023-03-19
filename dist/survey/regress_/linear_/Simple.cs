using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist.survey.regress_.linear_
{
	/*
https://m.book118.com/html/2017/1006/7116156022001051.shtm

MIT这位教授完全是针对工程专业的同学讲线代的，不搞什么证明，直接讲实际应
用，最让人耳目一新的是，用投影矩阵解释最小二乘法。这个最小二乘法是中学就熟
悉的东西，可是从来没想到能这样解释：

“三维空间里有一个平面，现在，有一个向量不在这个平面里，那就把它投影到这个平
面里，投影得到的向量是平面上最接近外面那个向量的。最小二乘法，实际就是求这
个投影向量。”

而且用一道例题，验算给大家看，投影矩阵方法和中学的最小二乘法结果一模一样。
	MIT那位好像是matlab 的作者，说白了还是水平深度问题，理解透了，就能出物理意义了，理解不透，只能数字表面符号推导
	 */

	/// <summary>
	/// only on variable
	/// </summary>
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
							x=> new geometry.planar.Point4dbl(x.Item1,x.Item2)
						)
					)
				)
			);
		}
	}
}
