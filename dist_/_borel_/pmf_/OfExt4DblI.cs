namespace nilnul.stat.dist_._borel_.pmf_
{
	/// <summary>
	/// this supersedes <see cref="OfFinite4DblI"/> as we can always let the measure for inf as nil; in fact, we need the measure for inf to be nil, as when inf is approached, the interval being followed by approaching is not nil, and we need inf measure to be nil for the measure of that followed interval to be bounded;
	/// </summary>
	public interface OfExt4DblI
		:
		Pmf4dblI<num.real.ext.Bound4dbl >
	{

	}



}
