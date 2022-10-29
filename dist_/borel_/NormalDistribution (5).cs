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

		
	}//class

	///
	/// if()
	///
}//namespace
