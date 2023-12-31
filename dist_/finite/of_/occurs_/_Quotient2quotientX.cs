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
using nilnul.prob.finite;
using nilnul.num.quotient_;

namespace nilnul.stat.dist_.finite.of_.occurs_
{

	/// <summary>
	/// for quotient prob, and quotient sample;
	/// </summary>
	static public class _Quotient2quotientX
	{

		static public finite_.quotient2quotient_.PmfBySortedDict Of(
			List<stat._dist.propense_.Quotient8quotient> events
		)
		{
			return new finite_.quotient2quotient_.PmfBySortedDict(
				( IEnumerable<stat._dist.propense_.Quotient8quotient> )events 
			);
		}

		//static public finite_.quotient2quotient_.PmfBySortedDict Of(
		//	num.rational.collection.Bag3 samples
		//)
		//{
		//	return Of(new num.rational.collection.Bag3.Empty2.NounAntonym(samples).ToNotNull());
		//}

		static public finite_.quotient2quotient_.PmfBySortedDict Of(
			NotNull2<
				num.rational.collection.Bag3.Empty.NounAntonym
			> samples
		)
		{
			///not null.
			return Of(samples.val.val);
		}

		static public finite_.quotient2quotient_.PmfBySortedDict Of(
			NotNull2<
				num.rational.collection.Bag3.Empty2.NounAntonym
			> samples
		)
		{
			///not null.
			return Of(samples.val.val);
		}

		//static public finite_.quotient2quotient_.PmfBySortedDict Of(
		//	num.rational.collection.Bag3.Empty.NounAntonym samples_notNull
		//)
		//{
		//	return Of(samples_notNull.val);
		//}

		public static finite_.quotient2quotient_.PmfBySortedDict Of(Dictionary<DenomNonnil, int> dictionary)
		{

			var count = dictionary.Values.Sum();

			var result = new List<stat._dist.propense_.Quotient8quotient>();

			result.AddRange(
				dictionary.Select(c =>
					new stat._dist.propense_.Quotient8quotient	(
						c.Key
						,
						new nilnul.num.quotient_.DenomNonnil(
							c.Value, count
						)
					)
				)
			);

			return new nilnul.stat.dist_.finite_.quotient2quotient_.PmfBySortedDict(

				result
			);

		}

		static public finite_.quotient2quotient_.PmfBySortedDict Of(
			num.rational.collection.Bag3 samples_nonEmpty
		)
		{
			var freq = (samples_nonEmpty);

			var count = freq.cardinality;

			var result = new List<stat._dist.propense_.Quotient8quotient>();

			result.AddRange(
				freq.Select(c => new stat._dist.propense_.Quotient8quotient(
					new nilnul.num.quotient_.DenomNonnil(
						c.Key.numerator1,
						c.Key.denominatorAsBigInt
					)
					,
					new nilnul.num.quotient_.DenomNonnil(
						c.Value, count
					))
				)
			);

			return new nilnul.stat.dist_.finite_.quotient2quotient_.PmfBySortedDict(

				result
			);
			//throw new NotImplementedException();
		}

	}
}