using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample
{
	public partial interface CdfInverseI
		
	{
		
		/// <summary>
		/// binary search can be used.
		/// </summary>
		/// <param name="prob"></param>
		/// <returns></returns>
		 R inverse(Prob prob);



	}
}
