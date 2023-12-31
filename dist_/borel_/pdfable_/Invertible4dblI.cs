namespace nilnul.stat.dist_.borel_.pdfable_
{
	/// <summary>
	/// we require it to be invertible on only the <see cref="borel_._scoped_.Scope4dblI"/>;
	///  and it might be not invertible when randomized feed is nil, or 1; eg:
	///		<see cref="borel_.Exp4dbl"/>, which is invertible for [0,inf), but not (-inf, 0], we only take values from <see cref="borel_._scoped_.Scope4dblI"/> as the returned value from <see cref="_dist_.SampleI{T}"/>;
	///		
	/// It's exception if the cdf is not invertible one <see cref="borel_._scoped_.Scope4dblI"/>; here we may let the scope be a union of disjoint interval;
	///		
	/// </summary>
	public interface Invertible4dblI
		:
		Pdf4dblI
		,
		borel_.Invertible4dblI
		//,
		//_invertible_.Invert4dblI
	{ }

}
