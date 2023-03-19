using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str_.started
{
	static public class _VarianceX
	{
		static public double _Variance_0started_1mean(IEnumerable<double> _started, double mean) {
			return nilnul.num.real.str.to_.scalar_._SquareSumX.SquareSum(_started.Select(x => x - mean));
		}

		static public double _Variance_0started(IEnumerable<double> _started) {
			var mean = /*nilnul.num.real.str_.started._MeanX.Avg*/(_started.Average());
			return _Variance_0started_1mean(_started,mean);
		}

		static public double _Deviation_0started(IEnumerable<double> started) {
			return Math.Sqrt(_Variance_0started(started) );
		}
		static public double _Deviation_0started_1mean(IEnumerable<double> started, double mean) {
			return Math.Sqrt(_Variance_0started_1mean(started,mean) );
		}


	}
}
