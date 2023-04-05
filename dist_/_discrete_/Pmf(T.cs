using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._discrete_
{
	public interface PmfI<T>
	{
		double pmf(T sample);
	}
}
