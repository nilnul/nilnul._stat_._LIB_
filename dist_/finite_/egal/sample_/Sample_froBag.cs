using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite.measures
{
	public partial class Sample_froBagOfIntMeasure
	{
		static public T RandomSelect<T>(
			nilnul.num.natural.bag.be.Empty<T>.Not.Asserted bag_cardinalityInt) {

			var r = new Random();
			var totalWeight = (int) bag_cardinalityInt.val.cardinality.val;

			var randomIndex = r.Next(totalWeight);

			var measureTotal = 0;

			foreach (var item in bag_cardinalityInt.val)
			{

				measureTotal +=(int) item.Value.val;
				if (randomIndex < measureTotal)
				{
					return item.Key;

				}
			}






			throw new NotImplementedException();
		
		}

		static public int RandomSelect(IEnumerable<int> bag) {
			
			var r = new Random();
			r = nilnul.prob.RandomX.random;
			var totalWeight = (int) bag.Sum();
			var randomReach = r.Next(totalWeight);

			var measureUpTo = 0;

			for (int i = 0; i < bag.Count(); i++)
			{
				measureUpTo += bag.ElementAt(i);
				if (randomReach < measureUpTo)
				{
					return i;

				}

				
			}

			throw new UnexpectedReachException();


		}
	}
}
