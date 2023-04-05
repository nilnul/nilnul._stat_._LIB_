namespace nilnul.stat.dist_.borel_._pdfable_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.num.real.ext.func_.IUnary"/>, where for inf, the measure must be nil if the func is continous|asmptomic at inf;
	/// </remarks>
	public interface Density4dblI
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns>
		/// in [0, +inf]
		/// </returns>
		double density(double sample);
	

	}

}
