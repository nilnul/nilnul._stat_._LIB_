using nilnul.math.calculus;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;




namespace nilnul.random.borel.gamma
{
	public partial class Pdf
	{
		

		static public double Eval(double x, double shape, double scale) {
			
				return Math.Pow( x , (shape - 1)) * Math.Exp(-x / scale )
				/ 
				(  GammaFunction.Eval(shape)  * Math.Pow( scale, shape ));
			
		}


	 

	
	}//class

	

	

}//namespace
