using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob._measure.doubl.positive._info
{
	public class Uncertainty
	{
		static public double Eval(nilnul.num.real.doubl.normal.be.GeOne.En options) {
			return Math.Log(options.toDouble());
		}

		static public double _Eval(double _geOne) {

			return Math.Log(_geOne);
		}
	}
}
