using nilnul.prob.finite.measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.dist._finite._sel._constraint._boundSum._algos
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
    public class ByProportionalSelect
    {
		

		static public double[,] Exe_givenMean(
			double[] targets, int countOfRegulars = 5, double max = 100, double grain = .5
			
		) {


			double[,] r = new double[targets.Length, countOfRegulars];
			 
			for (int i = 0; i < targets.Length; i++)
			{
				var sample = Exe_givenMean(targets[i], countOfRegulars,  max,grain);

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
		static public double[] Exe_givenMean(double averageTargeted,int sampleCardinal,  double scoreMax, double scorePerGrain ) {


			var grainsOfEachOutcome = Exe_givenMean(
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


		static public int[] Exe_givenMean(int averageTargeted,int sampleCardinal,  int scoreMax) {

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

	
	





      


    }
}
