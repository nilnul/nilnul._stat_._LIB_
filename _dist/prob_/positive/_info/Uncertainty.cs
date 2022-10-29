using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.prob_.positive._info
{
	/// <summary>
	/// 
	/// </summary>
	static public class _UncertaintyX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="scope"></param>
		/// <returns>nonneg</returns>
		static public double _Uncertainty_ofScope(nilnul.num_.Positive1 scope)
		{
			return Math.Log((double)scope.en, 2);
		}

		/// <summary>
		///  lb(n) -lb(n1) =lb(n/n1), where n>= n1; this is the infor needed to narrow the scope.
		///  if n lt n1, this is negated.
		///  n is recurrence: the populatation/ the sample, or the scope
		/// </summary>
		/// <param name="scopeDiv"></param>
		/// <returns>nonneg or negative </returns>
		static public double _Uncertainty_assumeScopeDivIsPositive(double scopeDiv)
		{
			return Math.Log(scopeDiv, 2);

		}

		

	}
}
