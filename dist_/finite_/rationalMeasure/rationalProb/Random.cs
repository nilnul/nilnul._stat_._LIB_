using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public partial class Random
	{


		static public Prob next()
		{
			return new Prob(
				new nilnul.num.rational.Rational_InheritFraction(
				nilnul.prob.RandomX.next2()
				, int.MaxValue - 1

				)
			);
		}
	}
}
