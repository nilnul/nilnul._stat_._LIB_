using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample.distributions
{
	public partial class SinglePoint:DistributionI
	{
		public double _singlePoint;
		public SinglePoint(double singlePoint)
		{
			this._singlePoint = singlePoint;

		}
		public double inverse()
		{
			return _singlePoint;
			throw new NotImplementedException();
		}

		public Prob probability(double upperBound)
		{
			if (upperBound<_singlePoint)
			{
				return Prob.Zero;
				
			}
			return Prob.One;
			throw new NotImplementedException();
		}

		public double inverse(Prob prob)
		{
			return _singlePoint;
			throw new NotImplementedException();
		}
	}
}
