using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public partial class Events
	{
		static public bool SumIsOne<TSample>(IEnumerable<Event<TSample>> events) {


			return nilnul.num.rational.set.SumX.Sum(events.Select(c => c.probability.val)) == 1;
			
		}

		static public void AssertNormalized(nilnul.num.rational.Rational_InheritFraction r) {
			nilnul.bit.AssertionNullaryFunc.True(r == 1);
		}

		static public void AssertNormalized<TSample>(
			IEnumerable<Event<TSample>> events
			
			){
			nilnul.bit.AssertionNullaryFunc.True(SumIsOne(events));
		
		}
	}
}
