﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_
{
	/// <summary>
	/// the sample is an interval, not a single number; a single number is regarded as an interval;
	/// a borel family generated by real intervals.
	/// For simplicity, we include the (-inf, inf), among which some interval can be measured 0 in probability;
	/// </summary>
	/// <remarks>
	/// from this on we can use random varaible (rv), which is in real (-inf, inf), to describe the distribution;
	/// </remarks>
	/// alias:
	///		randomVariable
	///		variate
	///			not variable
	///		rv
	///		borel
	///		continuum
	///			but only borel family of sets; unconstrained family of real may be unmeasurable (abnormal);
	public interface IBorel:IDist
	{

	}

	///::::::
	/// discrete
	/// pdf
}
