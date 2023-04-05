using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel.cdf
{
	/// <summary>
	/// we need to have <see cref="ICdf"/> first, before we can derive this;
	/// note here if the <see cref="ICdf"/>'s range is [0,1], and we don't need it's derivable when the y value is outside that range;
	///		in otherwords, we need in the domain boundary, the density is all positive;
	/// </summary>
	public interface IStricGrowInBound
	{
	}
}
