using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;

namespace nilnul.prob._prob
{
	/// <summary>
	/// the prob of an object 
	/// </summary>
	public partial class InDouble
	{
		public double _val;

		public InDouble(double _val)
		{
			nilnul.num.real.double_.CloseInterval.Unit.assertion.assertContains(_val);
			this._val = _val;

		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public InDouble CreateByNormalize(double val) {
			if (val>=1)
			{
				return InDouble.One;
				
			}
			if (val<=0)
			{
				return InDouble.Zero;
				
			}
			return new InDouble(val);
		}

		static public readonly InDouble One = new InDouble(1);
		static public readonly InDouble Zero = new InDouble(0);
		static public readonly InDouble Half = new InDouble(.5);




	}
}
