using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.complex.real.set;
using nilnul.math.calculus;

namespace nilnul.math.statistics.distribution
{
	public class ChiSquareDistribution:GammaDistribution
	{

		[Obsolete("Use degreesOfFreedom instead.")]
		public PositiveInteger n
		{
			get;
			set;
		}

		public PositiveInteger degreesOfFreedom {
			get {
				return n;
			}
			
		}


		/// <summary>
		/// not yet finished.
		/// </summary>
		/// <param name="r"></param>
		/// <returns></returns>

		public ChiSquareDistribution obey(RandomVariable r) { 
			///if r is the sum of n independent random variables, then r obeys ChiSquareDistribution with n degrees of freedom.
			///
			RandomVariable[] xs;
			foreach(RandomVariable x in xs){
				if(!Xi.distribution is Normal){
					return null;
				}

			}
			return null;
			

			
			

			
		}


		public Real centralMoment(PositiveInteger n) {
			if (n == 1)
			{
				return degreesOfFreedom;
			}
			else if(n==2){
				return 2 * degreesOfFreedom;
			}
			else if (n == 3)
			{
				return 8 * degreesOfFreedom;
			}
			else {
				return null;
			}
			
			
		}

		

		public ChiSquareDistribution(PositiveInteger n) {
			this.n = n;
		}

		public Real density(Real x) {
			if (Domain.contains(x)) {
				return x.Power(n/2-1) * E.Instance.Power(-x/2)
					/ (2^(n/2) * new GammaFunction(n/2) );
			}
			else{
					return 0;
			}
		}

		
		static public Set Domain {
			get {
				return new OpenInterval(0, PositiveInfinite.Instance);
			}
		}
	}
}
