using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.ral_.tally.op_.conserve_.convex_
{
    class ISoftplus
    {
    }

	/// <summary>
	/// 
	/// </summary>
	/// vs:
	///		<see cref="nilnul.num.real.fn_.IRamp"/> which is a nondecrease function, with a cusp point
	static public class _SoftplusX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		///
		/// </param>
		/// <returns>
		/// 0+ for -inf
		/// ;
		/// +inf for +inf
		/// </returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Softplus(double x) {
			return Math.Log(
				1+ Math.Exp(x)
			);
		}
	}
}
