using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.Point4dbl;
using Square = nilnul.num.real.double_.SquareX;
using RangeFunc = nilnul.num.real.func.Ranged;

namespace nilnul.geometry.planar.circle
{
	static public class SampleX
	{
		static public PointD Sample(
			nilnul.geometry.planar.zone_.Disk4dbl
			//.curve_.cloze_.circ_.Nontrivia4dbl
			circle	
		) {

			var rangeCdf = nilnul.random.continuum.RangeCdf.CreateCloseRange(
				0, circle.circ.radius, 
				x => num.real.double_.SquareX.Square(x) / Square.Square( circle.circ.radius)
				
			);

			var inversedCdf =RangeFunc.CreateClosedRange(
				
				0, 1,
				
				x =>   Math.Sqrt(x  )* circle.circ.radius
			);

			var rangePdf = RangeFunc.CreateClosedRange(0, circle.circ.radius, x=>2*x / Square.Square(circle.circ.radius));


			var sampleOnR = inversedCdf.func( nilnul.RandomX.NextDouble());
			var sampleAngle = nilnul.RandomX._NextDouble(Tau.IntoDoulbe);

			return nilnul.geometry.planar.point_.PolarDX.ToPointDbl(sampleOnR,sampleAngle);


			

			//todo: find the central point, then get the mirrored point.
			throw new NotImplementedException();
		}
	}
}
