using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival.observation.str
{
	static public class _ConvictionX
	{
		static public double Dbl<T>(
			IEnumerable<HashSet<T>> observations
			,
			IEnumerable<T> x
			,IEnumerable< T> y
		) {
			return 1 - _PortionX.Dbl(observations, y) / (1 - _ConfidenceX.Confidence(observations, x, y));
		}

	}
}
