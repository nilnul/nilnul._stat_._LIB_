using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival.observation.str
{
	static public class _ConfidenceX
	{
		static public double Confidence<T>(
			IEnumerable<HashSet<T>> observations
			,
			IEnumerable<T> x
			,IEnumerable< T> y
		) {
			var hasX = observations.Where( ob=>ob.IsSupersetOf(x) );

			return  nilnul.num.quotient.to_._dbl._CastOperands.Divide(
				
				hasX.Count(ob =>  ob.IsSupersetOf(y)) ,

				hasX.Count()
				);
		}

	}
}
