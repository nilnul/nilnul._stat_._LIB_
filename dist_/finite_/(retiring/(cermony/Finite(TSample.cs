using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.byEvtSpace
{

	public partial class Finite<TSample> :Dictionary<TSample,double>
	{

		public Finite(Dictionary<TSample,double> dict)
			:base(dict)
		{
			nilnul.stat._dist.probs.be_.totalOne.Vow4dbl.Unison.vow(dict.Values);
			//nilnul.prob.measure.OmegaD.AssertSumIsOne(dict.Values);


		}


		private Finite(IEqualityComparer<TSample> eq)
			:base(eq)
		{

		}







	}
}
