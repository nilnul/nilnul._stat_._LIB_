using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.stat;
using nilnul.stat._dist;
using nilnul.stat._dist_;



using N = nilnul.Num_ofIn;
using Q1 = nilnul.num.Quotient1;
//using Q1 = nilnul.num.quotient_.DenomNonnil;

//using Qr = nilnul.num.real_.Quotient;
//using R = nilnul.num.RealI;
//using Rx = nilnul.num.RealIX;
//using nilnul.num.real;
using nilnul.num._quotient.fraction.op;
using nilnul.num;

namespace nilnul.stat.dist_.finite_.cmf_
{

	public class Binomial2frac
		:
		IFinite
		,
		stat.dist_._FiniteI<N, _dist.Prob8quotient>
		,
		_dist_.PmfI<N, _dist.Prob8quotient>
	{
		private N _total;

		public N total
		{
			get { return _total; }
			set { _total = value; }
		}
		private _dist.Prob8quotient _prob4bernoulli;

		public _dist.Prob8quotient prob4bernoulli
		{
			get { return _prob4bernoulli; }
			set { _prob4bernoulli = value; }
		}


		public Binomial2frac(
			N n, _dist.Prob8quotient p
		)
		{
			_total = n;
			_prob4bernoulli = p;

			var sortedDict = new SortedDictionary<uint, Quotient1>();

			var prob0 = new nilnul.num.Quotient1();

			for (uint i = 0; i < total; i++)
			{
				prob0 += this.prob(i);

				sortedDict.Add(i, prob0);
			}
			sortedDict.Add((uint)total.eeByRef, 1);

			/// 
			this._cmfCached = new _binomial.Cmf4frac(sortedDict);
		}


		public nilnul.stat._dist.Prob8quotient prob(N k)
		{

			if (k < 0)
			{
				return Prob8quotient.Nil;
			}
			if (k > _total)
			{
				return Prob8quotient.One;

			}


			return new Prob8quotient(
					new nilnul.num.Quotient1(
						nilnul.num.co_.ge._CombinateX._assumeNumGe(_total, k)
					)
					*
					nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(prob4bernoulli, k)
*
					nilnul.num.quotient.op_.unary_._PolyX.AssumeIndexNat(
						(
							1 -
							prob4bernoulli.en
						)
						,
						_total.eeByRef - k.eeByRef
					)
			);
		}
		_binomial.Cmf4frac _cmfCached;


		public N sample()
		{
			return sample(
				nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4frac()
			);

		}
		public N sample(_dist.Prob8quotient prob)
		{
			
				return _cmfCached.boxed.First(
					x => x.Value >= prob
				).Key;

		}

		public static Binomial2frac Of(int v, Q1 ed1)
		{
			return new Binomial2frac(
				 N.Of(v)
				,
				new Prob8quotient(ed1)
			);

			//throw new NotImplementedException();
		}


	}
}
