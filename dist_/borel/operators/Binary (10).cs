using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.statistics.operators
{
	public class Binary:Multiple
	{
		public RandomVariable left
		{
			get;
			set;
		}
		public RandomVariable right
		{
			get;
			set;
		}
	}
}
