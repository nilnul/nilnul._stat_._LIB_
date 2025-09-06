using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;

namespace nilnul.prob
{
	public partial class ProbabilityInRational
		:nilnul.num.rational.Rational_InheritFraction
	{
		//public nilnul.num.rational.Rational_InheritFraction val;

		public ProbabilityInRational(nilnul.num.rational.Rational_InheritFraction val)
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
