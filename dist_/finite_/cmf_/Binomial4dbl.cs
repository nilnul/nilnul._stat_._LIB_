using nilnul.num.natural;
using nilnul.num.natural.op;
using nilnul.stat._dist_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.finite_.cmf_
{

	/// <summary>
	/// given n,
	/// repeat <see cref="Bernoulli4dbl"/> for n times, and see how many times it's true;
	/// So this tends to be <see cref="borel_.Normal4dbl"/> if n goes to infinity;
	/// </summary>
	/// 
	public class Binomial4dbl
		:Finite4dblI<uint>
	{
		private uint _totalTimes;

		public uint total
		{
			get { return _totalTimes; }
			set { _totalTimes = value; }
		}

		private _dist.Prob4dbl _prob4bernoulli;

		/// <summary>
		/// probability for a single toss of coin
		/// </summary>
		public _dist.Prob4dbl prob4bernoulli
		{
			get { return _prob4bernoulli; }
			set { _prob4bernoulli = value; }
		}

		public Binomial4dbl(uint n, _dist.Prob4dbl prob)
		{
			this._totalTimes = n;
			this._prob4bernoulli = prob;

			var sortedDict = new SortedDictionary<uint, double>();

			var prob0 = 0d;

			for (uint i = 0; i < total; i++)
			{
				prob0 += this._prob_assumeLeTotal(i);

				sortedDict.Add(i, prob0);
			}
			sortedDict.Add(total, 1);

			/// 
			this._cmfCached = new _binomial.Cmf4dbl(sortedDict);
		}

		public Binomial4dbl(uint n, double v):this(n,new _dist.Prob4dbl(v))
		{
		}

		public double unintendedProb {
			get {
				return 1 - _prob4bernoulli;
			}
		}

		public double variance {
			get {
				return _totalTimes * _prob4bernoulli * unintendedProb;
			}
		}

		public double mean { get {
				return _totalTimes * _prob4bernoulli;
			} }
		public double _prob_assumeLeTotal(uint k) { 

			return		Combinate.Eval(total,k)
				*
				Math.Pow(prob4bernoulli._val,(double)k)
				*
				Math.Pow((1-prob4bernoulli._val),total-k)
			;
		
		}

		public _dist.Prob4dbl prob_assumeLeTotal(uint k) { 

			return new _dist.Prob4dbl(
				Combinate.Eval(total,k)
				*
				Math.Pow(prob4bernoulli._val,(double)k)
				*
				Math.Pow((1-prob4bernoulli._val),total-k)
			);
		
		}

		_binomial.Cmf4dbl _cmfCached;

		/// <summary>
		/// if total ==0, then this returns 0;
		/// </summary>
		/// <returns></returns>
		public uint sample()
		{


			return _cmfCached.boxed.First(
				x=>x.Value>= borel_.pdf_.uniform_._Preportion4dblX.Sample()
			).Key;
		}

		/// <summary>
		/// if total=0, then this will return 1;
		/// </summary>
		/// <param name="k"></param>
		/// <returns></returns>
		/// <exception cref="dist.sample_.xpn_.NotInDomain"></exception>
		public double pmf(uint k)
		{
			if (k>_totalTimes)
			{
				return 0;
				throw new dist.sample_.xpn_.NotInDomain($"{k} is outside {this._totalTimes}");
			}

			return 		Combinate.Eval(total,k)
				*
				Math.Pow(prob4bernoulli._val,(double)k)
				*
				Math.Pow((1-prob4bernoulli._val),total-k)
			;

		}
	}
}
