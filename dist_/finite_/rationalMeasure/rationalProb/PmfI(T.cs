using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{

	/// <summary>
	/// <![CDATA[As put.]]>
	/// </summary>
	/// <remarks>(“probability law”,“probability distribution”)</remarks>
	/// 
	public partial interface PmfI<T>
	{
		Prob probability(T x);

	}
}
