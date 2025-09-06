using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.statistics;

namespace nilnul.prob
{




	public  class _EntropyX
	{

		static public double Info(double p) {
			return Uncertainty(1 / p);
		}

		static public double Uncertainty(double n) {
			return Math.Log(n);
		}


		static public double Entropy(params double[] ps) {



		}


		//static private readonly Entropy _Instance = new Entropy();
		//static public Entropy Instance
		//{
		//	get
		//	{
		//		return _Instance;
		//	}
		//}
		//private Entropy()
		//{
		//}
		//public number.real.ExprI eval(FiniteDiscretePMF ps)
		//{
		//	return 
		//	ps.Aggregate(
		//		(a,c) =>a.Add( 
		//			c.Multiply(
		//				Lb.Instance.eval(
		//					(1).ToReal().Divide(c)
		//				)
		//			)
		//		)
		//	);

		//}

		//public number.real.ExprI eval<T>(FiniteDiscreteDistribution<T> ps)
		//{
		//	return
		//	ps.Aggregate((number.real.ExprI)(Rational.Zero),
		//		(a, c) => a.Add(
		//			c.Value.Multiply(
		//				Lb.Instance.eval(
		//					(1).ToReal().Divide(c.Value)
		//				)
		//			)
		//		)
		//	).eval();

		//}
		//static public number.real.ExprI Eval(FiniteDiscretePMF ps)
		//{
		//	return Instance.eval(ps);

		//}
		//static public number.real.ExprI Eval<T>(FiniteDiscreteDistribution<T> ps)
		//{
		//	return Instance.eval(ps);

		//}	
	}
	
}
