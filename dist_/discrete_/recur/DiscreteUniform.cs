using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.rationalProb.distributions
{
	public partial class DiscreteUniform<TSample>
		:rationalProb.DensityFunction<TSample>
	{
		public DiscreteUniform(nilnul.collection.set.Set<TSample> samples)
			:base(samples.Select(c=>new Event<TSample>(c,new nilnul.num.rational.Rational_InheritFraction2(1,samples.Count))))
		{

		}
	}
}
