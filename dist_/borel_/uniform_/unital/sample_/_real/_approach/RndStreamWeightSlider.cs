using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.collection.recur.type;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.all;

namespace nilnul._prob.rnd._real._approach
{
	/// <summary>
	/// give each term of the positional terms as as stream like: 0.8, 0.01, 0.003,... for 0.813...
	/// </summary>
	public class RndStreamWeightSlider : nilnul.num.quotient.StreamI3
	{
		private _prob.Rnd _rnd;

		

		

		private nilnul._slider_.SliderI<Quotient> _positionalWeightSlider;

		public Quotient positionalWeight {
			get {
				return _positionalWeightSlider.current;
			}
		}
		


		public RndStreamWeightSlider( )
		{
			_rnd = new _prob.Rnd();	//will regress to same seed.


			_positionalWeightSlider = new nilnul.num.quotient.slider_.GeometricStandard(
		 (int.MaxValue).Inverse()
		);

			
		}

		public Simplify.Ed1 next()
		{
			_positionalWeightSlider.moveNext();
			return _positionalWeightSlider.current * _rnd.next();

			//throw new NotImplementedException();
		}

		
	}
}
