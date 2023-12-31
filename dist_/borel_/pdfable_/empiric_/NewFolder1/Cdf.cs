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
	/// 
	/// </summary>
	///
	[Obsolete()]
	public class Cdf
		:
		nilnul.prob.rationalProb.rationalSample.Cdf_sortedDict
	{
		private Cdf(List<Event> events)
			: base(events as IEnumerable<Event>)
		{
			nilnul.bit.AssertionNullaryFunc.True(this.First().Value == 0);
		}

		/// <summary>
		/// the min sample:<see cref="nilnul.stat._dist.ISample"/>;
		/// </summary>
		public Rational_InheritFraction min
		{
			get
			{
				return this.First().Key;
			}
		}

		public Rational_InheritFraction max
		{
			get
			{
				return this.Last().Key;
			}
		}


		public Rational_InheritFraction span
		{
			get
			{
				return max - min;
			}
		}

		/// <summary>
		/// partition the scope according to given count of bars; 
		/// this helps draw the pdf;
		/// </summary>
		/// <param name="times"></param>
		/// <returns></returns>
		public SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational> densities(uint times) {
			var r = new SortedDictionary<Rational_InheritFraction, NonNegX.NonNegRational>();
			//nilnul.bit.Assert.True(times >= 0);

			for (int i = 0; i <= times; i++)
			{
				var sample = min + nilnul.num.rational.Rational_InheritFraction.Divide(i, times) * span;
				r.Add(
					sample,
				 	density(sample)
				);
			}
			return r;
		}

		public NonNegX.NonNegRational density(Rational_InheritFraction sample)
		{
			//find the interval.

			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
					(sample),
					this.Keys.Cast<Rational_InheritFraction>().ToList(),
					nilnul.num.rational.order.Comparer.Instance
			);

			if (interval.Item2 == null )
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction. Zero);
			}

			if (interval.Item1 == null)
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction. Zero);

			}
			if ( interval.Item2==0 ) // the index
			{
				return new NonNegX.NonNegRational(Rational_InheritFraction.Zero);
				
			}

			if (interval.Item1==interval.Item2)
			{
				interval = new Tuple<int?, int?>(interval.Item1 - 1, interval.Item2);
			}

			return new NonNegX.NonNegRational(
				(Rational_InheritFraction)(this.ElementAt(interval.Item2.Value).Value -this.ElementAt(interval.Item1.Value).Value)   
				/ 
				(this.ElementAt(interval.Item2.Value).Key - this.ElementAt(interval.Item1.Value).Key)
			);
		}

		/// <summary>
		/// This is in fact is cumulative probability function; 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		///
		[Obsolete("redundant to base type;")]
		public Prob cumulativeDensity(Rational_InheritFraction sample)
		{
			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
					sample
					,
					this.Keys.Cast<Rational_InheritFraction>().ToList()
					,
					nilnul.num.rational.order.Comparer.Instance
			);

			if (interval.Item2 == null)
			{
				return Prob.One;
			}

			if (interval.Item1 == null)
			{
				return Prob.Zero;
			}

			if (interval.Item2 == 0)
			{
				return Prob.Zero;
			}

			return new Prob(this.ElementAt(interval.Item1.Value).Value);

			//return new Prob(this.ElementAt(interval.Item2.Value).Key as Rational_InheritFraction / (this.ElementAt(interval.Item2.Value).Key - this.ElementAt(interval.Item1.Value).Key));
		}

		static public Cdf Create(
			NotNull2<
				num.rational.collection.Bag3.Empty2.NounAntonym

			> samples_countPlural
		) {
			return _Create(samples_countPlural.val.val);
		}

		static public Cdf _Create(
			num.rational.collection.Bag3 samples_notEmpty
		)
		{
			var densityFunc = Pmf._Create(samples_notEmpty);
			var cumulativeDensity = Prob.Zero;

			var events = new List<Event>();
			events.Add(new Event(densityFunc.min,0));

			for (int i = 1; i < densityFunc.sortedList.Count(); i++)
			{
				events.Add( new Event(
					densityFunc.sortedList.ElementAt(i).Key,
					
					new Prob(densityFunc.sortedList.ElementAt(i).Value + events.ElementAt(i - 1).probability)
					)
				);
			}

			return new Cdf(events);
		}
	}
}