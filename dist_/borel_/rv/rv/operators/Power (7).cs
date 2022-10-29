using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.statistics.operators
{
	public class Power:BinaryOperator
	{
		public RandomVariable @base;
		public RandomVariable exponenet;
		public Power(RandomVariable @base,RandomVariable exponent) {
			this.@base = @base;
			this.exponenet = exponenet;
			
		}
	}
}
