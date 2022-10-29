
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample.cdf.contains.pert
{



	/// <summary>
	/// http://reference.wolfram.com/mathematica/ref/PERTDistribution.html
	/// </summary>

	public class WolframX 
	
	{


		//public Wolfram(MinModMaxLambda minModMaxLambda, NotNull2<nilnul.num.real.double_.NonNegativeX.NonNegativeDouble> lambda)

		//	: base(
		//		1 + lambda.val.val * (minModMaxLambda.pert.mod - minModMaxLambda.pert.min) / minModMaxLambda.pert.span,
		//		1 + lambda.val.val * (minModMaxLambda.pert.max - minModMaxLambda.pert.mod) / minModMaxLambda.pert.span,
		//		minModMaxLambda.pert.min,
		//		minModMaxLambda.pert.max
		//	)
		//{


		//}

		public class Pert
 			:DistributionA
		{
			private MinModMax_Lambda__Struct _minModMax;


			public MinModMax_Lambda__Struct minModMax
			{
				get { return _minModMax; }
				
				set {
					
						_minModMax = value;

						_spanBeta= CreateSpanBeta2(value);
						
					

				}
			}

		

			private SpanBetaFirstType _spanBeta;

			public SpanBetaFirstType spanBeta
			{
				get { return _spanBeta; }
				//set { _spanBeta = value; }
			}
			


			

			public Pert(MinModMax_Lambda__Struct minModMax)
			{

				this.minModMax = minModMax;



			}


			
					
					

			public Pert(R min,R mod,R max,R lambda)
				:this(new MinModMax_Lambda__Struct(min,mod,max,lambda))
			{
			}

			public Pert(R min, R mod, R max)
				: this(new MinModMax_Lambda__Struct(min, mod, max, 4))
			{
			}




			public override Prob probability(R upperBound)
			{
				return spanBeta.probability(upperBound);
				throw new NotImplementedException();
			}

			public override R inverse(Prob prob)
			{
				return spanBeta.inverse(prob);
				throw new NotImplementedException();
			}
		}


		static public SpanBeta CreateSpanBeta(NotNull2<MinModMax_Lambda__Struct> pertLambda)
		{

			return _CreateSpanBeta(pertLambda.val);


			throw new NotImplementedException();
		}

		static public SpanBeta _CreateSpanBeta(MinModMax_Lambda__Struct pertLambda_notNull)
		{
			var span = pertLambda_notNull.pert.span;
			var pert = pertLambda_notNull.pert;
			var left = 1 + pertLambda_notNull.lambda.val.val* (pert.mod - pert.min) / span;
			var right = 1 + pertLambda_notNull.lambda.val.val* (pert.max - pert.mod) / pert.span;



			return SpanBeta.Create(left, right, pertLambda_notNull.pert.min, pertLambda_notNull.pert.max);


			throw new NotImplementedException();

		}
		static public SpanBetaFirstType CreateSpanBeta2(MinModMax_Lambda__Struct pertLambda_notNull)
		{
			var span = pertLambda_notNull.pert.span;
			var pert = pertLambda_notNull.pert;
			var left = 1 + pertLambda_notNull.lambda.val.val* (pert.mod - pert.min) / span;
			var right = 1 + pertLambda_notNull.lambda.val.val*(pert.max - pert.mod) / pert.span;



			return SpanBetaFirstType.Create(left, right, pertLambda_notNull.pert.min, pertLambda_notNull.pert.max);


			throw new NotImplementedException();

		}



		//public Wolfram(Pert pert)

		//	: this(
		//		pert,

		//	  new NotNull2<nilnul.num.real.double_.NonNegativeX.NonNegativeDouble>(new NonNegativeX.NonNegativeDouble(4))

		//	)
		//{



		//}


		//public Wolfram(double min, double mod, double max)
		//	: this(new Pert(min, mod, max))
		//{

		//}






	}









}
