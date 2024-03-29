﻿using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.prob.discrete;
using nilnul.prob.rationalMeasure.rationalSample;
using nilnul.prob.rationalProb;
using nilnul.prob.rationalProb.rationalSample;
using System.Numerics;
using N = nilnul.num.natural.Natural_bigInteger;
using nilnul.num.natural;

namespace nilnul.prob.rationalMeasure.empirical
{
	/// <summary>
	/// ordered by sample.
	/// prepended with zero.
	/// all positives (multiplicity of 1/(n+1)) in between.
	/// appended with 1/(n+1)
	/// 
	/// </summary>
	public  class DensityBenchmarks
		: nilnul.prob.rationalProb.rationalSample.DensityFunction_sortedDict
	{



		private DensityBenchmarks(List<Event> events)
			: base(events as IEnumerable<Event>)
		{

			//verify this.sortedlist
			//nilnul.bit.Assert.True(	sortedList.First().Value == 0);

			//verify 1/(n+1)




		}

		public Rational_InheritFraction min
		{
			get
			{
				return this.sortedList.First().Key;
			}
		}

		public Rational_InheritFraction max
		{
			get
			{
				return this.sortedList.Last().Key;
			}
		}


		static public DensityBenchmarks Create(
			NotNull2<

	num.rational.collection.Bag3.Empty.NounAntonym> samples

	//NonEmptyCollectionOfPositiveSample samples

	)
		{
			///not null.
			return _Create(samples.val.val);

		}	

		static public DensityBenchmarks _Create(
			num.rational.collection.Bag3.Empty.NounAntonym samples_notNull
		) {
				return _Create(samples_notNull.val);
		}	


		static public DensityBenchmarks _Create(
			num.rational.collection.Bag3 samples_nonEmpty
		)
		{
			return new DensityBenchmarks(

				_GenDensityFunc3(samples_nonEmpty)
			);

			throw new NotImplementedException();

		}




		//public NonEmptyCollectionOfPositiveSample samples;


		//public List<Event> cumulativeSequence;

		//public Cdf cdf;



		//public List<Event> benchmarkOfDensities;

		public Rational_InheritFraction span
		{
			get
			{
				return max - min;
			}
		}

		

		public Dictionary<Rational_InheritFraction, Prob> densities(uint times)
		{

			var r = new Dictionary<Rational_InheritFraction, Prob>();
			//nilnul.bit.Assert.True(times >= 0);

			var timesPlusOne = times + 1;



			for (int i = 0; i < times; i++)
			{
				var sample = min + nilnul.num.rational.Rational_InheritFraction.Divide(i, times + 1) * span;

				r.Add(sample, density(sample));

			}

			return r;


			throw new NotImplementedException();


		}



		public Prob density(Rational_InheritFraction sample)
		{


			//find the interval.



			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
					(sample),
					this.sortedList.Keys.Cast<Rational_InheritFraction>().ToList(),
					nilnul.num.rational.order.Comparer.Instance
			);



			if (interval.Item2 == null)
			{
				return Prob.Zero;

			}

			if (interval.Item1 == null)
			{
				return Prob.Zero;

			}




			return new Prob(sortedList.ElementAt(interval.Item2.Value).Key as Rational_InheritFraction / (sortedList.ElementAt(interval.Item2.Value).Key - sortedList.ElementAt(interval.Item1.Value).Key));




			throw new NotImplementedException();



		}


		static public List<SampleCount> GenerateDensityFunc(PositiveSample_NotEmptyCollection samples)
		{
			//prepend a sample offset -1/(n+1)/2 of probability 0
			//prepend a sample offset 1/(n+1)/2 of probability 1/(n+1).
			//due to the characteristics of CDF, this will make the CDF-generated PMF distribution to be:
			///( 1/(n+1), 1/(n+1),...,1/(n+1),1/(n+1))
			///

			//append a sample



			var count = samples.count;
			var max = samples.Aggregate(samples.First(), (a, c) => c.sample.val > a.sample.val ? c : a).count.val;
			var min = samples.Aggregate(samples.First(), (a, c) => c.count.val > a.count.val ? c : a).count.val;

			var probSpan = nilnul.num.rational.Rational_InheritFraction.Divide(1, (count + 1));


			var len = max - min;
			var span = nilnul.num.rational.Rational_InheritFraction.Divide(len, (count - 1));
			var sample = nilnul.num.rational.Rational_InheritFraction.Divide(1, len) + max;

			var prepend = min - span;
			var result = new List<rationalSample.SampleCount>();
			result.Add(new SampleCount(prepend, 0));

			//todo: add all

			result.Add(new SampleCount(sample, 1));




			samples.Add(
				new SampleCountPositive(
					sample
					,
					1

				)
			);

			return result;


		}

		static public List<SampleCount> GenFrequency(PositiveSample_NotEmptyCollection samples_countPlural)
		{
			//prepend a sample offset -1/(n+1)/2 of probability 0
			//prepend a sample offset 1/(n+1)/2 of probability 1/(n+1).
			//due to the characteristics of CDF, this will make the CDF-generated PMF distribution to be:
			///( 1/(n+1), 1/(n+1),...,1/(n+1),1/(n+1))
			///

			//append a sample

			var count = samples_countPlural.count;
			var maxSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.sample.val > a.sample.val ? c : a).sample.val;
			var minSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.count.val > a.count.val ? c : a).count.val;

			var probSpan = nilnul.num.rational.Rational_InheritFraction.Divide(1, (count + 1));


			var len = maxSample - minSample;
			var span = nilnul.num.rational.Rational_InheritFraction.Divide(len, (count - 1));




			var sample = nilnul.num.rational.Rational_InheritFraction.Divide(1, len) + maxSample;


			var prepend = minSample - span;



			var result = new List<rationalSample.SampleCount>();

			var result2 = new List<rationalProb.rationalSample.Event>();


			result.Add(new SampleCount(prepend, 0));

			//todo: add all

			result.Add(new SampleCount(sample, 1));




			samples_countPlural.Add(
				new SampleCountPositive(
					sample
					,
					1

				)
			);

			return result;


		}

		static public List<SampleCount> GenCounts_onNeighbour(NonEmptyCollectionOfPositiveSample samples_countPlural)
		{
			//prepend a sample offset -1/(n+1)/2 of probability 0
			//prepend a sample offset 1/(n+1)/2 of probability 1/(n+1).
			//due to the characteristics of CDF, this will make the CDF-generated PMF distribution to be:
			///( 1/(n+1), 1/(n+1),...,1/(n+1),1/(n+1))
			///

			//append a sample


			var sortEventBySample = samples_countPlural.OrderBy(c => c.count2, nilnul.num.rational.order.Comparer.Instance);

			var count = samples_countPlural.count;

			var maxSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.sample.val > a.sample.val ? c : a).sample.val;
			var minSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.count.val > a.count.val ? c : a).count.val;


			var nextMinSample = sortEventBySample.Skip(1).First();


			var probSpan = nilnul.num.rational.Rational_InheritFraction.Divide(1, (count + 1));


			var len = maxSample - minSample;
			var span = nilnul.num.rational.Rational_InheritFraction.Divide(len, (count - 1));




			var sample = nilnul.num.rational.Rational_InheritFraction.Divide(1, len) + maxSample;




			var prepend = minSample - span;



			var result = new List<rationalSample.SampleCount>();

			var result2 = new List<rationalProb.rationalSample.Event>();


			result.Add(new SampleCount(prepend, 0));

			//todo: add all

			result.Add(new SampleCount(sample, 1));




			samples_countPlural.Add(
				new SampleCountPositive(
					sample
					,
					1

				)
			);

			return result;


		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="samples_countPlural">
		/// not ordered. 
		/// </param>
		/// <returns></returns>
		static public num.rational.collection.Dict2 GenCounts_prependAppendSpanOnAverage(num.rational.collection.Bag3 samples_countPlural)
		{
			//prepend a sample offset -1/(n+1)/2 of probability 0
			//prepend a sample offset 1/(n+1)/2 of probability 1/(n+1).
			//due to the characteristics of CDF, this will make the CDF-generated PMF distribution to be:
			///( 1/(n+1), 1/(n+1),...,1/(n+1),1/(n+1))
			///

			//append a sample

			var count = samples_countPlural.cardinality;

			var maxSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.Key > a.Key ? c : a).Key;
			var minSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.Key < a.Key ? c : a).Key;

			var probSpan = nilnul.num.rational.Rational_InheritFraction.Divide((Rational_InheritFraction)( 1), (count + 1));
			var countMinusOne = count - 1;

			var len = maxSample - minSample;
			var span = nilnul.num.rational.Rational_InheritFraction.Divide(len, countMinusOne);




			//var append = nilnul.num.rational.Rational_InheritFraction.Divide(1, len) + maxSample; 
			var append = span + maxSample;


			var prepend = minSample - span;



			//var result = new List<rationalSample.SampleCount>();

			//var result2 = new List<rationalProb.rationalSample.Event>();

			var result3 = new nilnul.num.rational.collection.Dict2();




			//result.Add(new SampleCount(prepend, 0));
			result3.Add(prepend, new N(0));


			//todo: add all

			//result.AddRange(samples_countPlural);
			//result3.unionWith(
			//	samples_countPlural.Select(
			//		c => new KeyValuePair<Rational_InheritFraction, Natural_bigInteger>(c.sample.val, new Natural_bigInteger(c.count2.val))
			//)
			//);

			result3.unionWith(	   samples_countPlural   );

			//result.Add(new SampleCount(append, 1));

			result3.add(append);


			return result3;


		}


		static public List<Event> GenDensityFunc3(
			PositiveSample_NotEmptyCollection samples_countPlural
			)
		{

			var freq = GenFrequency(samples_countPlural);

			var count = samples_countPlural.count;

			var result = new List<Event>();

			result.AddRange(
				freq.Select(c => new Event(
					c.sample.val,

					nilnul.num.rational.Rational_InheritFraction.Divide(c.count.val, count
					)))
			);


			return result;

			throw new NotImplementedException();


		}

		static public List<Event> _GenDensityFunc3(
				num.rational.collection.Bag3 samples_nonEmpty
				)
		{

			var freq = GenCounts_prependAppendSpanOnAverage(samples_nonEmpty);

			var count = freq.cardinality;

			var result = new List<Event>();

			result.AddRange(
				freq.Select(c => new Event(
					c.Key,

					nilnul.num.rational.Rational_InheritFraction.Divide(c.Value, count
					)))
			);



			return result;

			throw new NotImplementedException();


		}

		static public List<Event> GenCumulativeDensityFunc(
				PositiveSample_NotEmptyCollection samples_countPlural

		)
		{

			var densityFunc = GenDensityFunc3(samples_countPlural);
			var cumulativeDensity = Prob.Zero;

			for (int i = 1; i < densityFunc.Count(); i++)
			{

				densityFunc[i].probability = new Prob(densityFunc[i].probability.val + densityFunc[i - 1].probability.val);

			}

			return densityFunc;

			throw new NotImplementedException();

		}



		static public List<Event> GenCumulativeDensityFunc(

			num.rational.collection.Bag3 samples_countPlural
//			num.rational.collection.Bag3.Empty.NounAntonym samples_countPlural

		//	NonEmptyCollectionOfPositiveSample samples_countPlural

	)
		{

			var densityFunc = _GenDensityFunc3(samples_countPlural);
			var cumulativeDensity = Prob.Zero;

			for (int i = 1; i < densityFunc.Count(); i++)
			{

				densityFunc[i].probability = new Prob(densityFunc[i].probability.val + densityFunc[i - 1].probability.val);

			}

			return densityFunc;

			throw new NotImplementedException();

		}







		//public ProbabilityInRational density(
		//	nilnul.num.rational.Rational_InheritFraction x
		//) { 




		//}



	}
}
