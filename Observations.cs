using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat
{
	public partial class Observations
	{
		static public Tuple<double, double> GetMeanVar(
			IEnumerable<double> observations
			
		) {
			if (observations.Count()==1)
			{
				return new Tuple<double, double>(observations.ElementAt(0), 0);
				
			}

			var mean = observations.Average();
			var var = observations.Select(
					c => Math.Pow((c - mean), 2)
				).Sum()
				/
				observations.Count()
			;

			return new Tuple<double, double>(mean, var);
		
		}
	}
}
