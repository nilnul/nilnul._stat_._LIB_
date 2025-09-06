using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob
{
	public partial class Double
	{
		public double _val;

		public Double(double _val)
		{
			nilnul.bit.AssertionNullaryFunc.True(
				nilnul.num.real.double_.CloseInterval.Unit.Instance.contains(_val)
			);
			this._val = _val;

		}


	}
}
