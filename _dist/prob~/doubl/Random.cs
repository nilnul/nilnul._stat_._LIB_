using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob._prob.inDouble
{
	public partial class Random
	{
		static public InDouble next() {
			return new InDouble( nilnul.prob.RandomX.NextDouble());
		}
	}
}
