using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel.cdf_
{
	/// <summary>
	/// this is different from <see cref="nilnul.num.real.func_.unary_.IInversible"/>, as for this, it might be:
	///		- an invertible funciton
	///		- or invertible in a bound, outside of which the measure is zero; thus, for cdf = 1, the sample is a single point, and for cdf =0, the sample is a single point as well; So this boils down to a function of density boundaried, outside which the density is 0;
	/// </summary>
	public interface IInversible
	{
	}
}
