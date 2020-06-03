using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.linearAlgebra;
using nilnul;

namespace nilnul.statistics
{
	public class MultivariateLinearRegression
	{
		private double[,] _points;

		

		public double[,] points {
			set {
				_points = value;
			}
			get {
				return _points;
			}
		}

		public int pointsCount {
			get {
				return _points.GetLength(0);
			}
		}

		public int variatesCount {
			get {
				return _points.GetLength(1) - 1;
			}
		}

		

		public double[,] Y { 
			get{
				return _points.SubmatrixLastColumns(1);
			}
		}

		public double[,] X {
			get {

				return 
					Matrix_Extension.GenerateMatrix(1d,_points.GetLength(0),1).Merge(
						_points.Delete(
							new HashSet<int>(),
							new HashSet<int>(
								new []{_points.GetLength(1)-1}
							)
						)

					)
				;




			}
		}//X

		public double[] B {
			get {
				return X.Transpose().Multiply(X).Inverse().Multiply( X.Transpose()).Multiply( Y).ToVector();
			}
		}
	}
}
