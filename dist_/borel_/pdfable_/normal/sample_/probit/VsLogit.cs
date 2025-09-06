using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.normal.sample_.probit
{
	static public class _ScaleX
    {
		static public readonly double SCALE = 2 * nilnul.num.real_.eg_.sqrt_._OfTwoX.DBL / nilnul.num.real_.eg_.pi._SqrtX.AsDbl;

		/// <summary>
		/// divide sqrt(pi/8) such that the slope is the same as <see cref="nilnul.num.real.fn_.ILogit"/> at 0;
		/// </summary>
		/// <param name="p"></param>
		/// <returns></returns>
		static public double PerSqrt16thTau(double p) {
			return _ProbitX._Probit_0prob(p)
				*SCALE	/// 				/ sqrt(pi/8)
				;
		}
    }
}
