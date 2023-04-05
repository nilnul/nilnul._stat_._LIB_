using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Measure = nilnul.prob._measure.Double;

namespace nilnul.prob
{
	/// <summary>
	/// a prob on finite set such that we can measure the elements in the set.
	/// </summary>
	public class FiniteD_eqDynam<T,TEq>
		:Dictionary<T,_measure.Double>
		where TEq:IEqualityComparer<T>
	{

		public FiniteD_eqDynam(Dictionary<T,Measure> dict, TEq eq)
			:base(new Dictionary<T,Measure>(dict),eq)
		{
			nilnul.prob.measure.OmegaD.AssertSumIsOne(this.Values);
		}



	}


	public class FiniteD<T,TEq>
		:FiniteD_eqDynam<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		public FiniteD(Dictionary<T,Measure> dict)
			:base(new Dictionary<T,Measure>(dict),SingletonByDefault<TEq>.Instance)
		{
		}



	}



}
