using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quotient = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.prob.statistics.confidenceInterval.varianceKnown
{
	public class TwoSided
	{
		

		public class ConfidenceLevel {
			static public Quotient L99 = (Quotient)2576 / 1000
				;
			static public Quotient L98 = new Quotient(2326/1000);

			static public Quotient L95 = new Quotient(196, 100)
				;
			static public Quotient L90 = new Quotient(1645, 1000);

		}

		

	}
}
