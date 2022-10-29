using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.continuum._sample._constrained._sum._algos
{


	public partial class RandomizeThenNormalize
	{
		static public Random random = new Random();



		/// <summary>
		/// 随便rand5个数，加起来为N，然后每个数*100/N……处理一下向下或向下取整保证和为100.

		/// </summary>
		/// 
		static public double[] Exe(int countOfItems, double target)
		{
			var r=new double[countOfItems];
			for (int i = 0; i < countOfItems; i++)
			{
				r[i] = random.NextDouble() * target;
			
			}

			var sum = r.Sum();

			for (int i = 0; i < countOfItems; i++)
			{
				r[i] = r[i]*target/ sum;
				
			}
			return r;



		}


	}
}
