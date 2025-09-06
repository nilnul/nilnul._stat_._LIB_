namespace nilnul.stat.dist_
{
	/// <summary>
	/// multivariate distribution is still <see cref="IDist"/> in that the multivariate tuple is drawn from an eventSpace;
	/// the random var is a <see cref="nilnul.num.real.IVec"/>
	/// </summary>
	/// <remarks>
	/// 
	/// vs:
	///		<see cref="dists"/>
	/// </remarks>
	/// alias:
	///		multidimensional
	///		dimensional
	///		geometry
	///		multivariate
	///			multivar
	///		vec
	///		variate
	public interface IMultivariate
	:IDist{ }
}
