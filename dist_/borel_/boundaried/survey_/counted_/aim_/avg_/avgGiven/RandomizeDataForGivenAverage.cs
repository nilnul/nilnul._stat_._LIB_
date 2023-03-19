using nilnul.prob.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob._randomize
{
    public class RandomizeDataForGivenAverage
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


		/// <summary>
		/// 看每个与上限的距离有多少单位；把这些单位放到一块，随机找一个单位，放入给定的数值(或者随机产生的值，比如按距离上限的最小值为上限随机产生)。
		/// 然后进行下一轮循环，直到数值放够。
		/// </summary>
		/// <param name="countOfItems"></param>
		/// <param name="AverageTargeted"></param>
		/// <param name="upperBound"></param>
		/// <param name="scoreGrain"></param>
		/// <returns></returns>
		static public double[] MakeByProportionalDistribution(int countOfItems, double AverageTargeted, double upperBound,double scorePerGrain ) {

			///

			var averageGrains = AverageTargeted / scorePerGrain;
			var totalGrains = countOfItems * averageGrains;

			var availableContainerEach =(int) (upperBound / scorePerGrain);


			var availableContainersOfEachItem=new int[countOfItems];
			for (int i = 0; i < availableContainersOfEachItem.Length; i++)
			{
				availableContainersOfEachItem[i] = availableContainerEach;
				
			}

			var totalAvailableContainers = availableContainersOfEachItem.Sum();



			for (int i = 0; i < availableContainersOfEachItem.Sum(); i++)
			{

				
			}





			throw new NotImplementedException();
	
		
		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="countOfItems"></param>
		/// <param name="AverageTargeted"></param>
		/// <param name="upperBound"></param>
		/// <param name="grainDenominator"></param>
		/// <returns></returns>

		static public double[] MakeByShuffle(int countOfItems, double AverageTargeted, double upperBound,double scoreGrain ) {



			double[] r = new double[countOfItems];


	///

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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>

        static public double[] Generate_ByRepeatedlySelectCollector(string[] args)
        {
            const int numberOfRegularGrades = 5;

            double[] scores = new double[numberOfRegularGrades];	//all are initialized to 0s.


            int loopingTimes = 200;
            //double granity=.5;

            double normalScale = 100;

            double normalizedGranity = normalScale / loopingTimes;

            var r = new Random();

            for (int i = 0; i < loopingTimes; i++)
            {
                var sn = r.Next(5);

                scores[sn] += normalizedGranity;

            }


            return scores;






        }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		///		There is a problem with this: the normalized result may exceed max.
		/// </remarks>
		[Obsolete(" the normalized result may exceed max.", true)]
        static public double[] Generate()
        {

            int numberOfRegularGrades = 5;

            double[] scores = new double[numberOfRegularGrades];

            double max = 100;
            Random r = new Random();

            for (int i = 0; i < numberOfRegularGrades; i++)
            {

                var t = r.Next((int)max);
                scores[i] = t;

            }

            var total = scores.Sum();

            for (int i = 0; i < numberOfRegularGrades; i++)
            {


                scores[i] = scores[i] / total * max;

            }

            return scores;


        }

        /// <summary>
        /// Generate random numbers and then normalize to target sum.
        /// </summary>
        /// <param name="targetGrade"></param>
        /// <param name="lowerbound__noMoreThanTarget"></param>
        /// <param name="upperbound__noLessThanTarget"></param>
        /// <param name="countOfScores__naturalNumber"></param>
        /// <returns></returns>
        static public double[] __Generate_byRandomizeThenNormalize(double targetGrade, double lowerbound__noMoreThanTarget = 0, double upperbound__noLessThanTarget = 100, int countOfScores__naturalNumber = 5)
        {


            Random r = new Random();

            var result = new double[countOfScores__naturalNumber];
            var span = upperbound__noLessThanTarget - lowerbound__noMoreThanTarget;

            for (int i = 0; i < countOfScores__naturalNumber; i++)
            {

                var t = r.NextDouble();

                result[i] = lowerbound__noMoreThanTarget + t * span;

            }

            var total = result.Sum();
            for (int i = 0; i < countOfScores__naturalNumber; i++)
            {


                result[i] = result[i] / total;

            }

            return result;


        }


        static public IEnumerable<double[]> GenerateForList_byRandomizeThenNormalize(double[] targetGrades, double lowerbound = 0, double upperbound = 100, int countOfScores = 5)
        {

            //  var result = new double[targetGrades.Length, countOfScores];

            foreach (var item in targetGrades)
            {
                yield return __Generate_byRandomizeThenNormalize(item, lowerbound, upperbound, countOfScores);

            }



        }

        static public double[] __Generat_byRandomizeThenNormalize(double target, int countOfScores = 5)
        {
            var interval = Interval(target);
            return __Generate_byRandomizeThenNormalize(target, interval.Item1, interval.Item2, countOfScores);
        }

        static public IEnumerable<double[]> __Generate_(double[] targetGrades_allNonNegative,int countOfScores=5)
        {



            foreach (var item in targetGrades_allNonNegative)
            {
                yield return __Generat_byRandomizeThenNormalize(item,countOfScores);

            }


        }




        static public Tuple<double, double> Interval(double score)
        {
            if (score > 85)
            {
                return new Tuple<double, double>(80, 100);

            }
            if (score > 80)
            {
                return new Tuple<double, double>(75, 95);


            }
            if (score > 65)
            {
                return new Tuple<double, double>(60, 90);

            }

            if (score > 20)
            {
                return new Tuple<double, double>(score - 15, score + 25);

            }
            return new Tuple<double, double>(0, 50);

            throw new NotImplementedException();



        }


    }
}
