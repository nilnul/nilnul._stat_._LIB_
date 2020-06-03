using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointD = nilnul.geometry.planar.PointDbl;
using Square = nilnul.num.real.double_.SquareX;
using RangeFunc = nilnul.num.real.func.Ranged;

namespace nilnul.geometry.planar.disc.point
{
	static public class _UniformX
	{
		static public PointD Sample(
			nilnul.geometry.planar.CircleDouble circle	
		) {

			var rangeCdf = nilnul.random.continuum.RangeCdf.CreateCloseRange(
				0, circle.r, 
				x => num.real.double_.SquareX.Square(x) / Square.Square( circle.r)
				
			);

			var inversedCdf =RangeFunc.CreateClosedRange(
				
				0, 1,
				
				x =>   Math.Sqrt(x  )* circle.r
			);

			var rangePdf = RangeFunc.CreateClosedRange(0, circle.r, x=>2*x / Square.Square(circle.r));


			var sampleOnR = inversedCdf.func( nilnul.RandomX.NextDouble());
			var sampleAngle = nilnul.RandomX._NextDouble(Tau.IntoDoulbe);

			return nilnul.geometry.planar.point_.PolarD.ToPointD(sampleOnR,sampleAngle);


			

			//todo: find the central point, then get the mirrored point.
			throw new NotImplementedException();
		}


	}

	public class Uniform
	{



	}
}
