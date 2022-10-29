using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;




namespace nilnul.statistics
{

	/// <summary>
	/// Consider a Poisson Process, X is the time till the n-th events occur.
	/// P(X<=x)=1-P(X>x)=1-Sum (
	///            k=0 -> n-1,
	///            (lamda * x)^k * e^(-lamda *x) / k!
	/// )
	/// 
	/// f(x)=
	/// 
	/// </summary>
	public partial class GammaDistribution
	{
		/// <summary>
		/// Shape Parameter
		/// </summary>
		private PositiveReal _a;
		/// <summary>
		/// Scale parameter
		/// </summary>
		private PositiveReal _b;

		

		public GammaDistribution(PositiveReal a,PositiveReal b) {

			this._a= a;
			this._b= b;

		}
		
		public PositiveReal shape {
			get {
				return _a;
			}
		}

		public PositiveReal scale {
			get {
				return _b;
			}
		}

		public Func<PositiveReal, NonnegativeReal> probabilityFunction{
			get
			{
				E e = E.Instance;
				Func<Real, Real> Gamma = GammaFunction.Gamma;


				return 	x => x ^ (shape - 1) * e ^ (-x / scale) / (Gamma(shape) * scale ^ shape);
			}
		}

		public Func<Real, NonnegativeReal> distributionFunction {
			get { 

			}
		}

		public NonnegativeReal density(Real x) {
			E e=E.Instance;
			

			if (Domain.contains(x)) {
				return x ^ (shape - 1) * e ^ (-x / scale) / ( GammaFunction.Gamma(shape)  *  scale ^ shape );
			}
			return 0;
		}


		public Real mean { 
			get{
				return shape * scale;
			}
		}

		public NonnegativeReal variance {
			get {
				return shape * scale ^ 2;
			}
		}


		static public readonly RealSet DomainA = new RealInterval(0, RealInfinite.Positive, RealInterval.Type.Open);
		static public readonly RealSet DomainB = new RealInterval(0, RealInfinite.Positive, RealInterval.Type.Open);

		static public readonly RealSet Domain= new RealInterval(0, RealInfinite.Positive, RealInterval.Type.Open);



		 static public double Density(Real x,Real a,Real b){

			return x.Power(a - 1) * E.Instance.Power(-x / b)
				/ new GammaFunction(a) * b.Power(a);
				
			;
		}



		 static public theorem.Theorem theorem = new nilnul.math.theorem.Theorem();

		///If Xi ~ Gamma Distribution(ai,b), i=1,2,...
		///Then Sum(Xi) ~ GammDist(Sum(ai),b)
		///

		///if x1~Gamma Dist.(a1,b), x2~GammaDist(a2,b),
		///Then x1/(x1+x2) ~ BetaDist(a1,a2).
		///

		///if xi~chiSquareDist, 
		///Then Sum(Xi)~ Gammadist(n,1)

		 



		 

	
	}//class

	

	

}//namespace
