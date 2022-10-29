using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_._empirical
{
	/// <summary>
	/// if we want the Cdf curve to be contiguous, we must have one at the begining, the prob of which is nil.
	/// If there is one at the beginning, the prob of which is nil, then there may be extrapopulated prob for elements preceding to the first one..
		/// if the first one is not nil in prob, then we may consider to prepend one:
		///		(first one el)- epsilon, the prob of this is nil.
		///		where empsilon is a very small positive number.
		///		the empislon can be calculated as:
		///			span/ cardinality, if span is not nil.
	///			
	/// </summary>
	class FiniteCumulable
	{

	}
}
