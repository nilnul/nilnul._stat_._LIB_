using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.continuum.randomize
{


	public partial class GivenSum
	{
		static public Random random = new Random();


		static public double[] Make_usingPreferredMethod(			int countOfItems, double target		) {
				return MakeByRandomizeThenNormalize(countOfItems, target);
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countOfItems"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		/// 
		[Obsolete("this has not yet been proved correct. The first's expectation is half the target, so the sample maybe skewed",true)]
		static public double[] MakeByRecur(int countOfItems, double target)
		{
			if (countOfItems == 1)
			{
				return new double[] { target };

			}
			var randomized = random.NextDouble() * target;
			var x = MakeByRecur(countOfItems - 1, target - randomized);

			return new double[] { randomized }.Concat(x).ToArray();

		}


		/// <summary>
		/// 随便rand5个数，加起来为N，然后每个数*100/N……处理一下向下或向下取整保证和为100.

		/// </summary>
		/// 
		static public double[] MakeByRandomizeThenNormalize(int countOfItems, double target)
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
