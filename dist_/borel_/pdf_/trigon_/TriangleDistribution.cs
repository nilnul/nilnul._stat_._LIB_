using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics
{

	/// <summary>
	/// this distribution is implemented using double.
	/// </summary>
	public partial class TriangleDistribution
	{
		public double min;
		public double max;
		public double modal;
		public TriangleDistribution(double min,double modal,double max)
		{
			if (modal>=max)
			{
				throw new Exception();
				
			}
			if (modal<=min)
			{
				throw new Exception();
				
			}
			this.min = min;
			this.max = max;
			this.modal = modal;

		}

		public double density(double x) {

			if (x<=min)
			{
				return 0;

			}
			else if(x<=modal)
			{
				return 2 * (x - min) / (modal - min) / (max - min);

			}
			else if(x<max)
			{
				return 2 * (max - x) / (max - min) / (max - modal);

			}
			else
			{
				return 0;
			}
		}

		public double cdf(double x) {

			if (x <= min)
			{
				return 0;

			}
			else if (x <= modal)
			{
				return  (x - min)*(x-min) / (modal - min) / (max - min);

			}
			else if (x < max)
			{
				return  1-(max - x)*(max-x) / (max - min) / (max - modal);

			}
			else
			{
				return 1;
			}
 
		
		}

		public double mean() {
			return (min + modal + max) / 3;
		}

		public double variance() {
			return (min * min + modal * modal + max * max - min * modal - modal * max - max * min) / 18;
		}

		public double entropy() {
			return 1.0 / 2 + Math.Log((max - min) / 2);
		}
	}
}
