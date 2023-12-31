using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalProb.rationalSample
{
	[Obsolete(nameof(stat.dist_.finite_.cmf_.quotient2quotient_.CpfBySortedDict))]
	public class Cdf_sortedDict
		:
		SortedDictionary<R, Prob>
	{
		/// <summary>
		/// this is private, and only called by other ctor;
		/// </summary>
		private Cdf_sortedDict()
			: base(nilnul.num.rational.order.Comparer.Instance)
		{
		}

		public Cdf_sortedDict(
			IEnumerable<Event> events
		)
		: this(
			new nilnul.collection.sequence.Empty<Event>.AdjToNoun.NounAntonym(
				events

			).ToNotNull()
		)
		{
		}


		public Cdf_sortedDict(NotNull2<nilnul.collection.sequence.Empty<Event>.AdjToNoun.NounAntonym> events)
			: this()
		{
			_set(events.val.val);
		}

		private void _set(
			IEnumerable<Event> events_notEmpty

		)
		{
			foreach (var item in events_notEmpty)
			{
				Add(item.sample, item.probabilityNotNull);

			}

			nilnul.bit.AssertionNullaryFunc.True(
				nilnul.order.total.Path<R>._BeStrict(this.Values, nilnul.num.rational.order.Comparer.Instance)
			); // as the vista of 0 chances wouldnot occur.

			nilnul.bit.AssertionNullaryFunc.True(this.Last().Value == 1);
		}

		public Pmf_sortedDict getPmf()
		{
			List<Event> events = new List<Event>();
			events.Add(new Event(min, this.First().Value));
			for (int i = 1; i < Count; i++)
			{
				events.Add(
					new Event(
						this.ElementAt(i).Key
						,
						this.ElementAt(i).Value - this.ElementAt(i - 1).Value
					)
				);
			}
			return new Pmf_sortedDict(events as IEnumerable<Event>);
		}

		public Rational_InheritFraction mean
		{
			get
			{
				return getPmf().mean;
			}
		}

		public double meanInDouble
		{
			get
			{
				return getPmf().meanInDouble;
			}
		}

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
		/// this is in fact the cpf;
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		public Prob cumulativeDensity(Rational_InheritFraction sample)
		{
			var interval = nilnul.interval.BinarySearchX.BinarySearchX_ListBiSearch_index<Rational_InheritFraction>(
				(sample)
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

			if (interval.Item2 == 0) // this is the index.
			{
				return Prob.Zero;
			}

			return new Prob(this.ElementAt(interval.Item1.Value).Value);

			//return new Prob(this.ElementAt(interval.Item2.Value).Key as Rational_InheritFraction / (this.ElementAt(interval.Item2.Value).Key - this.ElementAt(interval.Item1.Value).Key));
			//throw new NotImplementedException();
		}
	}
}