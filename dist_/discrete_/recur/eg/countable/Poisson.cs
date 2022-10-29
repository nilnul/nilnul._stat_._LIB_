using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.countable
{

	/// <summary>
	/// </summary>
	public partial class Poisson
	{
		private double _lambda;

		public double lambda
		{
			get { return _lambda; }
			set { _lambda = value; }
		}
		
		public Poisson( double lambda)
		{
			nilnul.bit.Assert.True(lambda > 0);
			this.lambda = lambda;

		}

		public double mode {
			get {

	/// ##The mode of a Poisson-distributed random variable with non-integer λ is equal to \scriptstyle\lfloor \lambda \rfloor, which is the largest integer less than or equal to λ. This is also written as floor(λ). When λ is a positive integer, the modes are λ and λ − 1.

				throw new NotImplementedException();
			}
		}

		public double mean {
			get {
				return lambda;
			}
		}

		public double variance {
			get {
				return lambda;
			}
		}

		public int sample {
			get {
				/* by knuth.

				algorithm poisson random number (Knuth):
    init:
         Let L ← e−λ, k ← 0 and p ← 1.
    do:
         k ← k + 1.
         Generate uniform random number u in [0,1] and let p ← p × u.
    while p > L.
    return k − 1.
				*/

				throw new NotImplementedException();
			}
		}
	}
}
