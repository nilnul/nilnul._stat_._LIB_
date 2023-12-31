using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite._sample._constraint._sum
{

	/// <summary>
	/// 
	/// </summary>
	/// 
	/// <remarks>
	/// Consider countOfItems=5,
	/// consider a line of length at the given Sum. Sample countOfItmes points within the range. 
	/// |--------0---------+---1---+------2-----+----3------+-------4-------+-----5----|
	/// the result[0] will be segment0 above plus segment5.
	/// Let's image we raise a chopper and cut the range randomly, then we chop the line to 5 pieces. So we should cut 4 times, not 5 times.
	/// </remarks>

	public  class ByCut
	{
		static public Random random = new Random();


		static public int[] Exe(
			int countOfItems_positive, int target_wholeNumber)
		{

			var randomizedTorso = new int[countOfItems_positive];

			var post = countOfItems_positive - 1;

			for (int i = 0; i < post; i++)
			{
				randomizedTorso[i] = random.Next(target_wholeNumber);
			}

			Array.Sort(randomizedTorso,0,post);

			int pre = post - 1;

			randomizedTorso[post] = target_wholeNumber - randomizedTorso[pre];


			post--;
			pre--;
			for (; post > 0;)
			{
				randomizedTorso[post] -= randomizedTorso[pre];
				post--;
				pre--;

			}

			return randomizedTorso;
		}

		static public double[] Exe(
			int countOfItems_positive, double target_wholeNumber
		)
		{

			var randomizedTorso = new double[countOfItems_positive];

			var post = countOfItems_positive - 1;

			for (int i = 0; i < post; i++)
			{
				randomizedTorso[i] = random.NextDouble()*(target_wholeNumber);
			}

			Array.Sort(randomizedTorso,0,post);

			int pre = post - 1;

			randomizedTorso[post] = target_wholeNumber - randomizedTorso[pre];


			post--;
			pre--;
			for (; post > 0;)
			{
				randomizedTorso[post] -= randomizedTorso[pre];
				post--;
				pre--;

			}

			return randomizedTorso;
		}

		static public double[] Exe_givenAverage(int countOfItems_positive, double average)
		{
			return Exe(countOfItems_positive, average * countOfItems_positive);
		}



	}
}
