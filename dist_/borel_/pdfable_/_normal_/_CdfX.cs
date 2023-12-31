using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdf_._normal_
{
	static public class _CdfX
		
	{

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		static public  double _Cdf_01finite_2extNonneg(double mean, double divergence, double par)
		{
			return  normal_._std_.Cdf4dbl.Singleton._op_0extNonneg(
				nilnul.num.real.of_.unary_._StdX._Standize_0anchor_1vessel(mean,divergence,par)
				/// Math.Sqrt(2) // already done in <see cref="normal_._std_.Cdf4dbl.Singleton._op_0extNonneg"/>
			);
			
		}

		

	}
}
