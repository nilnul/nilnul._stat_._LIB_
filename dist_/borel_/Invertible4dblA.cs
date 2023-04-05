using nilnul.num.real.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_
{
	public abstract  class Invertible4dblA
		:Invertible4dblI
	{
		Random rnd = new Random();
		public double sample()
		{
			return invert(

				rnd.NextDouble()
			//	prob.RandomX.NextDouble()

				);
		}

	

		public abstract double cdf(double upperBound);


		/// <summary>
		/// use binary search and power search
		/// </summary>
		/// <param name="prob"></param>
		/// <returns></returns>
		public abstract double invert(double prob);
		public abstract double pmf(Bound4dbl sample);
	}
}
