using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real;

namespace nilnul.random
{
	public partial class NormalDistribution
	{






	
			public static double Density(double x, double mean, double variance)
			{
				return 1.0 / Math.Sqrt(Tau.IntoDoulbe * variance) * Math.Exp(-.5*(x - mean) * (x - mean) / ( variance));
			}

		


	}
}
