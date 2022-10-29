using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb
{
	public partial interface PmfI<T>
	{
		Prob probability(T sample);



	}
}
