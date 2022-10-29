using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.statistics.distribution

{
	public class Weibull
	{
		public PositiveReal a;
		public PositiveReal b;
		public WeibullDistribution(PositiveReal a, PositiveReal b) {
			this.a = a;
			this.b = b;
		}

		public NonnegativeReal cumulativeDistribution(Real x) {
			if(Domain.contains(x)){
				return 1 - E.Instance ^ ((-x / a) ^ b);
			}
			return 0;
			

		}

		static public RealSet Domain {
			get {
				return new Interval(0, Infinite.Positive, Interval.Type.Open);
			}
		}
	}
}
