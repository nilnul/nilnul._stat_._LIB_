using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._borel.cpf_.contiguous_
{
	/// <summary>
	/// the cardinality of nonderivable points is discrete|leOmega0;
	/// </summary>
	/// <remarks>
	/// as cdf is nondecreasing, it's not free to oscillate. So will it be derivable for almost everywhere as Weirstrass theorem works on oscillating functions only?
	/// </remarks>
	/// "derivative on the right" does not equal the "derivative on the left at discrete number of points
	/// alias:
	///		pd
	///			as in cpd, or continous piecewise derivable
	///			partial derivable
	///	<see cref="nilnul.num.real.convert_.con"/>
	public interface IPiecewiseDerivable
		:
		IContiguous
	{
	}
}
