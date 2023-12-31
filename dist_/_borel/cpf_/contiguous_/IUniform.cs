using System;

namespace nilnul.stat.dist_._borel.cpf_.contiguous_
{
	[Obsolete("as this is on a closed interval, it's always uniform;")]
	public interface IUniform
		:IContiguous
		,
		nilnul.num.real.op_.continuous_.IUniform
	{ }


}
