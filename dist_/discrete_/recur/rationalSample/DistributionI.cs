using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample
{
	public partial interface DistributionI
		:
		CdfAndInverseI
		
	{

		R inverse();
		
		



	}
}
