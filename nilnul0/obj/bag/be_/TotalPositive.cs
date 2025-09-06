using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.bag.be_
{
	public class TotalPositive<TKey> : nilnul.obj.BeI1<nilnul.obj.Bag1<TKey>>
	{
		public bool be(Bag1<TKey> obj)
		{
			return nilnul.num.accumulate_._SumX.Bigint( obj.Values.Cast<nilnul.Num1>().Select(x=>x.en)) ==1;
		}

		static public TotalPositive<TKey> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<TotalPositive<TKey>>.Instance;
			}
		}

	}
}
