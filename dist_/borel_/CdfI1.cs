using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;
using nilnul.num.real;


namespace nilnul.prob_._continuum_
{
	public  interface CdfI
	{
		nilnul._prob.Measure measure(R upperBound);


	}
}
