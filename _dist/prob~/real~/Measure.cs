using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using nilnul.num.real;
using nilnul.num._quotient.fraction.op;
using nilnul.fs._address.dnts.co_.sup;

namespace nilnul._prob
{

	[Obsolete(nameof(nilnul.stat._dist.Prob))]
	public class Measure:nilnul.be.En_froFunc<R>
	{

		public Measure(Simplify.Ed1 ed1)
			:this(  nilnul.num.real_.Quotient.CreateByDivide(ed1.numerator,ed1.denominator) )
		{
		}


		public Measure(nilnul.num.real_.Quotient ed1)
			:this(ed1 as R)
		{
		}

		public Measure(R x):base(x, _MeasureX.IsInRange)
		{
				
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public static Measure CreateZero() {
			return new Measure( (nilnul.num.real_.Quotient)0);
		}
		public static Measure CreateOne() {
			return new Measure( (nilnul.num.real_.Quotient)1);
		}


	}
}
