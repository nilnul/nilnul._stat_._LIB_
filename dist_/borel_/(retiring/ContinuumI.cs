﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob
{
	/// <summary>
	/// the continuum distribtion. a density over all real numbers (for non-support, the density is zero); we only consider Borel sets. 
	/// </summary>
	public interface ContinuumI
	{

		 nilnul.num.real.Interval support
		{
			get;
		}
	}
}
