using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;

namespace nilnul.random.prob
{
	[Obsolete(nameof(nilnul.stat.ProbQuotient))]
	public partial class ProbQ
		:nilnul.num.rational.Rational_InheritFraction2
	{
		//public nilnul.num.rational.Rational_InheritFraction val;

		public ProbQ(nilnul.num.quotient.Q val)
		{
			nilnul.obj.AssertX.True(
				 nilnul.num.quotient.border.duo.be_.Nonempty.En.CreateCloseUnit().contains(
					 new num._quotient.fraction.op.Simplify.Ed1(
					 
					 val.numerator
					 ,val.denominator.val
					 )
				 
				 )
			);
			//this.val = val;

		}


					

	}
}
