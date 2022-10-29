
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
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
			private MinModMax_Lambda__Struct _minModMaxLambda;

			public MinModMax_Lambda__Struct minModMaxLambda
			{
				get { return _minModMaxLambda; }
				set {
						_minModMaxLambda = value;
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
				this.minModMaxLambda = minModMax;
				_setSpanBeta();
			}

			public Pert(double min,double mod,double max,double lambda=4)
				:this(new MinModMax_Lambda__Struct(min,mod,max,lambda))
			{
			}

			private void _setSpanBeta() {
				_spanBeta = CreateSpanBeta2(this._minModMaxLambda);
			}

			public override Prob probability(double upperBound)
			{
				return spanBeta.probability(upperBound);
				throw new NotImplementedException();
			}

			public override double inverse(Prob prob)
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
			var left = 1 + pertLambda_notNull.lambda_asDouble * (pert.mod - pert.min) / span;
			var right = 1 + pertLambda_notNull.lambda_asDouble * (pert.max - pert.mod) / pert.span;
			return SpanBeta.Create(left, right, pertLambda_notNull.pert.min, pertLambda_notNull.pert.max);
			throw new NotImplementedException();
		}
		static public SpanBetaFirstType CreateSpanBeta2(MinModMax_Lambda__Struct pertLambda_notNull)
		{
			var span = pertLambda_notNull.pert.span;
			var pert = pertLambda_notNull.pert;
			var shapePara1 = 1 + pertLambda_notNull.lambda_asDouble * (pert.mod - pert.min) / span;
			var shapePara2 = 1 + pertLambda_notNull.lambda_asDouble * (pert.max - pert.mod) / pert.span;
			return SpanBetaFirstType.Create(shapePara1, shapePara2, pertLambda_notNull.pert.min, pertLambda_notNull.pert.max);
			throw new NotImplementedException();
		}

	}









}
