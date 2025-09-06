using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public partial class ComparerByProb<TSample>
		:
		nilnul.order.ComparerA<Event<TSample>>
	{

		public override order.Sign compare(Event<TSample> x, Event<TSample> y)
		{
			return nilnul.num.rational.order.Comparer.Instance.compare(x.probability,y.probability);
		}
	}
}
