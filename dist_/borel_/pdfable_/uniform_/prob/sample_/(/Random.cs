using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	[Obsolete(nameof(stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX))]
	public partial class Random
	{


		static public Prob next()
		{
			return new Prob(
				new nilnul.num.rational.Rational_InheritFraction(

					//nilnul.stat.dist_.borel_.pdf_.uniform_.Preportion4dblEs.Get0th().
				nilnul.prob.RandomX.next2()
				,
				int.MaxValue - 1

				)
			);
		}
	}
}
