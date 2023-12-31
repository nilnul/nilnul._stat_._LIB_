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
	public class SliderOfAugments : 
		nilnul.Box1<_prob.rnd.Slider>
		,
		nilnul.num.quotient.SliderI
	{
		

		public Quotient current
		{
			get
			{
				return boxed.current * positionalWeight;
				//throw new NotImplementedException();
			}
		}

	

		private nilnul._slider_.SliderI<Quotient> _positionalWeightSlider;

		public Quotient positionalWeight {
			get {
				return _positionalWeightSlider.current;
			}
		}

		public SliderOfAugments():base(new Slider())
		{
			


			_positionalWeightSlider = new nilnul.num.quotient.slider_.GeometricSkip(
					 (int.MaxValue).Inverse()
					);
		}

		

		public void moveNext()
		{
			_positionalWeightSlider.moveNext();
			boxed.moveNext();	/// the random number between [0,int.max)

			//throw new NotImplementedException();
		}
	}
}
