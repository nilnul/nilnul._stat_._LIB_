using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._prob_
{
	public interface MeasureI<TEvt>
	{
		Func<TEvt, nilnul.num.real_.NonnegI> measure { get; }
	}
}
