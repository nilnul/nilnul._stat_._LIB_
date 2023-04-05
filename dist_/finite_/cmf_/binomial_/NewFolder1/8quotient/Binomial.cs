using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



using N = nilnul.Num1;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using Qr = nilnul.num.real_.Quotient;
//using R = nilnul.num.RealI;
//using Rx = nilnul.num.RealIX;
using nilnul.num.real;
using nilnul.num._quotient.fraction.op;
using nilnul.num;

namespace nilnul.prob_.finite_
{

	[Obsolete(nameof(stat.dist_.finite_.cmf_.Binomial))]
	public class Binomial
	{
		private N _n;

		public N n
		{
			get { return _n; }
			set { _n = value; }
		}
		private _prob.Measure _p;

		public _prob.Measure p
		{
			get { return _p; }
			set { _p = value; }
		}


		public Binomial(
			N n, _prob.Measure p
		)
		{
			_n = n;
			_p = p;
		}


		public _prob.Measure measure(N k)
		{

			if (k < 0)
			{
				return _prob.Measure.CreateZero();
			}
			if (k > _n)
			{
				return _prob.Measure.CreateZero();

			}


			return new _prob.Measure(

				nilnul.num.real.combine_.Multi.Singleton.combine(
					new nilnul.num.real_.Quotient(
					nilnul.num.co_.ge._CombinateX._assumeNumGe(_n,k)
					)
					//nilnul.num.duo_.ge.reduce_.Combinate._Eval(_n, k)
					,

					nilnul.num.real.combine_.Multi.Singleton.combine(
						nilnul.num.real.op_.unary_._PolyX.RealI(p.val, k)

						,

						nilnul.num.real.op_.unary_._PolyX.RealI(
							(
								1-
								p.val.ToReal()
							),
							new num_.Positive1(
							_n.en - k
							)
						)
					)
				)
			);

		}

		public static Binomial Create(int v, Q1 ed1)
		{
			return new Binomial(
				new N(v)
				,
				new _prob.Measure(ed1)
			);

			//throw new NotImplementedException();
		}
	}
}
