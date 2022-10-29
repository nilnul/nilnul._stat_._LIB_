using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb
{
	public partial class Definite<T>
		:PmfI<T>
	
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





		public Prob density(T sample)
		{
			if (object.Equals( sample,mean))
			{
				return Prob.One;
				
			};
			return Prob.Zero;
		}



		public Prob probability(T x)
		{
			if (EqualityComparer<T>.Default.Equals(x, mean)) {
				return Prob.One;
			}
			return Prob.Zero;
		}
	}
}
