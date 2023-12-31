using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.statistics
{
	public class Zscore
	{
		[Obsolete(nameof(nilnul.num.real.of_.unary_._StdX))]
		static public double Eval(double x, double mean, double deviation) {

			return (x - mean) / deviation;
		}
	}
}
