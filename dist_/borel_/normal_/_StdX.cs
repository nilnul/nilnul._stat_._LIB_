using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nilnul.stat.dist_.borel_.normal_
{

	/// <summary>
	/// standard Normal Distribution
	/// </summary>
	static public class _StdX
	{

		public static double Density(double x){

			return	Math.Exp(
					-Math.Pow(
						x  
						,
						2
					)/2
				)
				/
				Math.Sqrt(2 * Math.PI )

			;
		}
		
	}//class

}//namespace
