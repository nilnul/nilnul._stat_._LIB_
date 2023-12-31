using System;

namespace nilnul.stat.dist_._borel.cpf_
{
	/// <summary>
	/// only when we have a <see cref="borel_.IPdf"/> would we call <see cref="ICpf"/> as <see cref="ICpd"/>;
	/// in other words, this is a Continuous Piecewise Derivable version of <see cref="ICpf"/>, which might be not continuous
	/// </summary>
	/// <remarks>
	/// </remarks>
	///
	public interface ICpd:
		cpf_.contiguous_.IPiecewiseDerivable
		//,
		//nilnul.num.real.convert_.ICpd
	{ }




}
