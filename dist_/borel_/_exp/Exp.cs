using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample.distributions
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// the developers of this class referenced:
	/// 1.http://mathworld.wolfram.com/ExponentialDistribution.html
	/// 
	/// </remarks>
	public partial class Exp:DistributionI
	{
		/// <summary>
		/// arrivals per unit of timespan
		/// </summary>
		private double _rateOfArrival;

		public double rateOfArrival
		{
			get { return _rateOfArrival; }
			set { _rateOfArrival = value; }
		}
		
		public Exp(double lambda)
		{
			nilnul.bit.Assert.True(lambda > 0);

			this.rateOfArrival = lambda;

		}

		public double cdf(double x) {
			return 1 - Math.Exp(-rateOfArrival * x);
		}

		public double pdf(double x) {

			return x>0?rateOfArrival * Math.Exp(-rateOfArrival * x):0;
		}

		public double mean() {
			return 1.0 / rateOfArrival;
		
		}

		public double var() {
			return 1.0 / Math.Pow(rateOfArrival, 2);
		}

		public double sample() {



			return -Math.Log(1 - nilnul.prob.RandomX.next()) / rateOfArrival;
			throw new NotImplementedException();
		}

		public double inverse(double prob) { 
				return -Math.Log(1 - prob) / rateOfArrival;
			throw new NotImplementedException();
	
			
		}



		public double var_MathNet() { 
			//return MathNet.Numerics.Distributions.ExponentialDistribution.
			throw new NotImplementedException();
		}

		public double inverse()
		{
			return sample();
			throw new NotImplementedException();
		}

		public Prob probability(double upperBound)
		{
			return new Prob( cdf(upperBound));
			throw new NotImplementedException();
		}

		public double inverse(Prob prob)
		{

			return inverse(prob._val);
			
			throw new NotImplementedException();
		}
	}
}
