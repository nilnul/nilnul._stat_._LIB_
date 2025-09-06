using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.prob.doubleProb
{
	public partial class Prob
	{
		public double _val;

		public Prob(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		static public Prob CreateByNormalize(double val) {
			if (val>=1)
			{
				return Prob.One;
				
			}
			if (val<=0)
			{
				return Prob.Zero;
				
			}
			return new Prob(val);
		}

		static public readonly Prob One = new Prob(1);
		static public readonly Prob Zero = new Prob(0);
		static public readonly Prob Half = new Prob(.5);



		




	}
}
