using nilnul.obj.str;
using nilnul.rel_.dict;
using nilnul.stat._dist_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite.of_
{
	static public class _OfOccursX
	{
		static public Dictionary<TSample, ProbDbl> _AsDict4prob_0occurs<TSample>( Dictionary<TSample, int> bag)
		{
			var total = bag.Values.Cast<int>().Sum();//.Select(kv=>kv.Value)
			var probs = new Dictionary<TSample, ProbDbl>( bag.Comparer);

			double totalDbl = total;

			bag.Each(
				kv=> probs.Add(kv.Key, new ProbDbl( kv.Value / totalDbl ) )
			);

			return probs;
		}

		static public Dictionary<TSample, double> _AsDict4dbl_0occurs<TSample>( Dictionary<TSample, int> bag)
		{
			var total =(double) bag.Values.Cast<int>().Sum();//.Select(kv=>kv.Value)
			var probs = new Dictionary<TSample, double>( bag.Comparer);

			//double totalDbl = total;

			bag.Each(
				kv=> probs.Add(kv.Key,  kv.Value / total)
			);

			return probs;
		}
	}
}