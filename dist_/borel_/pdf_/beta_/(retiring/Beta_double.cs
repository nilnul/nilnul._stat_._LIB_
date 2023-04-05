using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.dist.inst
{
	[Obsolete(nameof(nilnul.stat.dist_.))]
	public  class Beta_double
	{

		/// <summary>
		/// this is the standard beta distribution
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double Density(double a,double b,double x) {
			return nilnul.math.calculus.BetaFunction.Density(x, a, b) / nilnul.math.calculus.BetaFunction.Eval(a, b);
 
			
		}

		static public double Cumulative(double a,double b,double x) {
			return nilnul.math.calculus.BetaFunction.RegularizedIncomplete(a, b, x);
		}

		static public double Density(double a,double b,double min,double max,double x) {


			return  Density(a,b,x)/(max-min);

		
		}
		

	}
}
