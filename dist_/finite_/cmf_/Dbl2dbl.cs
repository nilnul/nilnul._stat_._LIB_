using nilnul._rec_;
using nilnul.stat._dist;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_.cmf_
{
	/// <summary>
	/// at least one el
	/// </summary>
	public class Dbl2dbl :
		nilnul.obj.Box_pub<SortedDictionary<double, Prob4dbl>>
		,
		ICmfable
		,
		dist_.finite_.Cmfable4dblI<double>
	{
		public SortedDictionary<double,Prob4dbl> sortedDict
		{
			get { return boxed; }
		}

		public Dbl2dbl(SortedDictionary<double, Prob4dbl> val) : base(val)
		{
			nilnul.stat._dist.prob.str.be_.nondecrement._VowX.Vow(val.Values);
			nilnul.stat._dist.prob.be_.one._VowX.Vow(val.Values.Last());
		}

		public Dbl2dbl(SortedDictionary<double, double> sortedDictionary)
			:this(
				_dist.PropensesX.ToDict4prob(sortedDictionary)
			)
		{
		}

		public double min => this.boxed.First().Key;
		public double max => this.boxed.Last().Key;
		public double span => max-min;



		public double cumulatedProb(double el)
		{
			//if (el<this.boxed.First().Key)
			//{
			//	return 0;
			//}

			return this.boxed.TakeWhile(x=>x.Key<=el).LastOrDefault().Value?? Prob4dbl.Zero;
		}

		[Obsolete(nameof(cumulatedProb))]
		public double cumulativeDensity(double el)
		{
			return this.boxed.TakeWhile(x=>x.Key<=el).LastOrDefault().Value?? Prob4dbl.Zero;
		}

		public double sample()
		{
			var cp = nilnul.stat.dist_.borel_.pdfable_.uniform_.prob.sample_._RandomX.Next4dbl();
			var cumulated = 0d;

			var r = 0d;

			foreach (KeyValuePair<double, Prob4dbl> item in boxed)
			{
				cumulated += item.Value;
				if (cp<= cumulated)
				{
					r= item.Key;
				}
			}
			throw new UnexpectedReachException("generated random shall be le one of the cumulated probability of the items;");
			//return r;
		}

		public double prob(double sample)
		{
			if (boxed.ContainsKey(sample))
			{
				return boxed[sample];
			}
			return 0;
		}
	}
}
