using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival.observation.str
{
	/// <summary>
	/// percentage of the occurences of a set.
	/// </summary>
	static public class _PortionX
	{
		static public double Dbl<T>(
			IEnumerable<HashSet<T>> observations
			,
			IEnumerable<T> x
		) {
			

			return  nilnul.num.quotient.to_._dbl._CastOperands.Divide(
				
				observations.Count(ob =>  ob.IsSupersetOf(x) ) ,

				observations.Count()
				);
		}

	}
}
