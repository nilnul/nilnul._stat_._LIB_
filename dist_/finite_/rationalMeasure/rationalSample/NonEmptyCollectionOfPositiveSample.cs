using nilnul.num.natural;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalMeasure.rationalSample
{
	public class NonEmptyCollectionOfPositiveSample
		:PositiveSample_NotEmptyCollection<nilnul.num.rational.Rational_InheritFraction>
	{

		public NonEmptyCollectionOfPositiveSample(NotNull2<nilnul.collection.EmptyEnumerableX<SamplePositive_inheritSampleCount>.NotEmptySequence> samples)
			:base((samples.val as IEnumerable<SamplePositive_inheritSampleCount> ).Select(c=>new SampleCountPositive(c.sample.val, new PositiveNatural_inheritNatural( c.count.val))))
		{

			//nilnul.set.EmptyX.PredicateOfIEnumerable.reject(samples.val);

		}

		public NonEmptyCollectionOfPositiveSample(IEnumerable<SamplePositive_inheritSampleCount> samples)
			:this( 
			new nilnul.collection.EmptyEnumerableX<SamplePositive_inheritSampleCount>.NotEmptySequence(samples.ToNotNull()).ToNotNull() 
			)
		{

		}


		public NonEmptyCollectionOfPositiveSample(nilnul.collection.bag.Bag_dictPositive<nilnul.num.rational.Rational_InheritFraction> bag)
			:this(bag.Select(c=>new SamplePositive_inheritSampleCount(c.Key,c.Value)))

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
	}
}
