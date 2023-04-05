using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdf_._normal_
{
	/// <summary>
	///	using a Box-Muller transform is good for a quick-and - dirty solution.A simple implementation:
 
	/// </summary>
	class Sample
	{
		Random rand = new Random(); //reuse this if you are generating many

		public double sample(double mean, double stdDev)
		{



			double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
			double u2 = 1.0 - rand.NextDouble();
			double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
						 Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
			double randNormal =
						 mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)

			return randNormal;
		}
	}

}
