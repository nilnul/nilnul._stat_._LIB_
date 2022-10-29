using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class SampleCountPositive2<T>
	{
		public NotNull2<T> sample;
		public NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural2> count;

		public PositiveNatural_inheritNatural2 count2 {
			get {
				return count.val;
			}
		}


		public SampleCountPositive2(NotNull2<T> sample, NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural2> count)
		{
			this.sample = sample;
			this.count = count;
		}

		public class EqualityComparer :
	IEqualityComparer<SampleCountPositive2<T>>
		{


			public bool Equals(SampleCountPositive2<T> x, SampleCountPositive2<T> y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SampleCountPositive2<T> obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}




	}

}
