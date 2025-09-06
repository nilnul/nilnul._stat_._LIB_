using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.random.prob
{
	public partial class ProbD
	{
		public double _val;

		public ProbD(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public ProbD CreateByNormalize(double val) {
			if (val>=1)
			{
				return ProbD.One;
				
			}
			if (val<=0)
			{
				return ProbD.Zero;
				
			}
			return new ProbD(val);
		}

		static public readonly ProbD One = new ProbD(1);
		static public readonly ProbD Zero = new ProbD(0);
		static public readonly ProbD Half = new ProbD(.5);




	}
}
