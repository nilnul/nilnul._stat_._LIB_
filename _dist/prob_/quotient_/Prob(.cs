using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;
using System.Numerics;

namespace nilnul.prob.rationalProb
{
	public partial class Prob
	{
		


		public class OrderedSquence
			:nilnul.order.OrderedList<Prob>
			
			
		{
			public IEnumerable<Prob> _sequence;

			public OrderedSquence(IEnumerable<Prob> sequence)
				:base(nilnul.num.rational.order.LessThanOrEqualTo.Singleton.Instance,sequence)

			{

			}
					
		
		}
					

	}
}
