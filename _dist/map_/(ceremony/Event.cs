using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.rationalSample
{
	public class Event	:Event<Rational_InheritFraction>,stat._dist.IMap
	{

		public Event(NotNull2<Rational_InheritFraction> sample
			
			,
			NotNull2<rationalProb.Prob> prob
			)
			:base(sample,prob)
		{
		}
					

		public Event(
			Rational_InheritFraction sample,
			rationalProb.Prob prob
		)
			:base(sample,prob)
			
			
		{

		}

		public Event(
						Rational_InheritFraction sample,

						Rational_InheritFraction prob

			)
			:base(sample,new Prob(prob))
		{
		}
					
					
	}
}
