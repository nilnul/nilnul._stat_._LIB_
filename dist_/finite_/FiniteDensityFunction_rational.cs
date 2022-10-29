using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.prob.discrete
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class FiniteDensityFunction_rational<T>

	{

		private NotNull<nilnul.collection.set.Set<SampleProbability<T>,SampleProbability<T>.EqualityComparer>>	_sampleProbSet;


		public NotNull<nilnul.collection.set.Set<SampleProbability<T>,SampleProbability<T>.EqualityComparer>> sampleProbSet
		{
			get { return _sampleProbSet; }
			set {


				ProbabilitiesSet.SumIsOnePredicate.assert(
					value.val.Select(c => c.probability.val)
				);


				

				_sampleProbSet = value; 
			
			
			}
		}
		

	
					

	}
}
