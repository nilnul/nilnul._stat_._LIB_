using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_._scoped_.scope_
{
	/// <summary>
	/// take a union of disjoint intervals as <see cref="Scope4dblI"/>
	/// support; outside this, the measure is zero;
	/// </summary>
	/// alias:
	///		scope
	///		constraint
	///		support
	public interface OfIntervals4DblI
		:
		_scoped_.IScope
		
	{
		/// <summary>
		/// 
		/// </summary>
		/// returned is a str or a stream? or either will do?
		IEnumerable<		nilnul.num.real.ext.Bound4dbl> scope { get; }

	}
}
