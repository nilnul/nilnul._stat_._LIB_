using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.math.complex.real.rational.integer;
using nilnul.math.complex.real.set;
using nilnul.math.set;
using nilnul.number.real;
using nilnul.number.integer;


namespace nilnul.math.statistics.distribution
{
	/// <summary>
	/// For a binomial distribution, when N->+inf, while NP keeps steady(i.e., the persons show up steady no matter there are many persons),- needing p->+0 - , then it converges to poisson distribution.
	/// </summary>
	public class PoissonDistribution:Distribution
	{

		/// <summary>
		/// how many events occur during a unit of time.
		/// </summary>
		private PositiveReal _rate;

		
		///expected number of persons in a certain period
		///
		public PositiveReal rate{
			
			get {
				return _rate;
			}
		}
		
		public PoissonDistribution(PositiveReal rate){

			this.rate = rate;

		}


		public NonnegativeReal density(NonnegativeInteger n) {
			return Density(k, n);
		}

		public Func<PositiveInteger, NonnegativeReal> densityFunction(PositiveInteger x) { 
			using(E e=E.Instance,
				r=rate){

				return x=>e^(-r) * r^x /x.factorial();
				
			}
			
		}

		public Func<PositiveInteger, NonnegativeReal> cumulativeFunction() { 
		}

		public Real mean {
			get {
				return rate;
			}
		}

	

		public Real variance{
			get
			{
				return rate;
			}
		}

		/// <summary>
		/// return the point where the density is the biggest.
		/// </summary>
		/// <returns></returns>
		public Real[] densest() {
			if (k is PositiveInteger)
			{
				return new Real[] { k - 1, k };
			}
			else {
				return Math.Floor(k);
			}
			
		}

		public Set<Real> domain {
			get {
				return new TypeSet(typeof(NonnegativeInteger));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		static public Set<Real> RateDomain {
			get {
				return new TypeSet(typeof(PositiveReal));
			}
		}


		static public Real Density(PositiveReal k,NonnegativeInteger n){
			return E.Instance.Power(-k) * k.Power(n) / n.Factorial();
		}
	}
}
