using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.statistics.operators
{
	public class Divide:Binary
	{

		public Divide(RandomVariable a, RandomVariable b) {
			this.left = a;
			this.right = b;
		}
	}
}
