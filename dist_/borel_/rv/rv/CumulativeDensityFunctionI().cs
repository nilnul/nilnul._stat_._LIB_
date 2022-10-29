using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.realNumber;
using nilnul.collection.set;

namespace nilnul.randomEvent
{
	public partial interface CumulativeDensityFunctionI<TDomain>
		: CumulativeDensityFunctionI
		where TDomain:RealI
		
	{
		Func<TDomain, ValueAcrossZeroOneI> cumulativeDensityFunction
		{
			get;
			set;
		}

		SetI<TDomain> domain
		{
			get;
			set;
		}

	}
}
