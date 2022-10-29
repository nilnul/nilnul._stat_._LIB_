using nilnul.prob.dist._finite._sel._algos._shuffle;
using nilnul.prob.finite.measures.rational.algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.dist._finite._sel._constraint._boundSum._algos
{
	public class ByShuffleg
    {
		
		
		static public double[,] Exe_givenMean(double[] meanTarget, int sampleSize = 5, double max = 100, double grainSize = .5)
		{

			var r = new double[meanTarget.Length, sampleSize];


			for (int i = 0; i < r.GetLength(0); i++)
			{
				var result = Exe_givenMean(meanTarget[i], sampleSize, max, grainSize);

				for (int j = 0; j < result.Length; j++)
				{
					r[i, j] = result[j];

				}

			}


			return r;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="countOfItems"></param>
		/// <param name="AverageTargeted"></param>
		/// <param name="upperBound"></param>
		/// <param name="grainDenominator"></param>
		/// <returns></returns>

		static public double[] Exe_givenMean(int countOfItems, double AverageTargeted, double upperBound,double scoreGrain ) {

			double[] r = new double[countOfItems];

			var receivers_CountOfEachItem= (int) (upperBound/scoreGrain);

			var receivers_Total = receivers_CountOfEachItem * countOfItems;



			var grainsAveraged_EachItem= (int) ( AverageTargeted  / scoreGrain);


			var grainsCount_total = grainsAveraged_EachItem * countOfItems ;



			double[] receivers=new double[receivers_Total];


			for (int i = 0; i < receivers_Total; i++)
			{
				if (i%receivers_CountOfEachItem <grainsAveraged_EachItem )
				{
					receivers[i] = scoreGrain;
					
				}

				
			}

			Shuffle.KnuthShuffle(receivers);
			var start = 0;
			for (int i = 0; i < r.Length; i++)
			{

				for (int j = 0; j < receivers_CountOfEachItem; j++)
				{
					r[i] += receivers[start];
					start++;
				
				}

				
			}


			return r;

	
		
		}
		static public double[] Exe_givenMean(double AverageTargeted, int countOfItems, double upperBound, double scoreGrain)
		{

			double[] r = new double[countOfItems];
			var grainsAveraged_EachItem = (int)(AverageTargeted / scoreGrain);

			var receivers_CountOfEachItem = (int)(upperBound / scoreGrain);

			var intResult = Exe_givenMean(countOfItems, grainsAveraged_EachItem, receivers_CountOfEachItem);



			for (int i = 0; i < countOfItems; i++)
			{

				r[i] = intResult[i] * scoreGrain;


			}


			return r;



		}

		static public int[] Exe_givenMean(int countOfItems, int AverageTargeted, int upperBound)
		{


			var receivers_Total = upperBound * countOfItems;

			var grainsCount_total = AverageTargeted * countOfItems;

			int[] receivers = new int[receivers_Total];

			for (int i = 0; i < receivers_Total; i++)
			{
				if (i % upperBound < AverageTargeted)
				{
					receivers[i] = 1;

				}
			}
			Knuth.Exe(receivers, RandomX.random);
		//	Shuffle.KnuthShuffle(receivers,RandomX.random);
			int[] r = new int[countOfItems];
			var start = 0;
			for (int i = 0; i < r.Length; i++)
			{
				for (int j = 0; j < upperBound; j++)
				{
					r[i] += receivers[start];
					start++;
				}
			}

			return r;
		}

		
	





      


    }
}
