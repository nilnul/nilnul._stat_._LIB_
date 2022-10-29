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
using nilnul.num;

namespace nilnul.prob_.continuum_
{
	/// <summary>
	/// 
	/// </summary>
	public class Descent
	{
		private nilnul.num.real.Bound _range;

		public nilnul.num.real.Bound range
		{
			get { return _range; }
			//set { _range = value; }
		}

		public Rx densityInSupport(
			Rx x
		) {
			return 2 * ( _range.upper.mark.ToReal() - x);
		}

	}
}
