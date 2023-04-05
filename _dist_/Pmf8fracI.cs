using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist_
{
	
	public interface Pmf8fracI<TEvent>
		:_PmfI<TEvent,
			//nilnul.num.real_.Quotient
			nilnul.num.quotient_.DenomNonnilI
		>
	{
	}


}
