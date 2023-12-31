using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;


namespace nilnul.stat.dist_.borel_.pdfable_
{

	/// <summary>
	/// on Normal Distribution
	/// </summary>
	public class Normal4dbl
		:
		borel_.Pdfable4dblA
		,
		borel_.pdfable_.Invertible4dblI
		,
		INormal
	{

		///from the simplest, compute the densisty with all the inputs.
		///
		private double _expectation;
		/// <summary>
		/// the variance, squared
		/// </summary>
		private double _variance;



		public static double Density(double x, double expectation, double variance)
		{

			//var varianceDouble = 2 * variance;
			return Math.Exp(
					-nilnul.num.real.op_.unary_.Square.Singleton.op(

							x - expectation

					) / (2 * variance)
				)
				/
				Math.Sqrt(
					nilnul.num.real_._Tau4dblX.FULL * variance
				)
			;
		}

		public static double Density_2divergence(double x, double expectation, double divergence)
		{


			return Math.Exp(
					-nilnul.num.real.op_.unary_.Square.Singleton.op(
						borel.sample.of_.unary_._StdX._Std_1mean_2divergence(
							x, expectation, divergence
						)
					) / 2
				)
				/
				(Math.Sqrt(
					nilnul.num.real_._Tau4dblX.FULL
				//2 * Math.PI
				) * divergence)
			;
		}

		public override double cumulatedProb(double upperBound)
		{
			///todo:
			throw new NotImplementedException();
		}

		public override double density(double sample)
		{
			//var varianceDouble = 2 * variance;
			return Math.Exp(
					-nilnul.num.real.op_.unary_.Square.Singleton.op(

							sample - this._expectation

					) / (2 * this._variance)
				)
				/
				Math.Sqrt(
					nilnul.num.real_._Tau4dblX.FULL * _variance
				)
			;
			//	throw new NotImplementedException();
		}

		/// <summary>
		/// </summary>
		/// <param name="cdf"></param>
		/// <returns></returns>
		/// <exception cref="NotImplementedException"></exception>
		public override double invert(double cdf)
		{
		/// todo:
			throw new NotImplementedException();
		}

		/// doc.lagout.org/science/0_Computer%20Science/2_Algorithms/The%20Art%20of%20Computer%20Programming%20%28vol.%202_%20Seminumerical%20Algorithms%29%20%283rd%20ed.%29%20%5BKnuth%201997-11-14%5D.pdf

		/// The Art of Computer Programming (vol. 2_ Seminumerical Algorithms) (3rd ed.) [Knuth 1997-11-14].pdf
		/// by knuth
		/// 122 sect3.4.1; p134 per computer;
		///
		/// 
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override double sample()
		{
			double s;
			double v1;
			double v2;

			do
			{

				var u1 = nilnul.stat.dist_.borel_.pdfable_.uniform_.Preportion4dblEs.Get0th();

				var u2 = nilnul.stat.dist_.borel_.pdfable_.uniform_.Preportion4dblEs.Get1st();

				v1 =2* u1.sample() -1;
				
				v2 =2* u2.sample() -1;

				s = nilnul.num.real.vec_.co.Variance.Singleton.to((v1, v2));

			} while (s >= 1
			|| s==0 // this is not tackled by Knuth;
			);


			return v1 * Math.Sqrt( -2*Math.Log(s) /s); //also another one is ok;



		}
	}//class

	
}//namespace
