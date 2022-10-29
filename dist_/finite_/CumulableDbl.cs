using nilnul.num.rational;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.finite_
{
	static public  class _CumulableDblX
	{

		static public SortedDictionary<double, ProbDbl> Cumulate(
			nilnul.stat.dist_.FiniteDbl finiateDbl
		) {
			var r = new SortedDictionary<double, ProbDbl>();
			var totalProb = 0d;
			foreach (var item in finiateDbl.OrderBy(kv=>kv.Key))
			{
				totalProb += item.Value;

				r.Add(item.Key,new ProbDbl( totalProb) );

			}


			return r;

			
		}
	

	}



}
