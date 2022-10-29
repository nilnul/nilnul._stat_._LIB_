using nilnul.prob.discrete;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.prob.rationalProb.rationalSample
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class DensityFunction
		:DensityFunction<nilnul.num.rational.Rational_InheritFraction>

	{

		public DensityFunction(
			IEnumerable<Event> samples
		)
			:base(samples)
		{
			EmptyX.PredicateOfIEnumerable.reject(samples);

		}

	
					
		

	
					

	}
}
