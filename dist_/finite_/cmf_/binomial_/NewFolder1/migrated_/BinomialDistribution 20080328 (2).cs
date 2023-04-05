using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real.rational.integer;
using nilnul.math.complex.real;
using nilnul.math.set;
using nilnul.math.combinatorics;
using nilnul.number.real;
using nilnul.number.integer;

namespace nilnul.statistics.randomVariable.discrete.distributions
{
	public class BinomialDistribution:IFiniteDensityFunction
	{
		private  INonnegativeInteger _total;
		private Real _probability;

		public BinomialDistribution(PositiveInteger total, Real probability) { 
			if(!DomainTotal.Contains(total)){
				throw new Exception();
			}
			if(!DomainProbability.Contains(probability)){
				throw new Exception();
			}

			_total = total;
			_probability = probability;
		}

		public PositiveInteger total {
			get {
				return _total;
			}
		}
		public Real probability {
			get {
				return _probability;
			}
		}

		public Set<Real> domain {
			get {
				return new ClosedInterval<Integer>(0,total);
			}
		}

		public Real mean {
			get {
				return total * probability;
			}
		}

		public Real variance {
			get {
				return total * probability * (1 - probability);
			}
		}

		public NonnegativeReal density(Real x) { 
			if(!domain.Contains(x)){
				throw new Exception();
			}
			
			return new Combination(total,x) * probability^x *(1-probability)^(total-x);
		}

		static public Set<Real> DomainTotal {
			get {
				return new TypeSet(typeof(PositiveInteger));
			}

		}
		static public Set<Real> DomainProbability {
			get {
				return new ClosedInterval<Real>(0,1);
			}
		}
	}
}
