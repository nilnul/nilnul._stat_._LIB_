using nilnul.num_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.egal.uncertainty
{
	/// <summary>
	/// the count of basic events can act as a comparison indicator for the extent of uncertainty.
	/// </summary>
	public class Comp
		:
		IComparer<
			nilnul.num_.Positive1
		>
	{
		/// <summary>
		/// compare the count of options. the bigger the count is, the bigger the uncertainty is.
		/// equivalent count means equivalent uncertainty. This means that uncertainty is a function of the count of options.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public int Compare(Positive1 x, Positive1 y)
		{
			return nilnul.num.Comparer2.Singleton.Compare(x, y);

		}
	}
}
