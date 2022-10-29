using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalProb.rationalSample
{
	public partial interface PdfI
	{
		Prob density(R sample);
		R inversePdf(Prob probability);
		R inversePdf();
		

	}
}
