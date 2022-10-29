using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.byEvtSpace
{
	public partial class Finite
	{
		public static T RandomSelect<T>(IEnumerable<T> set) {
			return set.ElementAt(Prob1.Next(set.Count()));
		}





	}
}
