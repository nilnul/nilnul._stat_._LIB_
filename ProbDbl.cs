using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.stat
{
	/// <summary>
	/// the prob of an object 
	/// </summary>
	public  class ProbDbl
	{
		public double _val;

		public ProbDbl(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public ProbDbl CreateByNormalize(double val) {
			if (val>=1)
			{
				return ProbDbl.One;
				
			}
			if (val<=0)
			{
				return ProbDbl.Zero;
				
			}
			return new ProbDbl(val);
		}

		static public implicit operator double (ProbDbl x) {
			return x._val;
		}

		static public readonly ProbDbl One = new ProbDbl(1);
		static public readonly ProbDbl Zero = new ProbDbl(0);
		static public readonly ProbDbl Half = new ProbDbl(.5);




	}
}
