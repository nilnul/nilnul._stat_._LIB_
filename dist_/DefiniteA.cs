using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_
{
	public  class DefiniteA<T>
		:nilnul.stat.DistI<T>
		
	{
		private T _mean;

		public T mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public DefiniteA(T mean)
		{
			this.mean = mean;
		}

		public T sample()
		{
			return _mean;
		}

	}
}
