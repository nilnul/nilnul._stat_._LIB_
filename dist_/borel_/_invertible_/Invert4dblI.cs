using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_._invertible_
{
	/// <summary>
	/// according to cdf, select one sample;
	///
	/// so the cdf must be strict growing, ranging from 0 to 1;
	/// </summary>
	public  interface Invert4dblI
	{
		/// <summary>
		/// may throw exception, if there is no sample for a probability in the inner of (0,1)
		/// </summary>
		/// <param name="cdf"></param>
		/// <returns></returns>
		double invert(double cdf);

	}
}
