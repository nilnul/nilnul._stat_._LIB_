using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.cmf_._bySortedDict.sortedDict
{
	static public class _LastProb2oneX
	{
		static public void LastProb2one(
			ref SortedDictionary<double, double> sortedDictionary
		)
		{
			var last = sortedDictionary.Last();
			if (last.Value != 1)
			{
				sortedDictionary[last.Key] = 1;
			}
		}
		static public void LastProb2one<TSample>(
			ref SortedDictionary<TSample, double> sortedDictionary
		)
		{
			var last = sortedDictionary.Last();
			if (last.Value != 1)
			{
				sortedDictionary[last.Key] = 1;
			}

		}

	}
}
