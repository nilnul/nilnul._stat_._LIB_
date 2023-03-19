
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
{

	
		static public partial class RiskampX
		{

			/// <summary>
			/// http://www.riskamp.com/beta-pert/
			/// 
			/// http://www.vosesoftware.com/ModelRiskHelp/index.htm#Distributions/Continuous_distributions/PERT_distribution.htm
			/// </summary>

			public class PertCache
			{
				private double _span;

				public double span
				{
					get { return _span; }

				}

				private double _mean;

				public double mean
				{
					get { return _mean; }

				}

				private double _left;

				public double left
				{
					get { return _left; }
					set { _left = value; }
				}


				private double _right;

				public double right
				{
					get { return _right; }
					set { _right = value; }
				}

				public PertCache(MinModMax_Lambda__Struct pertLambdaNotNull)
				{

					var pertLambda = pertLambdaNotNull;

					var pert = pertLambda.pert;
					var min = pert.min;
					var max = pert.max;
					var mod = pert.mod;
					var lambda = pertLambda.lambda_asDouble;



					this._span = pertLambda.pert.span;


					this._mean = nilnul.num.real.double_.SumX.Sum(min, lambda * mod, max) / (lambda + 2);

					this._left = (_mean - min) * (2 * mod - min - max) / ((mod - _mean) * _span);

					this._right = _left * (max - _mean) / (_mean - min);




				}



			




			}

		}




	
}