using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.statistics;
using nilnul.statistics.distribution;

namespace nilnul.statistics.estimate
{
	class Program
	{
		static public void Main() {

			Sample sample = new Sample(
				new double[]{
					40,
					34,23,40,31,33,49,33,34,43,26,39
				},
				new NormalDistribution()
			);
			
		}
	}
}
