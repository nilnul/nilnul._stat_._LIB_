using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.statistics
{
	public class Zscore
	{
		static public double Eval(double x, double mean, double deviation) {

			return (x - mean) / deviation;
		}
	}
}
