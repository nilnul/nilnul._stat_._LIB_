using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">var(real)</typeparam>
	/// <remarks>
	/// 
	/// </remarks>

	public partial class ExponientialDistribution<T>
		:DistributionI
		
	{
		private T _rate;

		public T rate
		{
			get { return _rate; }
			set { _rate = value; }
		}
		



		public ExponientialDistribution(T rate)
		{
			this.rate = rate;

		}




		public double generate()
		{
			throw new NotImplementedException();
		}
	}
}
