using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.prob_.positive
{
	/// <summary>
	/// 
	/// </summary>
	static public class _InfoInDblX
	{

		

		/// <summary>
		/// with event of this prob happens, the scope is reduced from 1 to prob
		/// </summary>
		/// <param name="_prob_assumePositive"></param>
		/// <returns>nonneg</returns>
		static public double _Info_assumeProbPositive(double _prob_assumePositive) {
			
			return -_info._UncertaintyX._Uncertainty_assumeScopeDivIsPositive(_prob_assumePositive);
			return _info._UncertaintyX._Uncertainty_assumeScopeDivIsPositive(1/_prob_assumePositive);
		}

	}
}
