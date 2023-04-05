using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using N = nilnul._num.bigint.be.Natural.Asserted;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
using Rx = nilnul.num.RealI;
using nilnul.num.real;


namespace nilnul.prob_.continuum_
{
	public class Triangular
	{

		private nilnul.num.real.Bound _range;

		public nilnul.num.real.Bound  range
		{
			get { return _range; }
			//set { _range = value; }
		}

		private Rx _mod;

		public Rx mod
		{
			get { return _mod; }
			//set { _mod = value; }
		}
		public Triangular(
			nilnul.num.real.Bound  range
			,
			Rx mod
		)
		{
			nilnul.obj.avow_.True.Avow(

				nilnul.num.real.comp.Re.Singleton.gt(mod,range.lower.mark)

				&&
				nilnul.num.real.comp.Re.Singleton.lt(mod,range.upper.mark)
				
			);

			_range = range;
			_mod = mod;
		}

	}
}
