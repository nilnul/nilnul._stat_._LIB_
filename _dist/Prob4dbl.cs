using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.stat._dist
{
	/// <summary>
	/// the prob of an object 
	/// </summary>
	public  class Prob4dbl:IProb
	{
		public double _val;

		public Prob4dbl(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public Prob4dbl CreateByNormalize(double val) {
			if (val>=1)
			{
				return Prob4dbl.One;
				
			}
			if (val<=0)
			{
				return Prob4dbl.Zero;
				
			}
			return new Prob4dbl(val);
		}

		static public implicit operator double (Prob4dbl x) {
			return x._val;
		}

		static public readonly Prob4dbl One = new Prob4dbl(1);
		static public readonly Prob4dbl Zero = new Prob4dbl(0);
		static public readonly Prob4dbl Half = new Prob4dbl(.5);




	}
}
