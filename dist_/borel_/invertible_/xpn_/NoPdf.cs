using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.invertible_.xpn_
{
	/// <summary>
	/// as this is invertible, so :
	///		:there is no jump from, within range, some number to another; in other words, we exclude the case where there is no x;
	///		: there is no multiple x.
	/// </summary>
	/// <remarks>
	/// rare, uncommon; but there might be some case that we have noPdf, but it's still invertible;
	/// </remarks>
	internal class NoPdf
	{
	}
}
