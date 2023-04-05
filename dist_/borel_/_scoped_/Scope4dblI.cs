using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_._scoped_
{
	/// <summary>
	/// support; outside this, the measure is zero;
	/// </summary>
	/// alias:
	///		scope
	///		constraint
	///		support
	public interface Scope4dblI
		
	{
		nilnul.num.real.Interval4dbl scope { get; }

	}
}
