using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.normal.sample.score_
{
	///en.wikipedia.org/wiki/Standard_score
	///
	///
	/// 
	/// <summary>
	/// the number of standard deviations by which the value of a raw score (i.e., an observed value or data point) is above or below the mean value of what is being observed or measured. Raw scores above the mean have positive standard scores, while those below the mean have negative standard scores.
	/// </summary>
	/// <remarks>
	/// eg:
	///		[-3sigam, +3sigma] contains most values
	/// </remarks>
	/// alias:
	///		standard score
	///		 z-score
	///

	static public class _ZeeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="observed">
		/// alias:
		///		raw score
		/// </param>
		/// <param name="mean"></param>
		/// <param name="deviation"></param>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double _ZeeScore_0sample_1mean_2deviation(double observed, double mean, double deviation) {
			return (observed - mean) / deviation;
		}
	}

    class IZee
    {
    }
}
