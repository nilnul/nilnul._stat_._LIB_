using System;

namespace nilnul.stat.dist_._borel
{
	/// <summary>
	/// a cmf might be discontinous; while a <see cref="ICdf"/> is <see cref="nilnul.num.real.convert_.continuous_.IPiecewiseDeriable"/>;
	/// </summary>
	/// <remarks>
	/// for borel, the cmf is defined on interval from -inf to x: [-inf,x]. And if we use x to denote the interval, and take x as the input, we are converting a cmf to <see cref="ICpf"/>;
	/// Here the intervals can form a growing ordered set;
	/// in fact if it's defined on single real numbers, some would be <see cref="borel_.ISingular"/> and the cmf is nil or not well defined.
	/// </remarks>
	/// 

	//[Obsolete(nameof(ICpf))]
	public interface ICmf
		:
		stat.dist_._cmfable_.ICmf
		//,
		//stat.dist_._cpfable_.ICpf

		//ICpf
	{ }

}
