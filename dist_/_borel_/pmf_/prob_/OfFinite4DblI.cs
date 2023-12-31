using System;

namespace nilnul.stat.dist_._borel_.prob_
{
	[Obsolete(nameof(pmf_))]
	public interface OfFinite4DblI
		:
		Prob4dblI<num.real.Interval4dbl> // (-inf, inf) not includes inf, all being finite;
	{

	}



}
