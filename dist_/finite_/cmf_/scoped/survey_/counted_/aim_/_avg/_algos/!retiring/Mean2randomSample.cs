using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.finite.measures.rational.algorithms
{
	[Obsolete()]
    public class Mean2randomSample
    {
		/// <summary>
		/// 看每个与上限的距离有多少单位；把这些单位放到一块，随机找一个单位，放入一定的数值。
		/// 然后进行下一轮循环，直到数值放够。
		/// </summary>
		/// <param name="countOfItems"></param>
		/// <param name="AverageTargeted"></param>
		/// <param name="upperBound"></param>
		/// <param name="scoreGrain"></param>
		/// <returns></returns>
		static public double[] MakeByProportionalContinualDistribution(int countOfItems, double AverageTargeted, double upperBound,double scoreGrain ) {

			///



			throw new NotImplementedException();
	
		
		}


		static public double[,] ByProportionDistribute(
			double[] targets, int countOfRegulars = 5, double max = 100, double grain = .5
			
		) {


			double[,] r = new double[targets.Length, countOfRegulars];
			 
			for (int i = 0; i < targets.Length; i++)
			{
				var sample = ByProportionDistribute(targets[i], countOfRegulars,  max,grain);

				for (int j = 0; j < countOfRegulars; j++)
				{
					r[i, j] = sample[j];

				}

			}


			return r;
			throw new NotImplementedException();



		
		
		}


		/// <summary>
		/// 看每个与上限的距离有多少单位；把这些单位放到一块，随机找一个单位，放入给定的数值(或者随机产生的值，比如按距离上限的最小值为上限随机产生)。
		/// 然后进行下一轮循环，直到数值放够。
		/// </summary>
		/// <param name="sampleCardinal"></param>
		/// <param name="averageTargeted"></param>
		/// <param name="scoreMax"></param>
		/// <param name="scoreGrain"></param>
		/// <returns></returns>
		static public double[] ByProportionDistribute(double averageTargeted,int sampleCardinal,  double scoreMax, double scorePerGrain ) {


			var grainsOfEachOutcome = ByProportionDistribute(
				(int) ( averageTargeted / scorePerGrain),sampleCardinal,  (int) (scoreMax / scorePerGrain)
			);

			

			var r = new double[sampleCardinal];


			for (int i = 0; i < sampleCardinal; i++)
			{
				r[i] = grainsOfEachOutcome[i] * scorePerGrain;
				
			}
			return r;

			throw new NotImplementedException();
	
		
		}


		static public int[] ByProportionDistribute(int averageTargeted,int sampleCardinal,  int scoreMax) {

			var totalGrains = sampleCardinal * averageTargeted;
			var availableSpaceOfEachOutcome=new int[sampleCardinal];

			for (int i = 0; i < sampleCardinal ; i++)
			{
				availableSpaceOfEachOutcome[i] = scoreMax;
			}

			for (int i = 0; i <totalGrains; i++)
			{
				availableSpaceOfEachOutcome[ Sample_froBagOfIntMeasure.RandomSelect(availableSpaceOfEachOutcome) ]--;
			}

			var r = new int[sampleCardinal];

			for (int i = 0; i < sampleCardinal; i++)
			{
				r[i] = (scoreMax - availableSpaceOfEachOutcome[i]);
			}
			return r;
			throw new NotImplementedException();
		}

		static public double[,] ByShuffle(double[] meanTarget, int sampleSize = 5, double max = 100, double grainSize = .5)
		{

			var r = new double[meanTarget.Length, sampleSize];


			for (int i = 0; i < r.GetLength(0); i++)
			{
				var result = ByShuffle1(meanTarget[i], sampleSize, max, grainSize);

				for (int j = 0; j < result.Length; j++)
				{
					r[i, j] = result[j];

				}

			}


			return r;

		}
		static public double[,] ByShuffle1(double[] meanTarget, int sampleSize = 5, double max = 100, double grainSize = .5)
		{

			var r = new double[meanTarget.Length, sampleSize];


			for (int i = 0; i < r.GetLength(0); i++)
			{
				var result = ByShuffle1(meanTarget[i], sampleSize, max, grainSize);

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

		static public double[] ByShuffle(int countOfItems, double AverageTargeted, double upperBound,double scoreGrain ) {

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
		static public double[] ByShuffle1(double AverageTargeted, int countOfItems, double upperBound, double scoreGrain)
		{

			double[] r = new double[countOfItems];
			var grainsAveraged_EachItem = (int)(AverageTargeted / scoreGrain);

			var receivers_CountOfEachItem = (int)(upperBound / scoreGrain);

			var intResult = ByShuffle(countOfItems, grainsAveraged_EachItem, receivers_CountOfEachItem);



			for (int i = 0; i < countOfItems; i++)
			{

				r[i] = intResult[i] * scoreGrain;


			}


			return r;



		}

		static public int[] ByShuffle(int countOfItems, int AverageTargeted, int upperBound)
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

			Shuffle.KnuthShuffle(receivers,RandomX.random);
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="target"></param>
		/// <param name="countOfRegulars"></param>
		/// <param name="iterationTimes"></param>
		/// <param name="max"></param>
		/// <param name="min"></param>
		/// <param name="step"></param>
		/// <returns></returns>

		static public double[] Generate_byAdjustment(double target,int countOfRegulars=5,int iterationTimes=100,double max=100,double min=0,double step=.5) {


			double[] result = new double[countOfRegulars];

			for (int i = 0; i < result.Length; i++)
			{
				result[i] = target;
				
			}

			Random r = new Random();

			int repeatedTimes = iterationTimes;

			for (int j = 0; j < repeatedTimes; j++)
			{
				var selected=r.Next(countOfRegulars);
				var next = (r.Next(countOfRegulars - 1)+selected)%countOfRegulars;

				var leftUpperAllow = max - result[selected];
				var leftLowerAllow = result[selected] - min;

				var rightUpperAllow = max - result[next];
				var rightLowerAllow = result[next] - min;

				var leftToRightAllow = Math.Min(leftLowerAllow, rightUpperAllow);
				var rightToLeftAllow = Math.Min(rightLowerAllow, leftUpperAllow);

				var totalAllow = leftToRightAllow + rightToLeftAllow;
				var totalAllowSteps=(int)(totalAllow/step);

				var shift = (r.Next(totalAllowSteps+1))*step-leftToRightAllow;

				if (shift>0)
				{
					result[selected] += shift;
					result[next] -= shift;

				}
				else
				{
					result[selected]+= shift;
					result[next] -= shift;
				}



			}

			return result;

			throw new NotImplementedException();
		
		}



		static public double[] Generate_adjustInVariance(double target, int countOfRegulars = 5, int iterationTimes = 100, double max = 100, double min = 0, double step = .5, double variancePercentage = .2)
		{

			return Generate_byAdjustment(target,countOfRegulars,iterationTimes,Math.Min(max,target*(1+variancePercentage)),Math.Max(min,target*(1-variancePercentage)));

			throw new NotImplementedException();

		}



		static public double[,] GenerateForList_adjustInVariance(double[] targets, int countOfRegulars = 5)
		{
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Generate_adjustInVariance(targets[i], countOfRegulars);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];

				}

			}


			return results;
			throw new NotImplementedException();



		}

		static public double[,] GenerateForList_adjustInVariance(double[] targets, int countOfRegulars = 5,int iterations=100,double max=100)
		{
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Generate_adjustInVariance(targets[i], countOfRegulars,iterations,max);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];

				}

			}


			return results;
			throw new NotImplementedException();



		}
		


		static public double[,] GenerateForList_byAdjustment(double[] targets,int countOfRegulars=5) {
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Generate_byAdjustment(targets[i], countOfRegulars);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];
					
				}
				
			}


			return results;
			throw new NotImplementedException();

			
		
		}

	





      


    }
}
