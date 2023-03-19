using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel.sample
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		drift
	///			shift
	static public class _DriftX
	{
		static public double Drift_1mean(double x, double mean) {
			return (x - mean);
		}
	}
}
