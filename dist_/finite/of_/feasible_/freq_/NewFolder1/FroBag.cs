using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._finite.occurs
{
	static public class _FroBagX
	{
		/// <summary>
		/// the order is preserved, ensuring sample points are converted to index
		/// </summary>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="bag"></param>
		/// <returns></returns>
		static public IEnumerable<nilnul.Num1> _Nums_assumeTotalPositive<TKey>(
			IEnumerable<KeyValuePair<TKey, nilnul.Num1>>
			bag
		) {

			return bag.Select(x => x.Value);
		}
		/// <summary>
		/// use the default order, which is order by hash, thus not explicitly specified.
		/// </summary>
		/// <typeparam name="TKey"></typeparam>
		/// <param name="bag"></param>
		/// <returns></returns>
		static public IEnumerable<nilnul.Num1> _Nums_assumeTotalPositive<TKey>( nilnul.obj.Bag1<TKey> bag ) {

			return _Nums_assumeTotalPositive( (IEnumerable<KeyValuePair<TKey, nilnul.Num1>>) (bag));
		}



		static public IEnumerable<nilnul.Num1> _Nums_assumeTotalPositive<TKey>( nilnul.obj.Bag1<TKey> bag, IComparer<TKey> order ) {

			return _Nums_assumeTotalPositive(
				(bag).OrderBy(x=> x.Key, order)
			);
		}



	}
}
