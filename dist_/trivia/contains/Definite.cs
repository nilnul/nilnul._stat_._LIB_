using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains
{
	public partial class Definite
		:DistributionA
		
	{
		private double _mean;

		public double mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public Definite(double mean)
		{
			this.mean = mean;
		}



		public override Prob probability(double upperBound)
		{
			if (upperBound>=mean)
			{
				return Prob.One;
				
			}
			return  Prob.Zero;
		}

		public override double inverse(Prob prob)
		{
			return mean;
		}


	}
}
