using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;
using nilnul.num;
using nilnul.stat._dist;

namespace nilnul.stat
{
	[Obsolete(nameof(stat._dist.Prob8quotient))]
	public  class ProbQuotient
		:
		nilnul.num.quotient.be_.nonneg_.leOne.vow.En
		,
		IProb
	{
		public ProbQuotient(Quotient1 val) : base(val)
		{
		}

		static public bool operator >=(ProbQuotient a, ProbQuotient b){
			return a.en >= b.en;
		}

		static public bool operator <=(ProbQuotient a, ProbQuotient b){
			return b>=a;
		}
		static public bool operator ==(ProbQuotient a, int b){
			return a.en==b;
		}

		static public bool operator !=(ProbQuotient a, int b){
			return !(a==b);
		}

		static public Quotient1 operator -(ProbQuotient a, ProbQuotient b){
			return a.en-b.en;
		}

		static public Quotient1 operator +(ProbQuotient a, ProbQuotient b){
			return a.en+b.en;
		}

		static public Quotient1 operator +(ProbQuotient a, Quotient1 b){
			return a.en+b;
		}






	}
}
