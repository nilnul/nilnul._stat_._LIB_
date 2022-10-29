using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real;
using nilnul.set;
using nilnul.statistics.distribution;


namespace nilnul.statistics.factorAnalysis
{
	/// <summary>
	/// Variance Analysis.
	/// 
	/// Note:Level# starts from 0.
	/// </summary>
	public class UnifactorAnalysis
	{
		private double[][] _observations;

	#region constructions
		public UnifactorAnalysis() { }

		public UnifactorAnalysis(double[][] observations) {
			this.observations = observations;

		}

	#endregion

		#region properties

		public double[][] observations {
			set {
				_observations = value;
			}
			get {
				return _observations;
			}
		}

		public int levelsCount {
			get {
				return observations.Length;
			}
		}

		public int observationsCountByLevel(int level) {
			return observations[level].Length;

		}

		public int observationsCountAllLevel {
			get {
				return 
				observations.Sum(x=>x.Count());
				
			}
		}
		[Obsolete("use observationsAverageOfAllLevel")]
		public double observationsAverageTotal {
			get {
				return observations.Sum(x => x.Sum()) / observationsCountAllLevel;
			
			}
		}

		public double observationsAverage
		{
			get
			{
				return observations.Sum(x => x.Sum()) / observationsCountAllLevel;

			}
		}

		public double observationsTotal {
			get {
				return observations.Sum(x => x.Sum());
			}
		}

		public double observationsTotalByLevel(int level) {
			return observations[level].Sum();
		}


		public double observationsAverageByLevel(int level) { 
			return observations[level].Sum()/observationsCountByLevel(level);
		}

		public double observationsVariationByLevel(int level) {
			return observations[level].Sum() / observationsCountByLevel(level);
		}

		/// <summary>
		/// 总变差；总偏差平方和
		/// </summary>
		public double observationVariationTotal {
			get {
				return 
					observations.Sum(
						x => x.Sum(
							y => (
								y - observationsAverageTotal
							).Power(2)
						)
					)
				;
			}

		}

		/// <summary>
		/// 误差平方和。
		/// </summary>

		public double errorSquareSum {
			get { 
				double r=0;
				for(int i=0;i<observations.Length;i++){
					r+=observations[i].Sum(x=>(x-observationsAverageByLevel(i)).Power(2));
				}
				return r;
			}
		}

		public double effectSquareSum {
			get {
				double r = 0;
				for (int i = 0; i < observations.Length; i++)
				{
					r += observationsCountByLevel(i)* (observationsAverageByLevel(i) - observationsAverageTotal).Power(2);
				}
				return r;


				
			}
		}

		public double effectSquareAverage {
			get {
				return effectSquareSum / degreesOfFreedomFactor;

				
			}
		}

		public double errorSquareAverage {
			get {
				return errorSquareSum / degreesOfFreedomError;
			}
		}

		public double FRatio
		{
			get
			{
				return effectSquareAverage / errorSquareAverage;
			}

		}

		public int degreesOfFreedomFactor {
			get {
				return levelsCount - 1;
			}
		}
		public int degreesOfFreedomError {
			get {
				return observationsCountAllLevel - levelsCount;
			}
		}
		public int degreesOfFreedomTotal {
			get {
				return observationsCountAllLevel - 1;
			}
		}

		public double varianceEstimate {
			get {
				return effectSquareSum / degreesOfFreedomError;
			}
		}

		public double meanEstimate {
			get {
				return observationsAverage;
			}
		}

		public double meanEstimateByLevel(int level) {
			return observationsAverageByLevel(level);
		}
		/// <summary>
		/// confidence level is alpha
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		public ClosedNeighborhood<double> meanDifferenceConfidenceInterval(int levelA,int levelB,double confidenceLevel) {
			return new ClosedNeighborhood<double>(
				observationsAverageByLevel(levelA)-observationsAverageByLevel(levelB),
				TDistribution.UpperDividePoint((1-confidenceLevel) / 2, this.degreesOfFreedomError)
				*
				((errorSquareAverage
					* (1.0 / observationsCountByLevel( levelA) + 1.0 / observationsCountByLevel( levelB))
				).Power(.5))
				
			);


		}
		
		///TDistribution.UpperDividePoint((1-confidenceLevel) / 2, this.degreesOfFreedomError)				*				(errorSquareAverage					* (1.0 / observationsCountByLevel( levelA) + 1.0 / observationsCountByLevel( levelB))				).Power(.5)

	

		


		#endregion


	}
}
