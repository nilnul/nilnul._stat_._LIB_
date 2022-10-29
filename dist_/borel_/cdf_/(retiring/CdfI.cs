using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb
{
	public partial interface CdfI<T>
	{
		Prob probability(T upperBound);
		T inverse(Prob prob );


	}
}
