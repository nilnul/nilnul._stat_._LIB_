using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_
{
	static public class _ByOccurrenceX
	{
		static public double[] Dist_ofAssumeOccurences(params int[] _occurences_assumeSumIsPositive) {
			var sum = _occurences_assumeSumIsPositive.Sum();
			return _occurences_assumeSumIsPositive.Select(o=> (double)o/sum).ToArray();
		}
	}
}
