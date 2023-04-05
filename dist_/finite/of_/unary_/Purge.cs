using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.convert_
{
	static public class _PurgeX
	{
		static public Finite4dbl<T> Purge<T>(Finite4dbl<T> dist) {
			return  Finite4dbl<T>.Create(
				dist.Comparer,
				dist.Where(x=>x.Value>0)
			);
		}
	}
}
