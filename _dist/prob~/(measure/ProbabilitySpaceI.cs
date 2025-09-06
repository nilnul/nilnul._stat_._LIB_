using System;
using System.Collections.Generic;

namespace nilnul.prob
{
	/// <summary>
	/// ProbabilitySpace 的摘要说明。
	/// </summary>
	public partial interface ProbabilitySpaceI<T>
	{
		HashSet<T> sampleSpace
		{
			get;
		}

		

	}
}
