using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.prob.rationalProb
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class DensityFunction<TSample>
	{
		private NotNull<nilnul.collection.set.Set<Event<TSample>,Event<TSample>.EqualityComparer>>	_samples;
		public NotNull<nilnul.collection.set.Set<Event<TSample>,Event<TSample>.EqualityComparer>> samples
		{
			get { return _samples; }
			set {
				ProbSet.SumIsOnePredicate.assert(
					value.val.Select(c => c.probability.val)
				);
				_samples = value; 
			}
		}

		static public void AssertSumIsOne(

			
		) { 

		
		}
		public DensityFunction(
			nilnul.collection.set.Set<Event<TSample>, Event<TSample>.EqualityComparer> samples
		)
		{
			this.samples = samples;
			
		}

		public DensityFunction(IEnumerable<Event<TSample>> samples)
			:this(new nilnul.collection.set.Set<Event<TSample>,Event<TSample>.EqualityComparer>(samples))
		{
		}

		static public nilnul.bit.Predicate<IEnumerable<Prob>> SumIsOnePredicate = new bit.Predicate<IEnumerable<Prob>>(SumIsOne);


		

		static public bool SumIsOne(IEnumerable<Prob> probs)
		{
			return nilnul.num.rational.set.SumX.Sum(probs) == 1

			;

		}


		static public bool SumIsOne<T>(IEnumerable<Event<T>> events)
		{
			return SumIsOne( events.Select(c => c.probabilityNotNull));

		}

		static public void SumIsOneAssert<T>(IEnumerable<Event<T>> events)
		{
			 nilnul.bit.Assert.True(SumIsOne(events));

		}
					
					
	}
}
