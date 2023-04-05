using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist._evt
{
	/// <summary>
	/// <see cref="IDist"/> is a measure; the underlying field(family of set) is called evtSpace, and a set from the family is called evt, and a member from the set is called sample;
	/// 
	/// </summary>
	/// <remarks>
	/// Sample means the type of the member of the set; a collection of the sets is the evtSpace, where measure is defined: we map the set to a magnitude|amount;
	/// </remarks>
	/// alias:
	///		specimen
	///			avoid conflict with <see cref="stat._dist_.ISample"/>
	internal class ISample
	{
	}
}
