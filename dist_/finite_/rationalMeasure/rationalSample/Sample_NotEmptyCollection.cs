using nilnul.num.natural;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure
{
	public class Sample_NotEmptyCollection
		:nilnul.num.rational.collection.BagNotEmpty

		
		//PositiveSample_NotEmptyCollection_dict<nilnul.num.rational.Rational_InheritFraction>
	
	{

		public Sample_NotEmptyCollection(NotNull2<NonEmptyEnumerable<SampleCountPositive>> samples)
			:base(samples.val as IEnumerable<SampleCountPositive>)
		{

			//nilnul.set.EmptyX.PredicateOfIEnumerable.reject(samples.val);

		}

		public nilnul.num.natural.PositiveNatural_inheritNatural count {

			get {
				return new PositiveNatural_inheritNatural( 
					nilnul.num.natural.set.SumX.Sum(
						new NotNull2<IEnumerable<Natural2>> ( this.Select(c => c.count.val as Natural2))
				).val);
			}
		}
	}
}
