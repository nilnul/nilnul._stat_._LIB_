using nilnul.num;
using nilnul.obj.str;
using nilnul.stat._dist;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_.cmf_._binomial
{
	/// <summary>
	/// </summary>
	static public class _Cmf4fracX
		
	{
		

		static public SortedDictionary<uint, Prob8frac> SortedDict(
SortedDictionary<uint, nilnul.num.Quotient1> val
		) {
			var r = new SortedDictionary<uint, Prob8frac>(

			);
			val.Each(
				X=> r.Add( X.Key, new Prob8frac(X.Value) )
			);
			return r;
		}
		static public SortedDictionary<uint, Prob8frac> SortedDict(
SortedDictionary<uint, double> val
		) {
			var r = new SortedDictionary<uint, Prob8frac>(

			);
			val.Each(
				X=> r.Add( X.Key, new Prob8frac(X.Value) )
			);
			return r;
		}


		
	}


}
