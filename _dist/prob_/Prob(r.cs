using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;
using nilnul.num.real;
using nilnul.num._quotient.fraction.op;

namespace nilnul.stat
{

	[Obsolete()]
	public class Prob:nilnul.num.real.be_.nonneg_.leOne.vow.Ee
	{



		public Prob(R x):base(x)
		{
				
		}
		public Prob(nilnul.num.real_.Quotient ed1)
			:this(ed1 as R)
		{
		}
		public Prob(nilnul.num.QuotientI1 ed1)
			:this(  nilnul.num.real_.Quotient.CreateByDivide(ed1.numerator,ed1.denominator1) )
		{
		}

		public override string ToString()
		{
			return base.ToString();
		}

		public static Prob CreateZero() {
			return new Prob( (nilnul.num.real_.Quotient)0);
		}
		public static Prob CreateOne() {
			return new Prob( (nilnul.num.real_.Quotient)1);
		}


	}
}
