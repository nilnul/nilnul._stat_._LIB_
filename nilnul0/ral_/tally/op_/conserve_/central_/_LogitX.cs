using System;
using System.Runtime.CompilerServices;

namespace nilnul.ral_.tally.op_.conserve_.central_
{
	static public class _LogitX
	{
		/// <summary>
		///  converts the logarithm of odds into a tally
		/// </summary>
		/// <param name="prob">
		/// (0,1)
		/// 
		/// if it's 0, an exception from ln(0);
		/// if it's 1, an exception from ln(1/0) which is infinity.
		/// </param>
		/// <returns>
		/// (-∞, +∞)
		/// </returns>
		/// inverse of <see cref="sigmoid_.ILogistic"/>
		///
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public double Logit(double prob) {

			/// 
			return Math.Log(prob / (1 - prob));

		}
	}



}
