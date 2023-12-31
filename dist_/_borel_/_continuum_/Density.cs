using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx = nilnul.num.RealIX;

namespace nilnul.prob._continuum_
{
	[Obsolete()]
	public interface DensityI
	{
		Rx density(Rx x);
	}
}
