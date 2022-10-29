using System;
using lang;
using math;

namespace statistics
{
	public class Covariance:Function
	{
		///cov(x,y)=e(x-ex)e(y-ey)
		///

		
		public static Expression Call(RandomVariable x,RandomVariable y)
		{
			
			Num xE=(Num)(x["expectation"]);
			Num yE=(Num)(y["expectation"]);
			RandomVariable r1=x-xE;
			RandomVariable r2=y-yE;
			RandomVariable r3=r1*r2;
			return (Expression)(r3["expectation"]);
		
		}
		

	}
}
