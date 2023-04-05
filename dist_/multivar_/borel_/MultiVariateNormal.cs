using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.collection;
using nilnul.num.real.matrix;

namespace nilnul.prob.doubleProb.doubleSample.distributions
{

	/// <summary>
	/// on Normal Distribution
	/// </summary>
	public partial class MultiVariateNormal
	{


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
					
					nilnul.num.real.op.Sq.Eval(

						MatrixX131113.Inverse(covarianceMatrix).Determinant()
					)
					//covarianceMatrix.Inverse().Determinant().Power(2)
				)
				*
				Math.Exp(
					-.5
					*
					nilnul.num.real.vector.Vector_Extension.InnerProduct(
						nilnul.num.real.matrix.doubleElement.Op_InMethods.Multiply_rowVector(

							nilnul.num.real.vector.Vector_Extension.Minus(
								x,
								expectationVector
							)
							,
							covarianceMatrix.Inverse()
						)
						,
						
							
								nilnul.num.real.vector.Vector_Extension.Minus(x, expectationVector)
							
						)
				)
				
				
			;

			
		}
	}//class

	///
	/// if()
	///
}//namespace
