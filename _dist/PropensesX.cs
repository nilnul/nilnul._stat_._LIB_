using nilnul.obj.str;
using nilnul.rel_.dict;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat._dist
{
	static public class PropensesX 
	{
		static public Dictionary<TSample, ProbDbl> ToDict4oldProb<TSample>(this Dictionary<TSample, double> dict)
		{
			var r = new Dictionary<TSample, ProbDbl>();
			r.AddRange(
				dict.Select(
					x => (x.Key, new ProbDbl(x.Value))
				)
			);
			return r;
		}
		static public Dictionary<TSample, Prob4dbl> ToDict4prob<TSample>(this Dictionary<TSample, double> dict)
		{
			var r = new Dictionary<TSample, Prob4dbl>();
			r.AddRange(
				dict.Select(
					x => (x.Key, new Prob4dbl(x.Value))
				)
			);
			return r;
		}
		static public SortedDictionary<TSample, Prob4dbl> ToDict4prob<TSample>(this SortedDictionary<TSample, double> dict)
		{
			var r = new SortedDictionary<TSample, Prob4dbl>();
			dict.Each( a=>r.Add(a.Key,new Prob4dbl( a.Value)));
			return r;
		}

		static public Dictionary<TSample, ProbDbl> ToDict4prob<TSample>(
				IEqualityComparer<TSample> eq
				,
				IEnumerable<KeyValuePair<TSample, ProbDbl>> enumerable
			)
		{
			var r = new Dictionary<TSample, ProbDbl>(eq);
			nilnul.rel_.dict._ExtensionsX.AddRange(
				r,
				enumerable
			);
			return r;
		}

	}
}
