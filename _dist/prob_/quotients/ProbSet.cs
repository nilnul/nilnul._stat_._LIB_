using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public partial class ProbSet
	{
		static public bool SumIsOne(IEnumerable<Prob> probs) {
			return 	nilnul.num.rational.set.SumX.Sum(probs) == 1
			
			;
		
		}

		static public nilnul.bit.Predicate<IEnumerable<Prob>> SumIsOnePredicate=new bit.Predicate<IEnumerable<Prob>>(SumIsOne);
	}
}
