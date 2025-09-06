using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel.of_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _DriftX
	{
		/// <summary>
		/// transform the random variable;
		/// </summary>
		/// <param name="mean"></param>
		/// <param name="rv"></param>
		/// <returns></returns>
		static public double _Of_0mean(double mean, double rv) {
			return rv - mean;
		}
	}
}
