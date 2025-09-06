using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.discrete
{
	public partial class ProbabilitiesSet
	{
		static public bool SumIsOne(IEnumerable<ProbabilityInRational1> probs) {
			return 	nilnul.num.rational.set.SumX.Sum(probs) == 1
			
			;
		
		}
		static public bool SumIsOne(IEnumerable<ProbabilityInRational> probs) {
			return 	nilnul.num.rational.set.SumX.Sum(probs) == 1
			
			;
		
		}
		static public nilnul.bit.Predicate<IEnumerable<ProbabilityInRational1>> SumIsOnePredicate1=new bit.Predicate<IEnumerable<ProbabilityInRational1>>(SumIsOne);

		static public nilnul.bit.Predicate<IEnumerable<ProbabilityInRational>> SumIsOnePredicate=new bit.Predicate<IEnumerable<ProbabilityInRational>>(SumIsOne);
	}
}
