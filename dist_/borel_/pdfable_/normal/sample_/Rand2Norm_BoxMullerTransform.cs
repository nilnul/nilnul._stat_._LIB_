using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.real.norm
{
	/// <summary>
	/// Then Z0 and Z1 are independent random variables with a standard normal distribution.
	/// </summary>
	public class Rand2Norm_BoxMullerTransform
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="u1"> (0,1) </param>
		/// <returns></returns>
		static public double ComputateR(double u1) {
			return Math.Sqrt(-2*Math.Log(u1));
		}

		static public double ComputateTheta(double u2) {
			return nilnul.num.real_.TauX.IntoDouble* u2;

		}

		static public double ComputateZ0(double u1,double u2) {

			return ComputateR(u1) * Math.Cos(ComputateTheta(u2));

		}
		static public double ComputateZ1(double u1,double u2) {

			return ComputateR(u1) * Math.Sin(ComputateTheta(u2));

		}


	}
}
