using System;
using System.Net;

namespace nilnul.prob.doubleProb.finite
{
	public partial class CoinToss
	{

		public double p
		{
			get;
			set;
		}

		public CoinToss(double p)
		{
			this.p = p;

		}

	
		public double mean() {
			return p;
		}
		public double var() {
			return p - p*p;
		}

		public double prob(bool headOrTail) {
			if (headOrTail)
			{
				return p;
				
			}
			else
			{
				return 1 - p;
			}
		
		}
					


	}
}
