using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.probability.distributions
{
	public partial class TDistribution
	{




		

		static public double UpperDividePoint(double alpha,int degree) {
			if (alpha == .5) {
				return 0;
			}
			if(alpha>.5){
				return -UpperDividePoint(1 - alpha, degree);
			}

			int i ;

			for (i = 0; i < cdf.GetLength(0);i++ )
			{
				
				if (cdf[i, 0] == degree)
				{
					if(cdf[i,1]<alpha+.0001 && cdf[i,1]>alpha-.0001){
						return cdf[i, 2];
					}
					
					

				}
				
			}

		
			return AStudT(alpha*2,degree);
			
			
			
		}
		/// <summary>
		///  
		/// the probability on the bothsides. or alpha.
		/// </summary>
		/// <param name="t">the x and -x point which divide the density function giving the two interval on the bothsides which total cover alpha probability. </param>
		/// <param name="n"> degrees of freedom</param>
		/// <returns></returns>
		static public double StudT(double t,int n) {
			t=Math.Abs(t);
			var w=t/Math.Sqrt(n);
			var th=Math.Atan(w);
			if(n==1) {
				return 1-th/PiD2; 
			}
			var sth=Math.Sin(th);
			var cth = Math.Cos(th);
			if((n%2)==1)
			{
				return 1-(th+sth*cth*StatCom(cth*cth,2,n-3,-1))/PiD2 ;
			}
			else{ 
				return 1-sth*StatCom(cth*cth,1,n-3,-1);
			}
		}

		/// <summary>
		/// 双侧分位数
		/// </summary>
		/// <param name="p"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		static public double AStudT(double p,int n) {
			var v=0.5; 
			var dv=0.5; 
			var t=0d;
			while(dv>1e-6) {
				 t=1d/v-1;
				 dv=dv/2;
				 if(StudT(t,n)>p) {
					 v=v-dv;
				 } else {
					 v = v + dv;
				 }
			}
			return t;//得到的t为双侧分位数
		}


		

		static private double StatCom(double q,int i,int j,int b) {
			double zz=1;
			var z=zz; 

			var k=i; 

			while(k<=j) {

				zz = zz * q * k / (k - b); 
				z = z + zz;
				k = k + 2;
			}
			return z;
		}


		const double Pi = Math.PI;
		const double PiD2 = Pi / 2;
		static readonly double[,] cdf = new double[,] { 
				{12,.025,2.1788}
		};

	}//class

}//namespace
