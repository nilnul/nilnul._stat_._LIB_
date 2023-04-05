using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat._dist
{
	/// <summary>
	/// a measure for each.  the measure is normalized into [0,1];
	/// </summary>
	/// <remarks>
	/// hence it must be real number, not quotient; but it might happen to be a <see cref="nilnul.num.real_.Quotient"/>, and we only apply some quotient.operators,resulting only quotients;
	/// </remarks>
	public interface  IProb
		:nilnul.collection._measure_.MeterI
		,
		nilnul.num.IReal
	{
	}
}
