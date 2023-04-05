using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.byEvtSpace
{

	public partial class Finite<TSample> :Dictionary<TSample,double>
	{

		private Finite(Dictionary<TSample,double> dict)
			:base(dict)
		{

		}

		
		private Finite(IEqualityComparer<TSample> eq)
			:base(eq)
		{

		}






	}
}
