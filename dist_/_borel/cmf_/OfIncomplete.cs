using System;

namespace nilnul.stat.dist_._borel.cmf_
{
	/// <summary>
	/// for x, output the prob of [-inf,x]
	/// </summary>
	/// <remarks>
	/// we cumulate the prob of [-inf,x] as x grows large, or in other words, the interval keeps merging next larger values;
	/// </remarks>
	public interface IOfIncomplete:ICmf { }

}
