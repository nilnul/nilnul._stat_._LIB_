using System;

namespace nilnul.stat.dist_._cmfable_
{
	/// corresponding to <see cref="_dist_.IPmf"/>;
	/// this shall come before <see cref="_cpfable_.ICpf"/>;
	///
	/// with this, we are able to define a dist as the cumulated prob of a growing set of samples from smallest to largest.
	/// eg:
	///		borel is defined on growing interval of [-inf,x], otherwise, the uncountable sample set is undefinable as for a sigma field, the sum to be finite entails that the measure of each sample is nilable.
	/// <summary>
	/// for discrete sample space, the samples can be a growing set;
	/// for borel, the samples have to be incomplete intervals growing;
	/// </summary>
	/// alias:
	///		cmf
	///			where m means mass whileas d in cdf means density and has to mulitiply an interval to get the mass;
	///
	///[Obsolete(nameof(_cpfable_.ICpf))]
	public interface ICmf { }


}
