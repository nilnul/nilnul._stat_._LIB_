namespace nilnul.stat._dist_
{
	/// <summary>
	/// probability of a basic sample from the sample space; the basic sample is a point  for <see cref="dist_.discrete_"/>, and is an interval for <see cref="dist_.IBorel"/>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// alias:
	///		prob
	///		pmf
	///			where mass is the measure of the physical mass, on the other hand, density is the mass/volume.
	///		
	/// <seealso cref="dist_._borel_.ICmf"/>|<seealso cref="dist_._borel_.ICdf"/>, and <see cref="dist_.borel_._finite_.ICmf"/>, and <see cref="dist_.borel_._pdfable_.Pdf4dblI"/>
	public interface IPmf { }
}
