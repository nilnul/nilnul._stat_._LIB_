namespace nilnul.stat.dist_.borel_._pdfable
{
	/// <summary>
	/// only when we have a <see cref="borel_.IPdf"/> would we call <see cref="ICpf"/> as <see cref="ICdf"/>;
	/// in other words, this is a Continuous Piecewise Derivable version of <see cref="ICpf"/>, which might be not continuous
	/// cumulative distribution function; that is P(X le x):=F(x).
	/// For pdfable, the cumulative density happens to be what we need;
	/// 
	/// For pdfable, the cumulative density happens to be cmf;
	/// </summary>
	/// <remarks>
	/// of interval from -inf to x.
	///
	/// for nonpdfable, the <see cref="dist_.finite_.ICmfable"/> is what we need.
	/// 
	/// </remarks>
	public interface ICdf
		:
		//_borel.ICmf
		//,
		_borel.cpf_.contiguous_.IAbsoluteContinous
		//,
		//dist_._cmfable_.ICmf
		//,
		//nilnul.num.real.ext.func_.unary
	{ }


}
