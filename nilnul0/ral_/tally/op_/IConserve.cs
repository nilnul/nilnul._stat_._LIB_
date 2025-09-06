using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.ral_.tally.op_
{
	/// <summary>
	/// conserve the order:
	///  if x < y, then f(x) < f(y).
	///  ; that is distinct values are mapped distinctly;
	/// </summary>
	public interface IConserve
		: nilnul.num.real.IFn
		,
		nilnul.ral_.tally.IOp
		//nilnul.num.real.fn_.grow_
    {
    }
}
