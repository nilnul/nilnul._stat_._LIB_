using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.rationalSample
{
	/// <summary>
	/// order events by sample
	/// </summary>
	public partial class OrderBySample
		:nilnul.order.TotalOrderI3<Event>
	{


		public  bool contains(Event first, Event second)
		{
			return nilnul.num.rational.order.LessThanOrEqualTo.Instance.contains(first.sample, second.sample);

			throw new NotImplementedException();
		}

		static public OrderBySample Instance = SingletonByDefaultNew<OrderBySample>.Instance;
	}
}
