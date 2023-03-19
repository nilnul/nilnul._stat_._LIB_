using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
{
	///
	
	/// <summary>
	/// 
	/// The PERT distribution is used exclusively for modeling expert estimates, where one is given the expert's minimum, most likely and maximum guesses. It is a direct alternative to a Triangle distribution, so a discussion is warranted on comparing the two:
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// according to 
	/// </remarks>
	public partial class Pert_mu2
		:DistributionA
	{
		public double min;
		public double max;
		public double mod;

		public double lambda=4;

		public double span {
			get {
				return max - min;
			}
		}

		#region ctor
		public Pert_mu2(double min,double mod,double max,double lambda=4)
		{
			nilnul.bit.Assert.True(min < max);
			nilnul.bit.Assert.True(min <= mod);
			nilnul.bit.Assert.True(mod <= max);


			this.min = min;
			this.max = max;
			this.mod = mod;
			this.lambda = lambda;
		}


		//public Pert(double definite)
		//	:this(definite,definite,definite)
		//{
		//}
		

		#endregion

		public BetaGeneralized toBetaGeneralizedDist {
			get {
				return new BetaGeneralized(a, b, min, max);
			}
		
		}

		public double inversePdf(double prob)
		{
			return toBetaGeneralizedDist.inversePdf(prob);
		}
		public double inversePdf()
		{
			return inversePdfRandomly();
		}

		public double inversePdfRandomly()
		{
			System.Random random = new System.Random();

			return toBetaGeneralizedDist.inversePdf(random.NextDouble());
		}
		#region static
		static public BetaGeneralized ToBetaGeneralized(double min,double mod,double max,double lambda=4) {

			return new Pert_mu2(min, mod, max,lambda).toBetaGeneralizedDist;
		}

		#endregion


			

		public double cumulativeDensity(double x) { 
			return toBetaGeneralizedDist.cumulativeDensity(x);
		}

		public double a{
			get {
				return 1 + lambda * (mod - min)/span;
			}
		}
		public double a2
		{
			get
			{
				return 1 + lambda * (mod - min) / span;
			}
		}

		public double b{
			get {
				return 1 + lambda * (max - mod) / span;
			}
			
		}


		public double density(double x) {

			return toBetaGeneralizedDist.density(x);
		
		}
					

		static public double Density(double min, double mod, double max,double x)
		{

			if (x<=min)
			{
				return 0;
				
			}
			if (x>=max)
			{
				return 0;
				
			}



			double mean = Mean(min, mod, max);
			double a = A(min, mod, max, mean);
			double b = B(min, max, mean, a);

			return Beta2.Density(a, b, x);
		}

		public double mu {
			get {
				return Mean(min, mod, max);
			}
			
		}

		static public double Mean(double min, double mod, double max)
		{

			return (min + 4 * mod + max) / 6;
		}

		static public double A(double min, double mod,double max,  double mean)
		{
			return (mean - min) * (2 * mod - min - max) / ((mod - mean) * (max - min));

		}
		static public double A(double min, double mod, double max)
		{
			return A(min, mod, max, Mean(min, mod, max));

		}

		static public double B(double min, double max,double mean,double a)
		{
			return a*(max-mean)/(mean-min);

		}

		public override Prob probability(double upperBound)
		{
			return  toBetaGeneralizedDist.probability(upperBound);
		}

		public override double inverse(Prob prob)
		{
			return toBetaGeneralizedDist.inverse(prob);
		}
	}
}
