using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealIX;
using nilnul.num.real;


namespace nilnul.prob_._continuum_.cdf_.spanned
{
	public abstract class InversedA
	{


		private nilnul.num.real.Bound _support;

		public nilnul.num.real.Bound support
		{
			get { return _support; }
			set { _support = value; }
		}


		/// <summary>
		/// we can use this to ,  input a uniform random variable and output the distribution herein.
		/// </summary>
		/// <param name="measure"></param>
		/// <returns></returns>
		public abstract R sample( nilnul._prob.Measure measure);
		

	}
}
