
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
{

	static public partial class Pert_riskampX
	{

		static public SpanBeta CreateSpanBeta(NotNull2<MinModMax_Lambda__Struct> pertLambda) {

			return _CreateSpanBeta(pertLambda.val);

			throw new NotImplementedException();
		}

		static public SpanBeta _CreateSpanBeta(MinModMax_Lambda__Struct pertLambda_notNull) {
			var pertCache = new RiskampX.PertCache(pertLambda_notNull);



			return new SpanBeta(pertCache.left, pertCache.right, pertLambda_notNull.pert.min, pertLambda_notNull.pert.max);

			throw new NotImplementedException();

		}


	}




}
