using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist_.cmf_.xpn_
{
	/// <summary>
	/// if there is no order, we cannot determine which are to be cumulated;
	/// that is :
	///		P(X le x) where le is not defined;
	/// </summary>
	/// <remarks>
	/// those ordered can be desribed using <see cref="dist_.IBorel"/>, though that might be overkill for some cases like when the sample is int|quotient|num, but still is telling the whole story;
	/// </remarks>
	internal class Nonordred
		:nilnul.obj_.IXpn
	{
	}
}
