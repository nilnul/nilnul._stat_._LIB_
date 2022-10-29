using nilnul.num.rational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.prob.empirical
{
	public partial class SamplesOfRational
		:Samples<nilnul.num.rational.Rational_InheritFraction>
	{

		public SamplesOfRational(IEnumerable<Sample> samples)
			:base(
				new NotNull2<IEnumerable<Samples<Rational_InheritFraction>.Sample> > (
					
					samples

				)
			)
		{

		}

	

		public class Sample 
		:Samples<nilnul.num.rational.Rational_InheritFraction>.Sample
		{

			public Sample(nilnul.num.rational.Rational_InheritFraction samplePoint, nilnul.num.natural.PositiveNatural_inheritNatural count)
				:base(samplePoint,count)
			{
			}
					
		}
					

	}
}
