using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nilnul.stat.dist_.borel_.pdf_.normal_
{

	/// <summary>
	/// standard Normal Distribution
	/// </summary>
	static public class _StdX
	{

		public static double Density(double x){

			return	Math.Exp(
					-x*x
					/
					2
				)
				/
				Math.Sqrt(num.real_._Tau4dblX.FULL )

			;
		}

		//static public double _Cdf_0finite(double x) {
		//	return (1+ num.real.ext.func_.unary_.Erf4dbl.) / 2;
		//}

		
	}//class

}//namespace
