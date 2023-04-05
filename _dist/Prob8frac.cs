using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;
using nilnul.num;
using nilnul.stat._dist;

namespace nilnul.stat._dist
{
	public  class Prob8frac
		:
		nilnul.num.quotient.be_.nonneg_.leOne.vow.En
		,
		IProb
	{
		public Prob8frac(Quotient1 val) : base(val)
		{
		}

		public Prob8frac():this(new Quotient1())
		{
			
		}

		public Prob8frac(nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee value):this(
			nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_._RationableX._ToSignificed_assumeNormal(
				value
			).toQ()
		)
		{
		}
		public Prob8frac(double value):this(
			new nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(value)
		)
		{
		}


		static public bool operator >=(Prob8frac a, Prob8frac b){
			return a.en >= b.en;
		}

		static public bool operator <=(Prob8frac a, Prob8frac b){
			return b>=a;
		}
		static public bool operator ==(Prob8frac a, int b){
			return a.en==b;
		}

		static public bool operator !=(Prob8frac a, int b){
			return !(a==b);
		}

		static public Quotient1 operator -(Prob8frac a, Prob8frac b){
			return a.en-b.en;
		}

		static public Quotient1 operator +(Prob8frac a, Prob8frac b){
			return a.en+b.en;
		}

		static public Quotient1 operator +(Prob8frac a, Quotient1 b){
			return a.en+b;
		}


		static public readonly Prob8frac Nil = new Prob8frac(Quotient1.CreateZero());
		static public readonly Prob8frac One = new Prob8frac(Quotient1.CreateOne());

		



	}
}
