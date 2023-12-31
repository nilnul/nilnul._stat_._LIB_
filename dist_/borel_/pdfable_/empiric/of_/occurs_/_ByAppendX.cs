using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.num.natural.Natural_bigInteger;


namespace nilnul.stat.dist_.borel_.pdfable_.empiric.of_.occurs_
{
	/// <summary>
	/// append additional sample such that later we can compute inner points using a small neighborhood;
	/// </summary>
	/// <remarks>
	/// take each point as the center of a betwixt, and extrapolate the two outer points at a distance of 1/(n+1);
	/// 
	/// </remarks>
	static public class _ByAppendX
	{
		/// <summary>
		/// prepend a sample offset -1/(n+1)/2 of probability 0
		/// append a sample offset 1/(n+1)/2 of probability 1/(n+1).
		/// </summary>
		/// <remarks>
		/// due to the characteristics of CDF, this will make the CDF-generated PMF distribution to be:
		///		( 1/(n+1), 1/(n+1), ... , 1/(n+1), 1/(n+1) )
		/// </remarks>
		/// <param name="samples_countPlural">
		/// not ordered. there are at least two els;each occurs at least once;
		/// eg:
		///		(1:3, 2:0, 5:1)
		/// </param>
		/// <returns>
		/// eg:
		///		( 1-4/3:0,   1:3, 2:0, 5:1,   5+4/3: 1 )
		/// </returns>
		static public Dictionary<num.quotient_.DenomNonnil, int> _AsNil4first_byPrependAppendSpanOnAverage_0packed(
			num.rational.collection.Bag3 samples_countPlural
		)
		{
			//append a sample
			var count = samples_countPlural.cardinality; //eg: 3+0+1=4;

			var maxSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.Key > a.Key ? c : a).Key;        /// eg:5
			var minSample = samples_countPlural.Aggregate(samples_countPlural.First(), (a, c) => c.Key < a.Key ? c : a).Key;       /// eg: 1

																																   /// 1(n+1)
			//var prob4EachSpan = nilnul.num.rational.Rational_InheritFraction.Divide((Rational_InheritFraction)(1), (count + 1)); // eg: 1/5
			var countMinus = count - 1; //eg: 3

			var sampleSpan = maxSample - minSample; //eg: 4

			var avgSpan = nilnul.num.rational.Rational_InheritFraction.Divide(sampleSpan, countMinus);  //eg: 4/3

			var append = maxSample + avgSpan;   // 5+4/3
			var prepend = minSample - avgSpan;  // 1-4/3


			var result3 = new Dictionary<nilnul.num.quotient_.DenomNonnil, int>(
				nilnul.num.quotient.Eq2.Singleton
			); 

			result3.Add(
				new nilnul.num.quotient_.DenomNonnil(
					prepend.numerator
					,
					prepend.denominator
				)
				,
				0
			);  /// eg: (-1/3:0,  1:3, 2:0, 5:1, 6+1/3: 1)

			//todo: add all

			samples_countPlural.Each(
				s => {
					result3.Add(
						new num.quotient_.DenomNonnil(
							s.Key.numerator1
							,
							s.Key.denominatorAsBigInt
						)
						,
						(int)s.Value.val
					);
				}
			);

			/// eg: (-1/3:0,    1:3, 2:0, 5:1,   6+1/3: 1)
			///

			/// we need the cpf to be invertible upon the scope. so, no horizontal lineSeg|grad is allowed;

			//result3.Add(
			//			new num.quotient_.DenomNonnil(
			//				append.numerator1
			//				,
			//				append.denominatorAsBigInt
			//			)
			//			,
			//			1
			//);/// eg: (-1/3:0,   1:3, 2:0, 5:1,   6+1/3: 1)

			return result3;
		}

		static public finite_.quotient2quotient_.PmfBySortedDict ToPmf(num.rational.collection.Bag3 samples_countPlural) {

			return nilnul.stat.dist_.finite.of_.occurs_._Quotient2quotientX.Of(
				_AsNil4first_byPrependAppendSpanOnAverage_0packed(samples_countPlural)
			);
		}
		static public finite_.cmf_.quotient2quotient_.CpfBySortedDict AsCpf(num.rational.collection.Bag3 samples_countPlural) {

			return  stat.dist_.finite_.cmf_.quotient2quotient.of_._OfPmfX.AsCpf(
				ToPmf(
					samples_countPlural
				)
			);
		}

		static public Empirical4quotient ToEmpiric(
			num.rational.collection.Bag3 samples_countPlural
		) {
			return _OfPmfX.ToEmpiric(
				 ToPmf(
					
						samples_countPlural
					
				)
			);
		}

	}
}
