using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.prob
{
	/// <summary>
	/// </summary>
	static public class _InfoDiscountedX
	{
		/// <summary>
		/// the event in n times of experiment brings how many info on average
		/// </summary>
		/// <param name="_prob_assumeProb"></param>
		/// <returns></returns>
		static public double _InfoDiscounted_assumeProb(double _prob_assumeProb) {
			if (_prob_assumeProb ==0)
			{
				return 0;
			}
			return _prob_assumeProb *  prob_.positive._InfoInDblX._Info_assumeProbPositive(_prob_assumeProb);
		}
	}
}
