using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using N = nilnul.Num_ofIn;
//using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
//using Qr = nilnul.num.real_.Quotient;
using R = nilnul.num.RealI;
//using Rx = nilnul.num.RealIX;
using nilnul.num.real;
using nilnul.num._quotient.fraction.op;
using nilnul.num;

namespace nilnul.stat.dist_.finite_.cmf_
{

	public class Binomial
	{
		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}
		private _dist.Prob _p;

		public _dist.Prob p
		{
			get { return _p; }
			set { _p = value; }
		}


		public Binomial(
			N n, _dist.Prob p
		)
		{
			_n = n;
			_p = p;
		}


		public _dist.Prob measure(N k)
		{

			if (k < 0)
			{
				return _dist.Prob.CreateZero();
			}
			if (k > _n)
			{
				return _dist.Prob.CreateZero();

			}


			return new _dist.Prob(

				nilnul.num.real.combine_.Multi.Singleton.combine(
					new nilnul.num.real_.Quotient(
					nilnul.num.co_.ge._CombinateX._assumeNumGe(_n,k)
					)
					//nilnul.num.duo_.ge.reduce_.Combinate._Eval(_n, k)
					,

					nilnul.num.real.combine_.Multi.Singleton.combine(
						nilnul.num.real.op_.unary_._PolyX.RealI(p.en, k)

						,

						nilnul.num.real.op_.unary_._PolyX.RealI(
							(
								1-
								p.en.ToReal()
							),
							new num_.Positive1(
							_n.eeByRef - k
							)
						)
					)
				)
			);

		}

		public static Binomial Create(int v, nilnul.num.quotient_.DenomNonnil ed1)
		{
			return new Binomial(
				 N.Of(v)
				,
				new _dist.Prob(ed1)
			);

			//throw new NotImplementedException();
		}
	}
}
