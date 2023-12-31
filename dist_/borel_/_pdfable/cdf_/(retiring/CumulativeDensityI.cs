using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx = nilnul.num.RealI;

namespace nilnul.prob_._continuum_
{
	public interface CumulativeDensityI
	{
		Rx cumulativeDensity(Rx x);
	}
}
