using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class SampleCount<T>
	{
		public NotNull2<T> sample;
		public NotNull2<nilnul.num.natural.Natural2> count;


		public SampleCount(NotNull2<T> sample, NotNull2<nilnul.num.natural.Natural2> count)
		{
			this.sample = sample;
			this.count = count;
		}

		public class EqualityComparer :
	IEqualityComparer<SampleCount<T>>
		{


			public bool Equals(SampleCount<T> x, SampleCount<T> y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SampleCount<T> obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}




	}

}
