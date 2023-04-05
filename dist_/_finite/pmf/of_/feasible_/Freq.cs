using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite
{
	static public class _FroOccursX
	{
		static public IEnumerable<nilnul.num.Quotient1> _Quotients_assumeTotalPositive( IEnumerable<nilnul.Num1> bag ) {

			var sum = nilnul.num.accumulate_._SumX.Eval1(bag);

			return bag.Select(
				x=> nilnul.num.Quotient1.CreateByDivide(x, sum )
			);

		}

		static public IEnumerable<double> _Dbls_assumeTotalPositive<TKey>( IEnumerable<nilnul.Num1> bag ) {
			return _Quotients_assumeTotalPositive(bag).Select(q=>nilnul.num.quotient.to_._DblX.ByCastNumDen(q) );

		}


		static public IEnumerable<nilnul.num.Quotient1> _Quotients_assumeTotalPositive<TKey>(IEnumerable<KeyValuePair<TKey, nilnul.Num1>>
			bag) {

			return _Quotients_assumeTotalPositive(_finite.occurs._FroBagX._Nums_assumeTotalPositive(bag) );

		}
		static public IEnumerable<nilnul.num.Quotient1> _Quotients_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag)
		{

			return _Quotients_assumeTotalPositive((IEnumerable<KeyValuePair<TKey, nilnul.Num1>>)(bag));
		}



		static public IEnumerable<nilnul.num.Quotient1> _Quotients_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag, IComparer<TKey> order)
		{

			return _Quotients_assumeTotalPositive(
				(bag).OrderBy(x => x.Key, order)
			);
		}


		static public IEnumerable<double> _Dbls_assumeTotalPositive<TKey>(IEnumerable<KeyValuePair<TKey, nilnul.Num1>>
			bag
			) {
			return _Quotients_assumeTotalPositive(bag).Select(q => nilnul.num.quotient.to_._DblX.ByCastNumDen(q));

		}


		static public IEnumerable<double> _Dbls_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag)
		{

			return _Quotients_assumeTotalPositive(bag).Select(q => nilnul.num.quotient.to_._DblX.ByCastNumDen(q));;
		}



		static public IEnumerable<double> _Dbls_assumeTotalPositive<TKey>(nilnul.obj.Bag1<TKey> bag, IComparer<TKey> order)
		{

			return _Quotients_assumeTotalPositive(
				(bag),order
			).Select(q => nilnul.num.quotient.to_._DblX.ByCastNumDen(q));;
		}




	}
}
