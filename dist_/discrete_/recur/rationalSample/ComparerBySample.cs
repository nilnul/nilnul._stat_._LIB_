using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.rationalSample
{
	public partial class ComparerBySample
		:
		nilnul.order.ComparerA<Event>
	{

		public override order.Sign compare(Event x, Event y)
		{
			return nilnul.num.rational.order.Comparer.Instance.compare(x.sample,y.sample);
		}
	}
}
