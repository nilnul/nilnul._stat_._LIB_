using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using System.Linq.Expressions;

namespace nilnul.math.statistics
{
	public class CauhySchwarzInequation:theorem.Theorem
	{
		public Expression conclusion =
			(RandomVariable x, RandomVariable y)
			=> {
					if (
						(x * x).mean.exist
						&& (y * y).mean.exist
					)
					{
					return (x * y).mean.Power(2) <= (x ^ (Real)2).power((Real)2).mean * y.squared().mean; 
					};
			};
		
		

	}
}
