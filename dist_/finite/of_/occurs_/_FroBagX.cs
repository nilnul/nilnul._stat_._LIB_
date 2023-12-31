using nilnul.num;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.of_.occurs_
{
	static public class _FroBagX
	{
		
		/// <summary>
		/// use the default order, which is order by hash, thus not explicitly specified.
		/// </summary>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="bag"></param>
		/// <returns></returns>
		static public Dictionary<TKey, nilnul.num.Quotient1> _ProbInQuotient_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag)
		{

			var total = bag.cardinality;
			var dict = new Dictionary<TKey, Quotient1>(
				bag.eq);
			foreach (var item in bag)
			{
				dict.Add(
					item.Key,
				 nilnul.num.Quotient1.CreateByDivide(item.Value, total)
				);

			}

			return dict;
		}



		static public Dictionary<TKey, double> _ProbInDbl_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag)
		{
			var dict = new Dictionary<TKey, double>(bag.eq);
			foreach (var item in _ProbInQuotient_assumeTotalPositive(bag))
			{
				dict.Add(
					item.Key
					,
					nilnul.num.quotient.to_._DblX.ByCastNumDen(item.Value)
					);
			}

			return dict;
		}

		static public Dictionary<TKey, ProbDbl> _ProbInVowedDbl_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag)
		{
			var dict = new Dictionary<TKey, ProbDbl>(bag.eq);
			foreach (var item in _ProbInQuotient_assumeTotalPositive(bag))
			{
				dict.Add(
					item.Key
					,
					new ProbDbl(
					nilnul.num.quotient.to_._DblX.ByCastNumDen(item.Value)
					)
				);
			}

			return dict;
		}


	}
}
