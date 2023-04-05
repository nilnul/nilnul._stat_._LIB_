using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.discrete
{
	public struct SampleProbability<TSample>
	{
		private TSample _sample;

		public TSample sample
		{
			get { return _sample; }
			set { 
				_sample=NotNull2<TSample>.EnsureNotNull(value); 
			
			}
		}



		private NotNull2<ProbabilityInRational> _probability;

		public NotNull2<ProbabilityInRational> probability
		{
			get { return _probability; }
			set { _probability = value; }
		}

			

		public SampleProbability(
			NotNull2<TSample> sample,
			NotNull2<ProbabilityInRational> prob
			
		)
		{
			

			_sample = sample;
			_probability = prob;

		}

		public SampleProbability(
	TSample sample,
	ProbabilityInRational prob

)
			:this(NotNull2<TSample>.ToNotNull(sample),NotNull2<ProbabilityInRational>.ToNotNull(prob))
		{


			

		}



		public class EqualityComparer :
			
			IEqualityComparer<SampleProbability<TSample>> 
	
		
		{


			public bool Equals(SampleProbability<TSample> x, SampleProbability<TSample> y)
			{
				return object.Equals( x.sample , y.sample) ;
			}

			public int GetHashCode(SampleProbability<TSample> obj)
			{
				return obj.sample.GetHashCode();
			}

			
		}

		
	}
}
