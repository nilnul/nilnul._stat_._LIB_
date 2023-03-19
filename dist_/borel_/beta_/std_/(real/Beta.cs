using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace nilnul.prob.dist.inst
{


	/// <summary>
	/// if u~ beta dist. then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)


	/// </summary>
	public class Beta
	{
		public Real a{
			get;
			set;
		}
		public Real b
		{
			get;
			set;
		}

		public BetaDistribution(Real a,Real b) { 
			if(a<=0 || b<=0){
				throw new Exception();
			}

			this.a = a;
			this.b = b;


		}

		public Real density(Real x) {
			return x ^ (a - 1) *(1- x) ^ (b - 1) / new BetaFunction(a, b);
			


		}


		///where density is not 0.
		static public Set Domain {
			get {
				return new ClosedInterval(0, 1);
			}
		}

		static public Set abDomain {
			get {
				return new OpenInterval(0, PositiveInfinite.Instance);
			}
		}
	}
}
