using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.theorem;
namespace nilnul.math.statistics.distribution
{

	 /// <remarks>
    /// the domain is (0,+inf),rather than [0,+inf), for the convenience of derivative. of course the domain of the probality density function t->l*e^(-lt) can be extended to include 0,where the image is l, which is the same as lim(l*e^-l*t) while t->0; in other words, it's continuous on the right here.
    /// 
	/// when the time is 0, or 0+, the probality is lambda, in that the average arrival rate over time is lambda.
	/// 
	/// at every time point, the density is interpretated as: no arrival before this and now it happens.
    /// 
	/// In Kendall Marks, exponential distribution is denoted as M, means Markov(Memory less).
	/// 
    /// </remarks>
	public class ExponentialDistribution
	{
		public ExponentialDistribution(PositiveReal b):base(1,b) { 
		}

		public Real mean {
			get
			{
				return 1 / b;
			}
		}

		public NonnegativeReal variance {
			get {
				return 1 / b ^ 2;
			}
		}


		/// <summary>
		/// 
		/// </summary>

		static public List<Theorem> theorems;
		static ExponentialDistribution(){
			
			Theorem t=new Theorem();
			t.conclusion=

				(RandomVariable[] Xs,
				PositiveReal b)=>{
			
					if (
						
						Xs.indenpendence = true
						&& 
						Xs.All(x=>x.Distribution==new ExponentialDistribution(b))
					){ 
						Xs.Aggregate((w,c)=>w+c).Distribution==new GammaDistribution(Xs.Length,b);
			 

					};


				};
			theorems.Add(t);


		}
		

		 }

	}//class


	///
}
