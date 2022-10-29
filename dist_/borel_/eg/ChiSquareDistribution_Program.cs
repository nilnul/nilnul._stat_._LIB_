using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;

namespace nilnul.statistics.distributions
{
	public partial class ChiSquareDistribution_Program
	{
		static public void Main() {
			ChiSquareDistribution.UpperDividingPoint(0.05,50).ToConsoleLine();
			NormalDistribution.UpperDividePoint(.05).ToConsoleLine();
			Console.Read();
		}
	}
}
