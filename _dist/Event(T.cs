using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public class Event<TSample>
	{
		private TSample _sample;

		public TSample sample
		{
			get { return _sample; }
			set { 
				_sample=NotNull2<TSample>.EnsureNotNull(value); 
			
			}
		}

		private NotNull2<Prob> _probability;

		public NotNull2<Prob> probability
		{
			get { return _probability; }
			set { _probability = value; }
		}

		

		public Prob probabilityNotNull
		{
			get { return _probability; }
		
		}


			

		public Event(
			NotNull2<TSample> sample,
			NotNull2<Prob> prob
			
		)
		{
			

			_sample = sample;
			_probability = prob;

		}

		public Event(
	TSample sample,
	Prob prob

)
			:this(NotNull2<TSample>.ToNotNull(sample),NotNull2<Prob>.ToNotNull(prob))
		{


			

		}

		public Event(
			TSample sample,
			nilnul.num.rational.Rational_InheritFraction2 prob
			
		)
			:this(sample,new Prob(prob.numerator,prob.denominator))
		{

		}



		public class EqualityComparer :
			
			IEqualityComparer<Event<TSample>> 
	
		
		{


			public bool Equals(Event<TSample> x, Event<TSample> y)
			{
				return object.Equals( x.sample , y.sample) ;
			}

			public int GetHashCode(Event<TSample> obj)
			{
				return obj.sample.GetHashCode();
			}

			
		}

		
	}
}
