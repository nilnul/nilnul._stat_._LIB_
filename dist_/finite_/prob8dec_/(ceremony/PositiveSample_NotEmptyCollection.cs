using nilnul.num.natural;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class PositiveSample_NotEmptyCollection<T>
		:nilnul.collection.set.HashSet<SampleCountPositive<T>,SampleCountPositive<T>.EqualityComparer>
	{

		public PositiveSample_NotEmptyCollection(NotNull2<nilnul.collection.EmptyX<SampleCountPositive<T>>.NounDual>  samples)
			:base(samples.val.val.val)
		{

			//nilnul.set.EmptyX.PredicateOfIEnumerable.reject(samples.val);

		}


		public PositiveSample_NotEmptyCollection(
			IEnumerable<SampleCountPositive<T>> samples	
		)
			:this(
				new NotNull2<nilnul.collection.EmptyX<SampleCountPositive<T>>.NounDual>(
					new nilnul.collection.EmptyX<SampleCountPositive<T>>.NounDual(
						samples
					)
				)
			)
		{
		}
					

		public nilnul.num.natural.PositiveNatural_inheritNatural count {

			get {
				return new PositiveNatural_inheritNatural( 
					nilnul.num.natural.set.SumX.Sum(
						new NotNull2<IEnumerable<Natural2>> ( this.Select(c => c.count.val as Natural2))
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
