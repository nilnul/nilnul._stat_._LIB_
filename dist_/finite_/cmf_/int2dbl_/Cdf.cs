using nilnul.prob.rationalProb.rationalSample;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LessThan = nilnul.num.rational.order.LessThan;

namespace nilnul.prob.dist._finite.intDouble
{
	public partial class Cdf
	{
		private SortedDictionary<int, _prob.InDouble> _dict;

		public SortedDictionary<int, _prob.InDouble> dict
		{
			get { return _dict; }
			set
			{
				Assert(value);
				_dict = value;
			}
		}

		private Cdf() { }

		public Cdf(
			SortedDictionary<int, _prob.InDouble> dict
		)
		{
			this.dict = dict;
		}
		static public bool Be(SortedDictionary<int, _prob.InDouble> dict)
		{
			var monotone = true;
			for (int i = 1, j = 0; i < dict.Count; i++, j++)
			{
				if (dict.ElementAt(i).Value._val < dict.ElementAt(j).Value._val)
				{
					monotone = false;

				}
			}


			return monotone && dict.Last().Value._val == 1;
		}

		static public void Assert(
			SortedDictionary<int, _prob.InDouble> dict)
		{

			nilnul.obj.AssertX.True(Be(dict));

		}


		static public Cdf Pack(Cdf cdf)
		{

			var list = new SortedDictionary<int,_prob.InDouble>();

			double lastAddedProb = 0;

			for (int i = 0; i < cdf.dict.Count(); i++)
			{

				if (cdf.dict.ElementAt(i).Value._val != lastAddedProb)
				{
					var lastAdded1 = cdf.dict.ElementAt(i);
					lastAddedProb = lastAdded1.Value._val;
					list.Add(lastAdded1.Key,lastAdded1.Value);

				}
			}

			return new Cdf(list);

		}



		static public Cdf Create(Pmf pmf)
		{
			var list = new SortedDictionary<int,_prob.InDouble>();
			var cumulated = 0d;
			foreach (var item in pmf.dict)
			{

				list.Add(item.Key,  new _prob.InDouble( cumulated += item.Value._val));
			}

			return new Cdf() { _dict = list };
		}

		public class Packed
		{
			private Cdf _cdf;

			public Cdf cdf
			{
				get { return _cdf; }
				set { _cdf = Cdf.Pack(value); }
			}
			private Packed()
			{


			}

			public Packed(Cdf cdf)
			{
				_cdf = Cdf.Pack(cdf);

			}
			public int randomSelect()
			{
				var randomIndex = _prob.RandomX.NextDouble();

				for (int i = 0; i < cdf.dict.Count(); i++)
				{
					if (randomIndex < cdf.dict.ElementAt(i).Value._val)
					{
						return cdf.dict.ElementAt(i).Key;
					}
				}





				throw new UnexpectedReachException();


			}

			static public Cdf.Packed Create(Pmf.Packed pmfPacked)
			{
				return new Packed() { _cdf = Cdf.Create(pmfPacked.pmf) };
			}

		}
	}
}
