using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx = nilnul.num.Real;

namespace nilnul.prob._continuum_
{
	public interface CdfI
	{
		Rx cdf(Rx x);
	}
}
