using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.multivar_.bival.observation.str
{
	static public class _LiftX
	{
		static public double Lift<T>(
			IEnumerable<HashSet<T>> observations
			,
			IEnumerable<T> x
			,IEnumerable< T> y
		) {


			return 
				_ConfidenceX.Confidence(observations,x,y)
				/
				_PortionX.Dbl(observations,y)
			;
		}

	}
}
