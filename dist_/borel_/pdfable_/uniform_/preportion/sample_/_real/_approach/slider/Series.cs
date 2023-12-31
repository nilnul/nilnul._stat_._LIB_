using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul._prob.rnd._real._approach.slider
{
	public class Series : nilnul.num.quotient.slider.Series
	{
		private SliderOfAugments _sliderOfAugments;
		public Series() : base(new _approach.SliderOfAugments())
		{
		}

		public Quotient positionalWeight {
			get {
				return _sliderOfAugments.positionalWeight;
			}
		}
	}
}
