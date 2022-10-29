using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist.prob.str.vow.ee_
{
	public class VowDefault<TVow>
		: vow.Ee4dbl
		where TVow : nilnul.obj.VowI2<IEnumerable<Prob4dbl>>, new()
	{
		public VowDefault(IEnumerable<Prob4dbl> val) : base(
			val
			, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
