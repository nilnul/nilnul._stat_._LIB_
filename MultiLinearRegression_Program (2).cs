using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.linearAlgebra;


namespace nilnul.statistics.regression
{
	class MultiLinearRegression_Program
	{
		static public void Main() {
			MultivariateLinearRegression m = new MultivariateLinearRegression();
			m.points = new double[,] { 
				{10,100,25.2},
				{10,100,27.3},
				{10,100,28.7},
				{15,225,29.8},
				{15,225,31.1},
				{15,225,27.8},
				{20,400,31.2},
				{20,400,32.6},
				{20,400,29.7},
				{25,625,31.7},
				{25,625,30.1},
				{25,625,32.3},
				{30,900,29.4},
				{30,900,30.8},
				{30,900,32.8}

			};
			Console.WriteLine(m.B.ToStr("\n\r"));
			Console.Read();


		}
	}
}
