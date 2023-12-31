using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;
using nilnul.num.rational;
using nilnul.stat.dist_.finite_.quotient2quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.quotient_.DenomNonnil;//.Rational_InheritFraction;

namespace nilnul.stat.dist_.finite_.cmf_.quotient2quotient_
{
	/// <summary>
	/// the first sample's prob can be nil.
	/// </summary>
	public class CpfBySortedDict
		:
		SortedDictionary<R, stat._dist.Prob8quotient1>
		,
		dist_._cpfable_.Cpf4quotientI
	{
		/// <summary>
		/// this is private, and only called by other ctor;
		/// </summary>
		private CpfBySortedDict()
			: base(nilnul.num.quotient_.denomNonnil.Comp.Singleton)
		{
		}

		public CpfBySortedDict(NotNull2<nilnul.collection.sequence.Empty<stat._dist.propense_.Quotient8quotient>.AdjToNoun.NounAntonym> events)
			: this()
		{
			_set(events.val.val);
		}

		
		public CpfBySortedDict(
			IEnumerable<stat._dist.propense_.Quotient8quotient> events
		)
		: this(
			new nilnul.collection.sequence.Empty<stat._dist.propense_.Quotient8quotient>.AdjToNoun.NounAntonym(
				events

			).ToNotNull()
		)
		{
		}

		public CpfBySortedDict(
			IEnumerable<(num.quotient_.DenomNonnil,num.quotient_.DenomNonnil)> events_notEmpty
		):this()
		{
			nilnul.bit.AssertionNullaryFunc.True(
				nilnul.obj.str.be_.monotone_.le_.CompDefault<DenomNonnilI, nilnul.num.quotient_.denomNonnil.Comp >.Unison.be(
					events_notEmpty.Select(
						p=>				p.Item2
						
					)	//.Cast<DenomNonnilI>()
				)
			); // we use gt, not ge, as the vista of 0 chances wouldnot occur.

			nilnul.bit.AssertionNullaryFunc.True(events_notEmpty.Last().Item2 == 1);

			foreach (var item in events_notEmpty)
			{
				Add(item.Item1, new _dist.Prob8quotient1( item.Item2) );
			}
		}

		public CpfBySortedDict(SortedDictionary<R, R> sortedDictionary)
			:this(
				 sortedDictionary.Select(x=>(x.Key,x.Value))
			)
		{
		}

		private void _set(
			IEnumerable<(num.quotient_.DenomNonnil,num.quotient_.DenomNonnil)> events_notEmpty

		)
		{
			nilnul.bit.AssertionNullaryFunc.True(
				nilnul.obj.str.be_.monotone_.gt_.CompDefault<DenomNonnilI, nilnul.num.quotient_.denomNonnil.Comp >.Unison.be(
					events_notEmpty.Select(
						p=>				p.Item2
						
					)	//.Cast<DenomNonnilI>()
				)
			); // we use gt, not ge, as the vista of 0 chances wouldnot occur.

			nilnul.bit.AssertionNullaryFunc.True(events_notEmpty.Last().Item2 == 1);

			foreach (var item in events_notEmpty)
			{
				Add(item.Item1, new _dist.Prob8quotient1( item.Item2) );
			}
		}

		private void _set(
			IEnumerable<stat._dist.propense_.Quotient8quotient> events_notEmpty

		)
		{
			nilnul.bit.AssertionNullaryFunc.True(
				nilnul.obj.str.be_.monotone_.gt_.CompDefault<DenomNonnilI, nilnul.num.quotient_.denomNonnil.Comp >.Unison.be(
					events_notEmpty.Select(
						p=>
						nilnul.num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(
							p.probabilityNotNull.en
						)
					)	//.Cast<DenomNonnilI>()
				)
			); // we use gt, not ge, as the vista of 0 chances wouldnot occur.

			nilnul.bit.AssertionNullaryFunc.True(events_notEmpty.Last().probabilityNotNull.en == 1);

			foreach (var item in events_notEmpty)
			{
				Add(item.sample, new _dist.Prob8quotient1( item.probabilityNotNull ));
			}
		}

		public stat.dist_.finite_.quotient2quotient_.PmfBySortedDict getPmf()
		{
			List<stat._dist.propense_.Quotient8quotient> events = new List<stat._dist.propense_.Quotient8quotient>();

			events.Add(new stat._dist.propense_.Quotient8quotient(min, this.First().Value.eeByRef));

			for (int i = 1; i < Count; i++)
			{
				var p = this.ElementAt(i).Value.eeByRef.ToImpl() - this.ElementAt(i - 1).Value.eeByRef;

				events.Add(
					new stat._dist.propense_.Quotient8quotient(
						this.ElementAt(i).Key
						,
						p
						
					)
				);
			}
			return new stat.dist_.finite_.quotient2quotient_.PmfBySortedDict(
				events as IEnumerable<stat._dist.propense_.Quotient8quotient>
			);
		}

		public R mean
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

		public R min
		{
			get
			{
				return this.First().Key;
			}
		}

		public R max
		{
			get
			{
				return this.Last().Key;
			}
		}


		public R span
		{
			get
			{
				return max - min;
			}
		}

		/// <summary>
		/// this is cmf function. the point in between two samples carries no probability|measure;
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		public num.quotient_.DenomNonnil cumulatedProb(R sample)
		{
			var interval = nilnul.obj.str_.sorted._SearchX._BinarySearch_1sorted<R>(
					nilnul.num.quotient_.denomNonnil.Comp.Singleton
					,
					this.Keys.Cast<R>().ToList()
					,
					sample
			);

			if (interval.Item2 == null)
			{
				return DenomNonnil.One;
			}

			if (interval.Item1 == null)
			{
				return DenomNonnil.Nil;

			}

			if (interval.Item2 == 0) // this is the index.
			{
				return DenomNonnil.Nil;
			}

			return this.ElementAt(interval.Item1.Value).Value.eeByRef.ToImpl();

		}
		public stat._dist.Prob8quotient1 cpf4prob(R sample)
		{
			var interval = nilnul.obj.str_.sorted._SearchX._BinarySearch_1sorted<R>(
					nilnul.num.quotient_.denomNonnil.Comp.Singleton
					,
					this.Keys.Cast<R>().ToList()
					,
					sample
			);

			if (interval.Item2 == null)
			{
				return stat._dist.Prob8quotient1.One;
			}

			if (interval.Item1 == null)
			{
				return stat._dist.Prob8quotient1.Nil;

			}

			if (interval.Item2 == 0) // this is the index.
			{
				return stat._dist.Prob8quotient1.Nil;
			}

			return (this.ElementAt(interval.Item1.Value).Value);

		}

	}
}