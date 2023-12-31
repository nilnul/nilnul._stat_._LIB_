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
using nilnul.enumerable.b;

namespace nilnul.prob.rationalMeasure.empirical
{
	/// <summary>
	/// ordered by sample.
	/// prepended with zero.
	/// all positives (multiplicity of 1/(n+1)) in between.
	/// appended with 1/(n+1)
	/// 
	/// </summary>
	///

	[Obsolete()]
	public class Pmf
		: nilnul.prob.rationalProb.rationalSample.Pmf_sortedDict
	{

		private Pmf(List<Event> events)
			: base(
				  events as IEnumerable<Event>
				)
		{
			//verify this.sortedlist
			//nilnul.bit.Assert.True(	sortedList.First().Value == 0);
			//verify 1/(n+1)
		}

		static public Pmf Create(
			num.rational.collection.Bag3 samples
		)
		{
			return Create(new num.rational.collection.Bag3.Empty2.NounAntonym(samples).ToNotNull());
		}

		static public Pmf Create(
			NotNull2<
				num.rational.collection.Bag3.Empty.NounAntonym
			> samples
		)
		{
			///not null.
			return _Create(samples.val.val);
		}

		static public Pmf Create(
			NotNull2<
				num.rational.collection.Bag3.Empty2.NounAntonym
			> samples
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

		/// <summary>
		/// assuming that occurences have positive count;
		/// smoothing the outlier extrem points by prepending a point of nil prob and appending a point with 1/(n+1) prob;
		/// </summary>
		/// <param name="samples_nonEmpty"></param>
		/// <returns></returns>

		static public Pmf _Create(
			num.rational.collection.Bag3 samples_nonEmpty
		)
		{
			var freq = GenCounts_prependAppendSpanOnAverage(samples_nonEmpty);

			var count = freq.Values.Sum();

			var result = new List<Event>();

			result.AddRange(
				freq.Select(c => new Event(
					new NotNull2<Rational_InheritFraction>(
						new Rational_InheritFraction(
							c.Key.numerator
							,
							c.Key._denominator.eeByRef
						)
					)
					,
					nilnul.num.rational.Rational_InheritFraction.Divide(
						(BigInteger)c.Value, (BigInteger)count
					)))
			);

			return new Pmf(

				result
			);
			//throw new NotImplementedException();
		}


		public Rational_InheritFraction span
		{
			get
			{
				return max - min;
			}
		}


		/// <summary>
		/// partition the scope evenly, and get the density for each point.
		/// This helps draw the plot of the pdf.
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
		}

		/// <summary>
		/// partition the scope evenly, and get the density for each point.
		/// This helps draw the plot of the pdf.
		/// </summary>
		/// <param name="times"></param>
		/// <returns></returns>
		public SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational> densities_sortedDict(uint times)
		{

			var r = new SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational>(
				nilnul.num.rational.order.Comparer.Instance
			);

			for (int i = 0; i <= times; i++)
			{
				var sample = min + nilnul.num.rational.Rational_InheritFraction.Divide(i, times) * span;
				r.Add(sample, density(sample));
			}
			return r;
		}

		/// <summary>
		/// get the density by calculating: prob / span;
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		public NonNegX.NonNegRational density(Rational_InheritFraction sample)
		{
			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
					sample,
					this.sortedList.Keys.Cast<Rational_InheritFraction>().ToList()
					,
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

			if (interval.Item2 == 0)	// this is the index
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);
			}

			if (interval.Item1 == interval.Item2)
			{
				interval = new Tuple<int?, int?>(interval.Item1 - 1, interval.Item2);
			}

			return new NonNegX.NonNegRational(
				sortedList.ElementAt(interval.Item2.Value).Value as Rational_InheritFraction	/// the prob incremented;
				/
				(
					sortedList.ElementAt(interval.Item2.Value).Key - sortedList.ElementAt(interval.Item1.Value).Key
				)
			);

			//throw new NotImplementedException();
		}

		[Obsolete(
			nameof(stat.dist_.borel_.pdfable_.empiric.of_.occurs_._ByAppendX._AsNil4first_byPrependAppendSpanOnAverage_0packed)
		)]
		static public Dictionary<num.quotient_.DenomNonnil, int> GenCounts_prependAppendSpanOnAverage(
			num.rational.collection.Bag3 samples_countPlural
		)
		{
			return stat.dist_.borel_.pdfable_.empiric.of_.occurs_._ByAppendX._AsNil4first_byPrependAppendSpanOnAverage_0packed(
				samples_countPlural
			);
		}
	}
}