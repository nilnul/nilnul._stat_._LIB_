using System;
using System.Net;

namespace nilnul.stat.dist_.finite_
{
	public  class Bernoulli4dbl
		:
		Finite4dblI<bool>
	{

		public _dist.Prob4dbl prob4true
		{
			get;
			set;
		}

		/// <summary>
		/// to make the <paramref name="prob4true"/> aligned with bool, that is, when <paramref name="prob4true"/> is 0, the sample is 0, when <paramref name="prob4true"/> is 1, the sample is 1;
		/// </summary>
		/// <param name="prob4true">
		/// when zero, the sample is always 0;
		/// when 1, the sample is always 1;
		/// </param>
		public Bernoulli4dbl(_dist.Prob4dbl prob4true)
		{
			this.prob4true = prob4true;

		}

		public Bernoulli4dbl(double p):this(new _dist.Prob4dbl(p))
		{

		}

	
		public double mean() {
			return prob4true;
		}
		public double var() {
			return prob4true - prob4true*prob4true;
		}

		public double pmf(bool headOrTail) {
			if (headOrTail)
			{
				return prob4true;
				
			}
			else
			{
				return 1 - prob4true;
			}
		
		}

		public bool sample()
		{
			///this is a sample
			return stat.dist_.borel_.pdf_.uniform_._Preportion4dblX.Sample() < this.prob4true._val;
			
		}
	}
}
