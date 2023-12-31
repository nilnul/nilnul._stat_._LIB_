using nilnul.num.natural;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	[Obsolete()]
	public class PositiveSample_NotEmptyCollection2<T>
		:nilnul.collection.set.Set<
			SampleCountPositive2<T>
			,
			SampleCountPositive2<T>.EqualityComparer
		>
	{

		public PositiveSample_NotEmptyCollection2(NotNull2<NonEmptyEnumerable<SampleCountPositive2<T>>> samples)
			:base(samples.val)
		{
			//nilnul.set.EmptyX.PredicateOfIEnumerable.reject(samples.val);
		}

		public PositiveSample_NotEmptyCollection2(
			IEnumerable<SampleCountPositive2<T>> samples	
		)
			:this(
				new NotNull2<NonEmptyEnumerable<SampleCountPositive2<T>>>(
					new NonEmptyEnumerable<SampleCountPositive2<T>>(
						samples
					)
				)
			)
		{
		}

		public nilnul.num.natural.PositiveNatural_inheritNatural2 count {

			get {
				return new PositiveNatural_inheritNatural2( 
					nilnul.num.natural.set.SumX.Sum(
						 this.Select(c => c.count.val )
				).val);
			}
		}

		//public class Sample
		//{
		//	public NotNull2<T> sample;
		//	public NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count;

		//	public Sample(NotNull2<T> sample, NotNull2<nilnul.num.natural.PositiveNatural_inheritNatural> count)
		//	{
		//		this.sample = sample;
		//		this.count = count;
		//	}

		//	public class EqualityComparer :
		//IEqualityComparer<Sample>
		//	{

		//		public bool Equals(Sample x, Sample y)
		//		{
		//			return object.Equals(x.sample, y.sample);
		//		}

		//		public int GetHashCode(Sample obj)
		//		{
		//			return obj.sample.GetHashCode();
		//		}
		//	}
		//}
	}
}
