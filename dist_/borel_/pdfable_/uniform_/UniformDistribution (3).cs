using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.statistics.distribution;
using nilnul.number.real;
using nilnul.statistics.randomVariable;
using nilnul.set.interval;

using nilnul.set;

namespace nilnul.statistics.distribution
{
	public interface IUniformDistribution
		:IContinousDistrituion 
	{ 
		
	}

	public class UniformDistribution:ContinuousDistribution,
		IUniformDistribution
	{
		private IReal _left, _right;
		public UniformDistribution(IReal left, IReal right ) {
			if(left>=right){
				throw new Exception();
			}
			_left = left;
			_right = right;

		}

		public IReal left {
			get {
				return _left;
			}
		}

		public IReal right {
			get {
				return _right;
			}
		}

		/// <summary>
		/// where the density function returns 0.
		/// </summary>
		public OpenInterval<Real> domain {
			get {
				return new OpenInterval<Real>(left,right);
			}

		}

		public NonnegativeReal density(IReal x) { 

			if(domain.Contains(x)){
				return 1/(right-left);
			}
			

		}

		public IReal mean
		{
			get
			{
				return (left + right) / 2;
			}
		}

		public IReal variance
		{
			get
			{
				return ((right - left) ^ 2) / 12;
			}
		}


	}
}
