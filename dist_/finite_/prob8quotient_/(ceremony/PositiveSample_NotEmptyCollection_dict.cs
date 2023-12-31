using nilnul.num.natural;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class PositiveSample_NotEmptyCollection_dict<TSample>
		:Dictionary<TSample,nilnul.num.natural.PositiveNatural_inheritNatural>
	{

		public PositiveSample_NotEmptyCollection_dict(NotNull2<NonEmptyEnumerable<SampleCountPositive<TSample>>> samples)
			
		{

			foreach (var item in samples.val.val.val)
			{
				Add(item.sample.val, item.count2);
				
			}

			//nilnul.set.EmptyX.PredicateOfIEnumerable.reject(samples.val);

		}


		public PositiveSample_NotEmptyCollection_dict(
			IEnumerable<SampleCountPositive<TSample>> samples	
		)
			:this(
				new NotNull2<NonEmptyEnumerable<SampleCountPositive<TSample>>>(
					new NonEmptyEnumerable<SampleCountPositive<TSample>>(
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
						new NotNull2<IEnumerable<Natural2>> ( this.Select(c => c.Value as Natural2))
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
