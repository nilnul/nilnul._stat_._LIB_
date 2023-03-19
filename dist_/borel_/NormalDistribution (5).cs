using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nilnul.stat.dist_.borel_
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

			//var varianceDouble = 2 * variance;
			return	Math.Exp(
					-nilnul.num.real.op_.unary_.Square.Singleton.op(
						
							x-expectation
						
					)/(2*variance)
				)
				/
				Math.Sqrt(
					nilnul.num.real_._Tau4dblX.FULL * variance
				)
			;
		}

		public static double Density_2divergence(double x,double expectation,double divergence){


			return	Math.Exp(
					-nilnul.num.real.op_.unary_.Square.Singleton.op(
						borel.sample.of_.unary_._StdX._Std_1mean_2divergence(
							x,expectation,divergence
						)
					)/2
				)
				/
				(Math.Sqrt(
					nilnul.num.real_._Tau4dblX.FULL
					//2 * Math.PI
				)* divergence)
			;
		}

		
	}//class

	///
	/// if()
	///
}//namespace
