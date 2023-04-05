using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample
{
	public partial interface CdfInverseI
		
	{
		
		/// <summary>
		/// binary search can be used.
		/// </summary>
		/// <param name="prob"></param>
		/// <returns></returns>
		double inverse(Prob prob);



	}
}
