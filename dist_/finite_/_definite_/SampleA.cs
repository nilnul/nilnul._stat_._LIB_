using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.finite_._definite_
{
	public abstract class SampleA<T>
		:nilnul.stat._dist_.SampleI<T>
		
	{
		private T _mean;

		public T mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public SampleA(T mean)
		{
			this.mean = mean;
		}

		public T sample()
		{
			return _mean;
		}

	}
}
