using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel.sample.of_.unary_
{
	static public class _StdX
	{
		static public double _Std_1mean_2divergence(double x, double mean,double deviation) {
			return _NeutralizX.Drift_1mean(x,mean)/ deviation;
		}
	}
}
