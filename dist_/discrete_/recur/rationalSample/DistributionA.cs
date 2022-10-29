using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample
{
	public abstract partial class DistributionA
		:DistributionI
	{

		public R inverse()
		{
			return inverse( Random.next());
		}

		public R inverse(R prob)
		{
			return inverse(new Prob(prob));
		}

		public Prob cumulativeDensity(R upperbound) {

			return probability(upperbound);
		
		}


		public abstract Prob probability(R upperBound);


		/// <summary>
		/// use binary search and power search
		/// </summary>
		/// <param name="prob"></param>
		/// <returns></returns>
		public abstract R inverse(Prob prob);
	}
}
