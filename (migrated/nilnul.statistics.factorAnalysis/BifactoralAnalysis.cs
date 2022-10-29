using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.math.statistics
{
	public class BifactoralAnalysis
	{
		private double[, ,] _experimentResults;

		private double _sampleMean;

		public double sampleMean {
			get {
				
				double r = 0;
				foreach (double x in _experimentResults) {
					r += x;
				}
				return r/_experimentResults.GetLength(0)/_experimentResults.GetLength(1)/_experimentResults.GetLength(2);
			}
		}

		public double sampleMeanAB(int i,int j) {
			
			return sampleTotalAB(i,j) / _experimentResults.GetLength(2);
		}

		public double sampleMeanA(int i) { 

		}

		public double sampleTotalAB(int i, int j) {
			double r = 0;
			foreach(double x in _experimentResults[i,j]){
				r += x;
			}
			return r;
		}

		public IEnumerable<double> sample2TotalAB(int i,int j) {
			double r = 0;
			
			foreach(double x in _experimentResults[i,]){
				r+=x*x;
			}
			return r;
		}
		public double sample2MeanAB(int i,int j) {
			return sample2TotalAB / _experimentResults.GetLength(2);
		}

		public double crossEffectSquareSum() {
			double r = 0;
			foreach(double x in _experimentResults){
				r += x*x;
			}

			r -= sample2MeanAB;

			


		}

		public double sample2Total() {
			double r = 0;
			foreach(double x in _experimentResults){
				r += x * x;
			}
			return x;
		}

		/// <summary>
		/// sample^2 total - sample^2
		/// </summary>
		/// <returns></returns>
		public double ErrorSquareSum() {
			return
				sample2Total - sample2TotalAB.SumSq() / _experimentResults.GetLength(2);
			
		}






		public BifactoralAnalysis(double[,,] experimentResult) {
			///t must be 2 or more.
			if(experimentResults.GetLength(3)<2){
				throw new Exception();
			}



			this.experimentResults = experimentResults;

		}


		public int levelsCount(int factor) {
			if(factor!=1 && factor!=2){
				throw new Exception();
			}

			return experimentResults.GetLength(factor);
		}



		

		public Decimal[, ,] experimentResults
		{
			get
			{
				return _experimentResults;
			}

		}
	}
}
