using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics.distributions
{
	public partial class NormalDistribution
	{

		/// <summary>
		/// Approximate. error <10^-5.
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public double CDF(double x){
			if (x == 0) {
				return 0.5;
			}

			const double a = .33267;
			const double a1 = .4361836;
			const double a2 = -.1201676;
			const double a3 = .9372986;

			double t=1/(1+a*Math.Abs(x));
			double t2=t*t;
			double t3=t2*t;

			double r=1/Math.Pow((2*Math.PI),.5) * Math.Pow(Math.E,-x*x/2) * (a1*t+a2*t2+a3*t3);
			if(x>0){
				return 1 - r;

			}
			else  {
				return r;

			}
			

		}//cdf

		/// <summary>
		/// The probability on interval (-inf, -|z|)+(|z|, +inf)
		/// </summary>
		/// <param name="z"></param>
		/// <returns></returns>
		static public double Norm(double z) {
			z=Math.Abs(z);
			 var p=1+ z*(0.04986735+ z*(0.02114101+ z*(0.00327763+ z*(0.0000380036+ z*(0.0000488906+ z*0.000005383)))));
			p=p*p; p=p*p; p=p*p;
			return 1 / (p * p);
		}

		//static public double AnotherCDF(double z)
		//{
		static public double CDF2(double z) {

			if (z == 0)
			{
				return 0.5d;
			}
			else
				if (z > 0)
				{
					return 1 - Norm(z) / 2;
			}
				else {
					return Norm(z) / 2;
			}
			
		}

		static public double DiameterOfProbability(double p) {
			return DoubleDividePoint(1-p);

		}




		/// <summary>
		/// 双侧分位数
		/// 
		/// make the (-inf, -returned)+(returned,+inf) 's probability=alpha
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		static public double DoubleDividePoint(double pDeletedInterval) {
			if (pDeletedInterval <0){
				throw new Exception("Given probability cannot be 0.");
			}
			if(pDeletedInterval ==0){

				return double.PositiveInfinity;
				//throw new ArgumentOutOfRangeException("Given probability is 0 such that the double divide point have to be infinite.");
			}
			if(  pDeletedInterval > 1)
			{
				throw new ArgumentException("Probability cannot >1.");
			}

			var v=0.5;
			var dv=0.5;
			double z=0;
			while(dv>1e-6) {
				z=1/v-1; 
				dv=dv/2; 
				if(Norm(z)>pDeletedInterval) {
					v=v-dv;
				} else {
					v=v+dv;
				}
			}
			return z;
		}
		/// <summary>
		/// p(upperDividePoint,+inf)=alpha
		/// </summary>
		/// <param name="alpha"></param>
		/// <returns></returns>
		static public double UpperDividePoint(double pUpperInterval) {
			if(pUpperInterval>.5){
				return -UpperDividePoint(1 - pUpperInterval);
			}
			
			return DoubleDividePoint(2 * pUpperInterval);
		}



		
	}
}
