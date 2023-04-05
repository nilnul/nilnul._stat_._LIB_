using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob_.trivia.sample_.shuffle_
{
	public class OrdByGuid
	{
		static public IEnumerable<T> _Eval<T>(IEnumerable<T> _finite) {
			return _finite.OrderBy(x => Guid.NewGuid());
		}
	}
}
