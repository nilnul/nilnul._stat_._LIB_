using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite.convert_.purge
{
	public class Ed<T>
		: nilnul.obj.Box_pub<FiniteDbl<T>>
	{
		public Ed(FiniteDbl<T> val) : base(
			_PurgeX.Purge(val)
		)
		{
		}
	}
}
