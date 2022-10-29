using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb
{
	/// <summary>
	/// This is useful because it puts deterministic variables and random variables in the same formalism.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Degenerate<T>

	
		
	{
		private T _mean;

		public T mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public Degenerate(T mean)
		{
			this.mean = mean;
		}





		public double density(T sample)
		{
			if (object.Equals( sample,mean))
			{
				return 1;
				
			};
			return 0;
		}

		
	}
}
