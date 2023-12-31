using nilnul.math.calculus.betaFunc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalProb.rationalSample.cdf.contains
{


	/// <summary>
	/// if u~ beta dist. then U = (m / n)X / [1 + (m / n)X] ~ F distr.
	/// f(U) du.
	/// 
	///If    B~B(m/2,n/2), then F=nB/m(1-B)     ~ F(m,n)

	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	public class SpanBeta
		: 
		CdfAndInverseI
	{

		nilnul.prob.doubleProb.doubleSample.cdf.contains.SpanBeta _spanBeta;

		public nilnul.prob.doubleProb.doubleSample.cdf.contains.SpanBeta spanBeta {
			get {
				return _spanBeta;
			}
			set {
				spanBetaNotNull = value;
			
			}

		}

		public NotNull2<nilnul.prob.doubleProb.doubleSample.cdf.contains.SpanBeta> spanBetaNotNull
		{
			get
			{
				return _spanBeta;
			}
			set {
				_spanBeta = value;
			}

		}


		public R a
		{
			get {
				return DoubleToRation(_spanBeta.a);
			}
		}
		public R b
		{
			get {
				return DoubleToRation(_spanBeta.b);
			}
		}




		public R max {
			get {
				return DoubleToRation(_spanBeta.max);
			}
		}

		

		public R min
		{
			get { 
				return DoubleToRation(_spanBeta.min); 
			
			}
			//set { _minInDouble = value; }
		}

		static public R DoubleToRation(double x) {
			return nilnul.num.rational.cf.ContinuedFraction2.ToRational_tillDenominator(x,DOUBLE_TO_RATIONBAL_TILL_DENOMINATOR); 
		}

	


		public SpanBeta(NotNull2<RegularizedIncompleteSpanBeta> regularizedIncompleteSpanBeta)
		{
			//this.regularizedIncompleteSpanBeta = regularizedIncompleteSpanBeta;
			this._spanBeta= new doubleProb.doubleSample.cdf.contains.SpanBeta( regularizedIncompleteSpanBeta);
		}


	


		public SpanBeta(R a, R b, R min, R max)
			: this(new RegularizedIncompleteSpanBeta(a.toDouble(), b.toDouble(), min.toDouble(), max.toDouble()))
		{

		}

		



		static public SpanBeta Create(R a,R b,R min, R max) {

			return new SpanBeta(a, b, min, max);
		
		}

	

	



		const int DOUBLE_TO_RATIONBAL_TILL_DENOMINATOR= 1000;

		public  Prob probability(R x)
		{

			if (x <= min)
			{
				return Prob.Zero;

			}
			if (x >= max)
			{
				return Prob.One;


			}

			return Prob.FromApproximateDouble(
				_spanBeta.probability(x.toDouble())._val
			);
			
		}

		public  R inverse(Prob prob)
		{
			return DoubleToRation( _spanBeta.inverse( prob.toDoubleProb()));
			
		}

	

	
	}
}
