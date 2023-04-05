using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure.rationalSample
{
	public class SampleCount
		:
		SampleCount<Rational_InheritFraction>
	{
	


		public SampleCount(NotNull2<Rational_InheritFraction> sample, NotNull2<nilnul.num.natural.Natural2> count)
			:base(sample,count)
		{
			
		}

		public SampleCount(Rational_InheritFraction sample, Natural2 count)
			: this(sample.ToNotNull(), count.ToNotNull())
		{
		}
		public SampleCount(Rational_InheritFraction sample, int count)
			: this(sample, new Natural2(count))
		{
		}


					
					

		public class EqualityComparer :
	IEqualityComparer<SampleCount>
		{


			public bool Equals(SampleCount x, SampleCount y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SampleCount obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}


	


	}

}
