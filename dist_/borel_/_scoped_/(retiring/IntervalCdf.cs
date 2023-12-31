using nilnul.num.real.func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Range = nilnul.num.real.double_.noNaN.range.b.Bounded.Asserted;

namespace nilnul.random.continuum
{
	public class RangeCdf
	{



		private nilnul.num.real.func.Ranged _ranged;

		public nilnul.num.real.func.Ranged ranged
		{
			get { return _ranged; }
			set { _ranged = value; }
		}

		public RangeCdf( nilnul.num.real.func.Ranged ranged )
		{
			_ranged = ranged;
		}


		static public RangeCdf onePerSqauredX = new RangeCdf(
			 num.real.func.Ranged.CreateClosedRange(0,1,x=>num.real.double_.SquareX.Square(x)
					
			)	
		) {


		};

		static public RangeCdf CreateCloseRange(double a, double b, Func<double,double> func) {
			return new RangeCdf(
				Ranged.CreateClosedRange(a,b,func)	
			);
		}




	}
}
