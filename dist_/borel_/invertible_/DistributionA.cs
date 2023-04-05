using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample
{
	[Obsolete(nameof(stat.dist_.borel_.Invertible4dblA))]
	public abstract partial class DistributionA
		:DistributionI
	{
		Random rnd = new Random();
		public double inverse()
		{
			return inverse(

				rnd.NextDouble()
			//	prob.RandomX.NextDouble()

				);
		}

		public double inverse(double prob)
		{
			return inverse(new Prob(prob));
		}


		public abstract Prob probability(double upperBound);


		/// <summary>
		/// use binary search and power search
		/// </summary>
		/// <param name="prob"></param>
		/// <returns></returns>
		public abstract double inverse(Prob prob);
	}
}
