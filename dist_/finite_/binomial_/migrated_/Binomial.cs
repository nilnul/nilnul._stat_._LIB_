using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.finite
{

	[Obsolete()]
	public class Binomial
	{
		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}
		private Prob _p;

		public Prob p
		{
			get { return _p; }
			set { _p = value; }
		}

		public Prob prob(uint k) { 

			return new Prob( Combinate.Eval(n,k)*Math.Pow(p._val,(double)k)*Math.Pow((1-p._val),n-k) );
		
		}
		
		
		
	}
}
