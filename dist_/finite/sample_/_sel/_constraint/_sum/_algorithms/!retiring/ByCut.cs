using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite._sample._constraint._sum.retiring
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 		 随机生成4个任意整数，		然后第五个是10减去前面四个. is not right, for the sum of the aforementioned numbers might exceed.

	/// </remarks>
	public partial class ByCut
	{
		static public Random random = new Random();


		static public int[] Make_usingPreferredMethod(			int countOfItems, int target		) {

			return MakeByCut(countOfItems, target);

				return MakeByDiff(countOfItems, target);
		
		}


		[Obsolete("skrew. early selection will be inclined to be bigger per, say, expectation",true)]
		static public int[] MakeByRecur(int countOfItems_positive, int target_wholeNumber)
		{
			if (countOfItems_positive == 1)
			{
				return new int[] { target_wholeNumber };

			}
			var randomized = random.Next(target_wholeNumber);
			var x = MakeByRecur(countOfItems_positive - 1, target_wholeNumber - randomized);

			return new int[] { randomized }.Concat(x).ToArray();

		}



		/// <summary> 
		/// </summary>
		/// <param name="countOfItems_positive"></param>
		/// <param name="target_wholeNumber"></param>
		/// <returns></returns>
		/// <remarks>
		/// If we generate count-1 items randomly, and then subtract it from the total, we may get a negative number (i.e., the sum of torso might exceed total).
		/// This approach will avoid that
		/// </remarks>

		static public int[] MakeByDiff(int countOfItems_positive, int target_wholeNumber)
		{
			//if (countOfItems_positive==1)
			//{
			//	return new int[] { target_wholeNumber};
			//}
			//var randomizedTorso = new List<int>(countOfItems_positive);
			var randomizedTorso = new int[countOfItems_positive];
			for (int i = 0; i < countOfItems_positive; i++)
			{
				//randomizedTorso[i] = random.Next(target_wholeNumber);//todo: this may throw exception; if so, use "Add". And it did throw an exception
				randomizedTorso[i] = random.Next(target_wholeNumber);
				//randomizedTorso.Add(
				//	random.Next(target_wholeNumber)
				//);
			}
			Array.Sort(randomizedTorso);
			//randomizedTorso.Sort();
			//var r = new int[countOfItems_positive];
			int j=countOfItems_positive-1;
			var max = randomizedTorso[j];
			for (int i = j; i >0; )
			{
				j--;
				randomizedTorso[i] -= randomizedTorso[j];
				i=j;
			
			}
			randomizedTorso[0] +=  target_wholeNumber-max;
			return randomizedTorso;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="countOfItems_positive"></param>
		/// <param name="target_wholeNumber"></param>
		/// 
		/// 
		/// <returns></returns>
		/// <remarks>
		/// Consider countOfItems=5,
		/// consider a line of length at the given Sum. Sample countOfItmes points within the range. 
		/// |--------0---------+---1---+------2-----+----3------+-------4-------+-----5----|
		/// the result[0] will be segment0 above plus segment5.
		/// Let's image we raise a chopper and cut the range randomly, then we chop the line to 5 pieces. So we should cut 4 times, not 5 times.
		/// </remarks>
		static public double[] MakeByDiff(int countOfItems_positive, double target_wholeNumber)
		{
			var randomizedTorso = new double[countOfItems_positive];
			for (int i = 0; i < countOfItems_positive; i++)
			{
				randomizedTorso[i] = random.NextDouble()*(target_wholeNumber);
			}
			Array.Sort(randomizedTorso);

			int j = countOfItems_positive - 1;
			var max = randomizedTorso[j];
			for (int i = j; i > 0;)
			{
				j--;
				randomizedTorso[i] -= randomizedTorso[j];
				i = j;

			}
			randomizedTorso[0] += target_wholeNumber - max;
			return randomizedTorso;
		}
		static public int[] MakeByCut(int countOfItems_positive, int target_wholeNumber)
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

		static public double[] MakeByDiff_cutToSegments(int countOfItems_positive, double target_wholeNumber)
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
		static public double[] MakeByDiff_givenAverage(int countOfItems_positive, double average )
		{
			return MakeByDiff(countOfItems_positive, average * countOfItems_positive);
		}

	}
}
