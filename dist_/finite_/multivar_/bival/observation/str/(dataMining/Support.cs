using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival.observation.str
{
	static public class _SupportX
	{
		static public double Dbl<T>(
			IEnumerable<HashSet<T>> observations
			,
			IEnumerable<T> x
			,
			IEnumerable<T> y
		) {
			

			return  _PortionX.Dbl(observations, x.Concat(y));
		}




	}
}
