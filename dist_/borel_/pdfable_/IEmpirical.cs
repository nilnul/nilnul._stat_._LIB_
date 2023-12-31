namespace nilnul.stat.dist_.borel_.pdfable_
{
	///
	/// better described by <see cref="_borel_.Cdf4dblI"/>
	/// <summary>
	/// definite;
	/// or <see cref="borel_.IPdf"/> which is not <see cref="borel_.IDiscrete"/> as the keypoints are discrete but tween points are not;
	/// </summary>
	/// <remarks>
	/// converting from <see cref="dist_._finite_.IPmf"/> to <see cref="dist_.borel_.IPdf"/>.
	/// In order for this, we need to make the cdf <see cref="nilnul.num.real.func_.unary_.IContinuous"/>|<see cref="nilnul.num.real.convert_.IContinuous"/>, and piecewise derivable. thus the pdf would be piecewise, maybe steppy or having some discontinuous points;
	///
	/// Thus we first get the <see cref="stat.dist_.finite_.ICmfable"/> (the cmf would be <see cref="borel_.discrete_._finite.ICmf"/>) , then if we need a pdf, we need further make the curve continuous before making it piecewise derivable. (for a cusp point, we can take the avg of flanking points). We can simply make the curve a polyline by connecting adjacent points.
	/// Or we can do a <see cref="dist.IFit"/>|<see cref="dist_.borel_.pdfable.IFit"/> further; 
	///
	/// note: this is different from the conversion of finite into borel <see cref="dist_.IBorel"/>, which would result a naive one: <see cref="dist_.borel_.discrete_._finite.ICmf"/>
	/// </remarks>
	/// <example>
	/// </example>
	/// vs:
	///		<see cref="dist_.IFinite"/>, here we need the pdf; thence, the cmf has to be continouse and piecewise derivable.
	/// alias:
	///		keypoints;
	///		steppy
	///
	public interface IEmpirical:
		//IBorel
		//,
		borel_.IPdf 
	{
	}
}
