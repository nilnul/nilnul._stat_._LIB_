using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class SampleCountPositive<T>
	{
		public NotNull2<T> sample;
		public NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count;

		public PositiveNatural_inheritNatural count2 {
			get {
				return count.val;
			}
		}


		public SampleCountPositive(NotNull2<T> sample, NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count)
		{
			this.sample = sample;
			this.count = count;
		}

		public class EqualityComparer :
	IEqualityComparer<SampleCountPositive<T>>
		{


			public bool Equals(SampleCountPositive<T> x, SampleCountPositive<T> y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SampleCountPositive<T> obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}




	}

}
