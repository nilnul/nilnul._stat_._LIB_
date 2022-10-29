using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.finite
{
	public partial class Definite<T>

	
		
	{
		private T _mean;

		public T mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public Definite(T mean)
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
