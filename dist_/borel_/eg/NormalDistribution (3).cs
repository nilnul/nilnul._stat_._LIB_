using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using nilnul.linearAlgebra;
using nilnul.number.real;


namespace nilnul.math.statistics.distribution
{

	/// <summary>
	/// on Normal Distribution
	/// </summary>
	public class Normal
	{

		///from the simplest, compute the densisty with all the inputs.
		///
		private double _expectation;
		/// <summary>
		/// the variance, squared
		/// </summary>
		private double _variance;

		public static double Density(double x,double expectation,double variance){

			return
				1
				/
				Math.Pow(2 * Math.PI * variance, .5)

				*

				Math.Exp(
					-
					.5
					*
					Math.Pow(
						(x - expectation) / variance
						,
						2
					)
				)
			;
		}

		public static double Density(double[] x,double[] expectationVector,double[,] covarianceMatrix) {
			int n = expectationVector.Length;
			return
				1
				/
				(
					Math.Pow(
						2*Math.PI
						,
						n/2.0
					)
					*
					covarianceMatrix.Inverse().Determinant().Power(2)
				)
				*
				Math.Exp(
					-.5
					*
					x.Minus(expectationVector)
						.Multiply(
							covarianceMatrix.Inverse()
						)
						.Multiply(
							x.Minus(expectationVector)
						)
				)
				
				
			;

			
		}
	}//class
	public class Normal_Theorem:IfThen {
		///some equivalent statments: <=> <=>
		///or one premise, many result. => =>
		///
		///




		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		static public void a(Statement s) {
			///shared statments.
	///if
			

			

			RandomVariable[] Xi;
			Xi.distribution is Normal;

			RandomVariable[] Yi;
			foreach(RandomVariable Y in Yi){
				Y is Xi.LinearExpression;
			}

			///then
			///
			Yi.distribution is Normal;



			
			
			
		} 
	}
	///
	/// if()
	///
}//namespace
