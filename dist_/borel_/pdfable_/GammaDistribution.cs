using nilnul.num.real_;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;




namespace nilnul.stat.dist_.borel_
{

	/// <summary>
	
	/// 
	/// for real number;
	/// 
	/// </summary>
	public  class GammaDistribution
	{
		/// <summary>
		/// Shape Parameter
		/// </summary>
		private num.real_.PositiveDbl _a;
		/// <summary>
		/// Scale parameter
		/// </summary>
		private num.real_.PositiveDbl _b;

		

		public GammaDistribution(PositiveDbl a, PositiveDbl b) {

			this._a= a;
			this._b= b;

		}
		
		public PositiveDbl shape {
			get {
				return _a;
			}
		}

		public PositiveDbl scale {
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

	
	



		 

	
	}//class

	

	

}//namespace
