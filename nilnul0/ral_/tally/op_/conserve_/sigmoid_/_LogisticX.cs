using System;

namespace nilnul.ral_.tally.op_.conserve_.sigmoid_
{

	static public class _LogisticX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// (-inf, +inf)
		/// </param>
		/// <returns>
		/// (0,1)
		///
		/// </returns>
		static public double Sigmoid(double x) {
			return 1 / (1 + Math.Exp(-x));
		}
	}



}
