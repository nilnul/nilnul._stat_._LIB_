using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.statistics.distributions;

namespace nilnul.statistics.distributions
{
	class Program_Normal
	{
		static public void Main() {
			Console.WriteLine("{0},{1},{2},{3},{4},{5}", NormalDistribution.AnotherCDF(0),NormalDistribution.AnotherCDF(-1),NormalDistribution.AnotherCDF(1),NormalDistribution.CDF(0),NormalDistribution.CDF(-1),NormalDistribution.AnotherCDF(1));
			
			Console.Read();

		}
	}
}
