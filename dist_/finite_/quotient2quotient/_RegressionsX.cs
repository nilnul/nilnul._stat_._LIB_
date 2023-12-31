using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.quotient2quotient
{
	/// <summary>
	/// 
	/// </summary>
	/// 
	static public class _RegressionsX
	{
		static public quotient2quotient_.PmfBySortedDict PmfBySortedDict(
			 nilnul.prob.rationalProb.rationalSample.Pmf_sortedDict pmf_SortedDict
		) {
			return new quotient2quotient_.PmfBySortedDict(
				pmf_SortedDict.sortedList.Select(
					attr =>(
						nilnul.num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(
							attr.Key
						)
						,
						nilnul.num.quotient_.denomNonnil._RegressionsX.ToDenomNonnil(
							attr.Value
						)
					)
				)
			);
		}
	}
}
