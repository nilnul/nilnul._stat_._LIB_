using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.app.select
{


	public partial class SelectMultiple
	{

		static public List<T> SelectByRandomWeight<T>(List<T> x, int n)
		{
			var rnd = new Random();
			var weightedList = new List<Tuple<T, double>>();
			foreach (var item in x)
			{
				weightedList.Add(
					new Tuple<T, double>(item, rnd.NextDouble())
				);

			}

			return weightedList.OrderBy(c => c.Item2).Take(n).Select(d => d.Item1).ToList();
		}

		static public List<T> ByShuffle<T>(List<T> x, int n)
		{

			Shuffle.Eval(x);
			return x.Take(n).ToList();


		}

		static public List<T> ByRecurChoose<T>(List<T> x, int n) {

			if (n==x.Count)
			{
				return x;
				
			}

			var firstChosenOrNot = WeightedChoose.ChooseOrNot((double)n / x.Count);


			if (firstChosenOrNot)
			{
				var tail = ByRecurChoose(x.Skip(1).ToList(), n - 1);
					tail.Add(x.First());
				return tail;
				
			}

			return ByRecurChoose(x.Skip(1).ToList(), n);
		
		}


	}
}
