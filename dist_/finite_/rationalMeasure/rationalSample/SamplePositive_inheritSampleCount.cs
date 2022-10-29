using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalMeasure.rationalSample
{
	public class SamplePositive_inheritSampleCount
		:SampleCount
	{
		


		public SamplePositive_inheritSampleCount(NotNull2<R> sample, NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count)
			:base(sample,count)
		{
			
		}

		public SamplePositive_inheritSampleCount(R sample,PositiveNatural_inheritNatural count)
			:this(NotNullX.ToNotNull(sample),NotNullX.ToNotNull(count))
		{
		}

		public SamplePositive_inheritSampleCount(R sample, PositiveNatural_inheritNatural2 count)
			: this(NotNullX.ToNotNull(sample), NotNullX.ToNotNull(new PositiveNatural_inheritNatural( count.val)))
		{
		}

		public SamplePositive_inheritSampleCount(R sample, int count)
			: this((sample), new PositiveNatural_inheritNatural(count))
		{
		}
					

		public class EqualityComparer :
	IEqualityComparer<SamplePositive_inheritSampleCount>
		{


			public bool Equals(SamplePositive_inheritSampleCount x, SamplePositive_inheritSampleCount y)
			{
				return object.Equals(x.sample.val, y.sample.val);
			}

			public int GetHashCode(SamplePositive_inheritSampleCount obj)
			{
				return obj.sample.val.GetHashCode();
			}


		}




	}

}
