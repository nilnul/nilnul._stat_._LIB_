using System;
using Lang;

namespace Statistics
{
	
	public class Correlation:Function{
		public static double Call(RandomVariable x, RandomVariable y){
			return Covariance.Call(x,y)/x.StandardVariance/y.StandardVariance;
		}
	}

	
	
}
