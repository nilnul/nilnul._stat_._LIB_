using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.linearAlgebra;
using nilnul.set.interval;
using nilnul.set;
using nilnul.statistics.distributions;
using nilnul.number.real;


namespace nilnul.probability.regression
{
	public interface IUnivariateLinearRegression { 
	}

	public class UnivariateLinearRegression:IUnivariateLinearRegression
	{
		private double[,] _points;

		public UnivariateLinearRegression() { 
		}

		public UnivariateLinearRegression(double[,] points) {
			this.points = points;
		}

		public double[,] points {
			set { 
				if(value.GetLength(1)!=2){
					throw new Exception("The given points must be of the form (x,y).");
				}
				if(value.GetLength(0)<2){
					throw new Exception("points.length must be 2 or more.");
				}
				_points = value;
			}
			get {
				return _points;
			}
		}

		public double pointsXAverage {
			get {
				return points.Column(0).Average();
			}
		}

		public double pointsYAverage {
			get {
				return points.Column(1).Average();
			}
		}


		/// <summary>
		/// 最小二乘法
		/// or 最大似然估计，当Y=a+bx+epsilon, while epsilon~N(0,sigma^2).
		/// </summary>
		public double slopeEstimate {
			get {
				return points.Rows().Aggregate(0.0,(w,p) => w+(p[0] - pointsXAverage) * (p[1] - pointsYAverage))
					/points.Rows().Aggregate(0.0,(w,p)=>w+Math.Pow((p[0]-pointsXAverage),2))
					;
			}
		}
		/// <summary>
		/// Estimate the intercept with the points observed.It's not the true intercept, even though it's indeed a linear relation.
		/// </summary>
		public double interceptEstimate {
			get {
				return pointsYAverage - slopeEstimate * pointsXAverage;
			}

		}

		public double pointsXVariationSum {
			get {
				return points.Rows().Aggregate(0d,(w,p) =>w+ Math.Pow(p[0] - pointsXAverage, 2));
			}
		}
		public double pointsYVariationSum
		{
			get
			{
				return points.Rows().Aggregate(0d,(w,p) =>w+ Math.Pow(p[1] - pointsYAverage, 2));
			}
		}
		public double pointsCovariationSum
		{
			get
			{
				return points.Rows().Aggregate(0d,(w,p) =>w+ (p[0] - pointsXAverage)*(p[1] - pointsYAverage));
			}
		}

		/// <summary>
		/// 残差平方和
		/// </summary>
		public double residualErrorSquareSum {
			get {
				return points.Rows().Aggregate(0d, (w, p) => w + Math.Pow((p[1] - interceptEstimate - slopeEstimate * p[0]), 2));
			}

		}

		public int pointsCount {
			get {
				return points.Rows().Count();
			}
		}

		public double varianceEstimate {
			get {
				return residualErrorSquareSum / (pointsCount - 2);
			}
		}


		public double conspicuousTestByT {
			get {
				return slopeEstimate * (pointsXVariationSum/varianceEstimate).Power(.5);
			}
		}
		/// <summary>
		/// H0:b=0.
		///  If b=0 is rejected, the linear is conspicuous.
		/// </summary>
		public ISet<IReal> conspicuousDomain(double alpha) {
			
			return

				
				(ISet<IReal>)
				(
				(new IntervalLeftOpenRightInfinite<IReal>(
					(Real<double>)(
						TDistribution.AStudT(alpha,pointsCount-2)
					)
				)

				+

				new IntervalLeftInfiniteRightOpen<IReal>(

					(Real<double>)(
						TDistribution.AStudT(alpha, pointsCount - 2)
					)
				))
				)
			;
			
		}


	}
}
