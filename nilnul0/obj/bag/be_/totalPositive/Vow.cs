using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.bag.be_.totalPositive
{
	public class Vow<TKey>:nilnul.obj.be.vow_.BeDefaultable<
		nilnul.obj.Bag1<TKey>
		,
		obj.bag.be_.TotalPositive<TKey>
	>
	{


		static public Vow<TKey> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow<TKey>>.Instance;
			}
		}

	}
}
