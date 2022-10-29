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


		static public Finite<TSample> FromSample(IEnumerable<TSample> samples) {

			var dict = new Dictionary<TSample, double>();

			var totalCount = samples.Count();

			samples.GroupBy(x => x).ForEach(
				item=>
				dict.Add(item.Key, (double)item.Count() / totalCount)
			);

			return new Finite<TSample>(dict);


		}





	}
}
