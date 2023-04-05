using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_._borel_
{

	public partial interface Cdf4dblI
		:ICdf
		
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="upperBound"></param>
		/// <returns>
		/// p(t<=x)
		/// </returns>
		double cdf(double upperBound);


		



	}
}
