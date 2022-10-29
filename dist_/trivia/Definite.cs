using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample.cdf.contains
{
	public partial class Definite
		:DistributionA
		
	{
		private R _mean;

		public R mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public Definite(R mean)
		{
			this.mean = mean;
		}



		public override Prob probability(R upperBound)
		{
			if (upperBound>=mean)
			{
				return Prob.One;
				
			}
			return  Prob.Zero;
		}

		public override R inverse(Prob prob)
		{
			return mean;
		}




	}
}
