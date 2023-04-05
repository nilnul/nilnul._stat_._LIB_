using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.rationalSample
{
	public class EventNotZero	
		:
		Event
	{

		public EventNotZero(
			Rational_InheritFraction sample,
			Prob prob
		)
			:base(sample,prob)
		{
			nilnul.num.rational.ZeroX.AssertNotZero(prob);

		}
					
	}
}
