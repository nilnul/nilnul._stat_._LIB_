namespace nilnul.stat.dist_._borel
{
	/// A function F(x) is a valid CPF, meaning that there exists a random variable X for which P[X≤x] = F(x) for all x∈R, if and only if these four criteria are satisfied:
	/// F(x) is nondecreasing.
	/// limx→−∞F(x)=0.
	/// limx→∞F(x)=1.
	/// F(x) is right-continuous.
	///
	///
	///
	///
	///
	/// 
	/// <summary>
	/// a cpf might be discontinous; while a <see cref="ICdf"/> is <see cref="nilnul.num.real.convert_.continuous_.IPiecewiseDeriable"/>;
	/// </summary>
	/// <remarks>
	/// for <see cref="stat.dist_.finite_.ICmfable"/>, we have no density function;
	/// for borel, this is the same as <see cref="ICdf"/>;
	///
	/// 	 Note: here it's denoted as probability|"distribution", not "density".
	/// </remarks>
	/// alias:
	///		cpf
	///			cumulative probability funciton;
	///		cdf
	///			cumulative distribution function; note here d means not density but distribution.
	/// alias:
	///		Df
	///		distribution function;
	///

	public interface ICpf
		:cmf_.IOfIncomplete

	{ }

}
