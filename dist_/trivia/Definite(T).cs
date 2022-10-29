using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.dist.inst
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



		

	
	}
}
