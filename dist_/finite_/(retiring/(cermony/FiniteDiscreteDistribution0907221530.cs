using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics
{
	public partial class FiniteDiscreteDistribution
		:DistributionI
	{
		private decimal[] _samples;

		public decimal[] samples
		{
			get { return _samples; }
			set { _samples = value; }
		}
		private decimal[] _probabilities;

		public decimal[] probabilities
		{
			get { return _probabilities; }
			set { _probabilities = value; }
		}
		
		

		public FiniteDiscreteDistribution(decimal[] samples,decimal[] probabilities)
		{
			if (probabilities.Sum() != 1) {
				throw new Exception();
			}
			this.samples = samples;
			this.probabilities = probabilities;

		}


	
	}
}
