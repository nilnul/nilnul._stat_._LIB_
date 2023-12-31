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

namespace nilnul.stat._dist
{
	/// <summary>
	/// wrapping <see cref="nilnul.num.quotient_.IRational"/>
	/// </summary>
	public  class Prob8quotient
		:
		nilnul.num.quotient.be_.nonneg_.leOne.vow.En
		,
		IProb
	{
		public Prob8quotient(Quotient1 val) : base(val)
		{
		}

		public Prob8quotient():this(new Quotient1())
		{
		}

		public Prob8quotient(nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee value):this(
			nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_._RationableX._ToSignificed_assumeNormal(
				value
			).toQ()
		)
		{
		}

		public Prob8quotient(double value):this(
			new nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee(value)
		)
		{
		}

		public Prob8quotient(BigInteger val, Nonnil_vowlessRef denominator)
			:
			this(
				new Quotient1(val,denominator.eeByRef)
			)
		{
		}
		public Prob8quotient(BigInteger val, BigInteger denominator)
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

		public Prob8quotient(DenomNonnil prob):this(nilnul.num.quotient_.denomNonnil._RegressionsX.ToStd(prob))
		{
		}

		static public bool operator >=(Prob8quotient a, Prob8quotient b){
			return a.en >= b.en;
		}

		static public bool operator <=(Prob8quotient a, Prob8quotient b){
			return b>=a;
		}
		static public bool operator ==(Prob8quotient a, int b){
			return a.en==b;
		}

		static public bool operator !=(Prob8quotient a, int b){
			return !(a==b);
		}

		static public Quotient1 operator -(Prob8quotient a, Prob8quotient b){
			return a.en-b.en;
		}

		static public Quotient1 operator +(Prob8quotient a, Prob8quotient b){
			return a.en+b.en;
		}

		static public Quotient1 operator +(Prob8quotient a, Quotient1 b){
			return a.en+b;
		}


		static public readonly Prob8quotient Nil = new Prob8quotient(Quotient1.CreateZero());
		static public readonly Prob8quotient One = new Prob8quotient(Quotient1.CreateOne());

		



	}
}
