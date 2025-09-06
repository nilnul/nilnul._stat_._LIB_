using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.prob._measure
{
	/// <summary>
	/// the prob of an object 
	/// </summary>
	public partial class Double
	{
		public double _val;

		public Double(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public Double CreateByNormalize(double val) {
			if (val>=1)
			{
				return Double.One;
				
			}
			if (val<=0)
			{
				return Double.Zero;
				
			}
			return new Double(val);
		}

		static public implicit operator double (Double x) {
			return x._val;
		}

		static public readonly Double One = new Double(1);
		static public readonly Double Zero = new Double(0);
		static public readonly Double Half = new Double(.5);




	}
}
