using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob
{
	/// <summary>
	/// this is the supertype of all kinds of distributions (be it )
	/// </summary>
	///
	[Obsolete()]
	public interface DistributionI
	{

		double inverseCdf(double probability);
		double inverseCdf();
		


	}
}
