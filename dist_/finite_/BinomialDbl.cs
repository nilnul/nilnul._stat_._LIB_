using nilnul.num.natural;
using nilnul.num.natural.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.finite_
{

	public class BinomialDbl
	{
		private uint _times;

		public uint times
		{
			get { return _times; }
			set { _times = value; }
		}
		private _dist.Prob4dbl _prob;

		/// <summary>
		/// probability for a single toss of coin
		/// </summary>
		public _dist.Prob4dbl prob
		{
			get { return _prob; }
			set { _prob = value; }
		}

		public BinomialDbl(uint n, _dist.Prob4dbl prob)
		{
			this._times = n;
			this._prob = prob;
		}

		public BinomialDbl(uint n, double v):this(n,new _dist.Prob4dbl(v))
		{
		}

		public double unintendedProb {
			get {
				return 1 - _prob;
			}
		}

		public double variance {
			get {
				return _times * _prob * unintendedProb;
			}
		}

		public double mean { get {
				return _times * _prob;
			} }

		public _dist.Prob4dbl prob_assumeLeTotal(uint k) { 

			return new _dist.Prob4dbl(
				Combinate.Eval(times,k)
				*
				Math.Pow(prob._val,(double)k)
				*
				Math.Pow((1-prob._val),times-k)
			);
		
		}
		
		
		
	}
}
