using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.finite
{
	public partial class Uniform
	{
		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}

		public Uniform(uint n)
		{
			this.n = n;

		}

		public double prob(uint k) {
			if (k<n)
			{
				return 1.0 / n;
			}
			return 0;
		}
		
	}
}
