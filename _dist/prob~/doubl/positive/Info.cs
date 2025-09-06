using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob._measure.doubl.positive
{
	public class Info
	{

		static public double _Eval(double _positiveProb)
		{
			return _info.Uncertainty._Eval(1 / _positiveProb);
		}

	}
}
