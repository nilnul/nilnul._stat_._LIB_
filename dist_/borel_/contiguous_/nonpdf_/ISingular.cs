namespace nilnul.stat.dist_.borel_.contiguous_.nonpdf_
{
	/// <summary>
	/// sometimes called singular continuous distributions;
	/// </summary>
	/// <remarks>
	///Such distributions are not absolutely continuous with respect to Lebesgue measure.
	/// </remarks>
	/// A singular distribution is not a discrete probability distribution because each discrete point has a zero probability. On the other hand, neither does it have a probability density function, since the Lebesgue integral of any such function would be zero.
	/// Less curious examples appear in higher dimensions. For example, the upper and lower Fréchet–Hoeffding bounds are singular distributions in two dimensions.
	public interface ISingular
		:
		//IBorel,contiguous_.ISingular
		//,
		contiguous_.INonpdfable

	{
//neither a discrete random variable (since the probability is zero for each point) nor an absolutely continuous random variable (since the probability density is zero everywhere it exists).

	}
}
