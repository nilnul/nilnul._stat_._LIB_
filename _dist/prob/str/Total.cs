using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist.probs
{
	public class _TotalX
	{
		static public double Dbl(IEnumerable<Prob4dbl> probs) {
			return probs.Select(p => p._val).Sum();
		}
	}
}
