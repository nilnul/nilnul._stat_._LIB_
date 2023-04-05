using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.algorithm.regularGradeGenerator
{
    public class Generator
    {


		static public double[] Gen_byAdjustment(double target,int countOfRegulars=5,int iterationTimes=100,double max=100,double min=0,double step=.5) {


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



		static public double[] Gen_adjustInVariance(double target, int countOfRegulars = 5, int iterationTimes = 100, double max = 100, double min = 0, double step = .5, double variancePercentage = .2)
		{

			return Gen_byAdjustment(target,countOfRegulars,iterationTimes,Math.Min(max,target*(1+variancePercentage)),Math.Max(min,target*(1-variancePercentage)));

			throw new NotImplementedException();

		}

		static public double[,] Gen_adjustInVariance(double[] targets, int countOfRegulars = 5)
		{
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Gen_adjustInVariance(targets[i], countOfRegulars);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];

				}

			}


			return results;
			throw new NotImplementedException();



		}

		static public double[,] Gen_adjustInVariance(double[] targets, int countOfRegulars = 5,int iterations=100,double max=100)
		{
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Gen_adjustInVariance(targets[i], countOfRegulars,iterations,max);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];

				}

			}


			return results;
			throw new NotImplementedException();



		}
		


		static public double[,] Gen_adjustment(double[] targets,int countOfRegulars=5) {
			double[,] results = new double[targets.Length, countOfRegulars];

			for (int i = 0; i < results.GetLength(0); i++)
			{
				var result = Gen_byAdjustment(targets[i], countOfRegulars);

				for (int j = 0; j < result.Length; j++)
				{
					results[i, j] = result[j];
					
				}
				
			}


			return results;
			throw new NotImplementedException();

			
		
		}


        static public double[] Generate_ByRepeatedlySelectCollector(string[] args)
        {
            const int numberOfRegularGrades = 5;

            double[] scores = new double[numberOfRegularGrades];	//all is init'ed to 0s.


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

        static public double[] Generate()
        {

            int numberOfRegularGrades = 5;

            double[] scores = new double[numberOfRegularGrades];

            double normalScale = 100;
            Random r = new Random();

            for (int i = 0; i < numberOfRegularGrades; i++)
            {

                var t = r.Next((int)normalScale);
                scores[i] = t;

            }

            var total = scores.Sum();

            for (int i = 0; i < numberOfRegularGrades; i++)
            {


                scores[i] = scores[i] / total * normalScale;

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
        static public double[] __Gen(double targetGrade, double lowerbound__noMoreThanTarget = 0, double upperbound__noLessThanTarget = 100, int countOfScores__naturalNumber = 5)
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


        static public IEnumerable<double[]> Gen(double[] targetGrades, double lowerbound = 0, double upperbound = 100, int countOfScores = 5)
        {

            //  var result = new double[targetGrades.Length, countOfScores];

            foreach (var item in targetGrades)
            {
                yield return __Gen(item, lowerbound, upperbound, countOfScores);

            }



        }

        static public double[] __Gen(double target, int countOfScores = 5)
        {
            var interval = Interval(target);
            return __Gen(target, interval.Item1, interval.Item2, countOfScores);
        }

        static public IEnumerable<double[]> __Gen(double[] targetGrades_allNonNegative,int countOfScores=5)
        {



            foreach (var item in targetGrades_allNonNegative)
            {
                yield return __Gen(item,countOfScores);

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
