using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.rationalSample
{
	public partial class CumulativeDensitySequence
	{

		public Prob.OrderedSquence cumulativeDensities;


		public CumulativeDensitySequence(Prob.OrderedSquence value)
		{

			nilnul.bit.Assert.True(value.list.Last() == 1);

			cumulativeDensities = value;
		}
					
		

	

		
	}
}
