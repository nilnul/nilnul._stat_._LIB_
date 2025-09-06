using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_.normal.sample.score_
{
	/// https://ja.wikipedia.org/wiki/%E5%81%8F%E5%B7%AE%E5%80%A4
	///
	/// <summary>
	/// In educational assessment, T-score is a standard score Z shifted and scaled to have a mean of 50 and a standard deviation of 10.
	/// It is also known as hensachi in Japanese, where the concept is much more widely known and used in the context of high school and university admissions
	/// </summary>
	/// <remarks>
	/// </remarks>
	///eg:
	///		顏值

	static public class _TeeX
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
		static public double _TeeScore_0sample_1mean_2deviation(double observed, double mean, double deviation) {
			return 10*(observed - mean) / deviation +50;
		}
	}

  
}
