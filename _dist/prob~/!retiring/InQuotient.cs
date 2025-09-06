using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;

namespace nilnul.prob._prob
{
	public partial class InQuotient
		:global::nilnul.num.rational.Rational_InheritFraction2
	{
		//public nilnul.num.rational.Rational_InheritFraction val;

		public InQuotient(nilnul.num.rational.Rational_InheritFraction val)
		{
			new nilnul.interval.ClosedInterval<Rational_InheritFraction>(0,1).assertContains(val);
			//this.val = val;

		}


		public class OrderedSquence
			:nilnul.order.OrderedList<Rational>
			
			
		{
			public IEnumerable<Rational> _sequence;

			public OrderedSquence(IEnumerable<Rational> sequence)
				:base(nilnul.num.rational.order.LessThanOrEqualTo.Singleton.Instance,sequence)

			{

			}
					
		
		}
					

	}
}
