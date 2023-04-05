using nilnul.num.rational;
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
	public  class Pmf
		: nilnul.prob.rationalProb.rationalSample.Pmf_sortedDict
	{

		private Pmf(List<Event> events)
			: base(events as IEnumerable<Event>)
		{
			//verify this.sortedlist
			//nilnul.bit.Assert.True(	sortedList.First().Value == 0);
			//verify 1/(n+1)

		}

	


		static public Pmf Create(
			num.rational.collection.Bag3 samples
		)
		{
			return Create( new num.rational.collection.Bag3.Empty2.NounAntonym(samples).ToNotNull());
		}

		static public Pmf Create(
			NotNull2<

	num.rational.collection.Bag3.Empty.NounAntonym> samples

	)
		{
			///not null.
			return _Create(samples.val.val);

		}

		static public Pmf Create(
		NotNull2<

num.rational.collection.Bag3.Empty2.NounAntonym> samples

)
		{
			///not null.
			return _Create(samples.val.val);

		}

		static public Pmf _Create(
			num.rational.collection.Bag3.Empty.NounAntonym samples_notNull
		)
		{
			return _Create(samples_notNull.val);
		}


		static public Pmf _Create(
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

			return new Pmf(

				result
			);

			throw new NotImplementedException();

		}


		public Rational_InheritFraction span
		{
			get
			{
				return max - min;
			}
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="times"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public Dictionary<Rational_InheritFraction, NonNegX.NonNegRational> densities(uint times)
		{

			var r = new Dictionary<Rational_InheritFraction, NonNegX.NonNegRational>();
			//nilnul.bit.Assert.True(times >= 0);




			for (int i = 0; i <= times; i++)
			{
				var sample = min + nilnul.num.rational.Rational_InheritFraction.Divide(i, times) * span;

				r.Add(sample, density(sample));

			}

			return r;


			throw new NotImplementedException();


		}


		public SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational> densities_sortedDict(uint times)
		{

			var r = new SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational>(
				nilnul.num.rational.order.Comparer.Instance
			);
			//nilnul.bit.Assert.True(times >= 0);




			for (int i = 0; i <= times; i++)
			{
				var sample = min + nilnul.num.rational.Rational_InheritFraction.Divide(i, times) * span;

				r.Add(sample, density(sample));

			}

			return r;


			throw new NotImplementedException();


		}


		public NonNegX.NonNegRational density(Rational_InheritFraction sample)
		{


			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
					(sample),
					this.sortedList.Keys.Cast<Rational_InheritFraction>().ToList(),
					nilnul.num.rational.order.Comparer.Instance
			);



			if (interval.Item2 == null)
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);

			}

			if (interval.Item1 == null)
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);

			}

			if (interval.Item2 == 0)
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);

			}

			if (interval.Item1 == interval.Item2)
			{
				interval = new Tuple<int?, int?>(interval.Item1 - 1, interval.Item2);


			}


			return new NonNegX.NonNegRational(sortedList.ElementAt(interval.Item2.Value).Key as Rational_InheritFraction / (sortedList.ElementAt(interval.Item2.Value).Key - sortedList.ElementAt(interval.Item1.Value).Key));




			throw new NotImplementedException();



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

			var probSpan = nilnul.num.rational.Rational_InheritFraction.Divide((Rational_InheritFraction)(1), (count + 1));
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

			result3.unionWith(samples_countPlural);

			//result.Add(new SampleCount(append, 1));

			result3.add(append);


			return result3;


		}







	}
}
