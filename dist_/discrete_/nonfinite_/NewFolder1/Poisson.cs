using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.RealI;
using Positive = nilnul.num.real.be_.positive.vow.En;
using nilnul.num.real;
using nilnul.num;

using N = nilnul.Num1;
namespace nilnul.prob_.recur_
{

	/// <summary>
	/// how many people come in  when the time is in the interval of [0,t)
	/// </summary>
	public  class Poisson
	{
		private Positive _lambda;

		public Positive lambda
		{
			get { return _lambda; }
			set { _lambda = value; }
		}
		
		public Poisson( Positive lambda)
		{
		
			this.lambda = lambda;

		}

		public _prob.Measure measure(N n) {
			return new _prob.Measure(
				(
				num.real.op_.unary_.Exp.Singleton.op(
					num.RealIX.Negate(_lambda.en)
				).ToReal()

				*
				nilnul.num.real.op_.unary_._PolyX.RealI(_lambda.en.ToReal(),n)
				).ToReal()

				/
				nilnul.num.op_._FactorialX._Eval_byLoop(n)
				//num.op_.Factorial.Singleton.eval(n)
				)
				;
		}

		public double mode {
			get {

	/// ##The mode of a Poisson-distributed random variable with non-integer λ is equal to \scriptstyle\lfloor \lambda \rfloor, which is the largest integer less than or equal to λ. This is also written as floor(λ). When λ is a positive integer, the modes are λ and λ − 1.

				throw new NotImplementedException();
			}
		}

		public Positive mean {
			get {
				return lambda;
			}
		}

		public Positive variance {
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
