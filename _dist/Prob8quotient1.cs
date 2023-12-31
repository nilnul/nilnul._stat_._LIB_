using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.real;
using nilnul.num.rational;
using nilnul.num;
using nilnul.stat._dist;
using nilnul.num.integer_;
using System.Numerics;
using nilnul.num.quotient_;
using nilnul.num.quotient_.denomNonnil;

namespace nilnul.stat._dist
{
	public  class Prob8quotient1
		:
		nilnul.num.quotient.be_.probal.vow.Ee
		,
		IProb
	{

		public Prob8quotient1(DenomNonnil val) : base(val)
		{
		}

		public Prob8quotient1(Quotient1 val) : base(val.ToDenomNonnil())
		{
		}

		public Prob8quotient1():this(new DenomNonnil())
		{
		}

		public Prob8quotient1(nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee value):this(
			nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_._RationableX._ToSignificed_assumeNormal(
				value
			).toQ()
		)
		{
		}

		public Prob8quotient1(double value):this(
			new nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(value)
		)
		{
		}

		public Prob8quotient1(BigInteger val, Nonnil_vowlessRef denominator)
			:
			this(
				new Quotient1(val,denominator.eeByRef)
			)
		{
		}
		public Prob8quotient1(BigInteger val, BigInteger denominator)
			:
			this(
				new Quotient1(
					val
					,
					denominator
				)
			)
		{
		}

		//public Prob8quotient1(DenomNonnil prob):this(nilnul.num.quotient_.denomNonnil._RegressionsX.ToStd(prob))
		//{
		//}

		static public bool operator >=(Prob8quotient1 a, Prob8quotient1 b){
			return a.eeByRef.ToImpl() >= b.eeByRef;
		}

		static public bool operator <=(Prob8quotient1 a, Prob8quotient1 b){
			return b>=a;
		}
		static public bool operator ==(Prob8quotient1 a, int b){
			return a.eeByRef.ToImpl()==b;
		}

		static public bool operator !=(Prob8quotient1 a, int b){
			return !(a==b);
		}

		static public DenomNonnil operator -(Prob8quotient1 a, Prob8quotient1 b){
			return a.eeByRef.ToImpl() -b.eeByRef;
		}

		static public DenomNonnil operator +(Prob8quotient1 a, Prob8quotient1 b){
			return a.eeByRef.ToImpl() +b.eeByRef;
		}

		static public DenomNonnil operator +(Prob8quotient1 a, DenomNonnil b){
			return a.eeByRef.ToImpl()+b;
		}
		static public DenomNonnil operator +(Prob8quotient1 a, Quotient1 b){
			return a+b.ToDenomNonnil();
		}


		static public readonly Prob8quotient1 Nil = new Prob8quotient1(DenomNonnil.Nil);
		static public readonly Prob8quotient1 One = new Prob8quotient1(DenomNonnil.One);

		



	}
}
