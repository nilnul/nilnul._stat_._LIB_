using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist.probs.be.vow_
{
	public class BeDefault<TBe>
		:
		be.Vow4dbl
		where TBe: nilnul.obj.BeI1<Probs4dblI>,new()

	{
		public BeDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}


		static public BeDefault<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault<TBe>>.Unison;
			}
		}



	}
}
