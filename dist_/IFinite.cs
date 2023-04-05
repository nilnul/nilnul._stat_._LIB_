namespace nilnul.stat.dist_
{
	/// <summary>
	/// the sigma field, a family, a set of sets, is finite
	/// </summary>
	/// <remarks>
	/// PMF is enough to represent finite distribution.
	/// CMF can be derived from PMF
	///
	/// </remarks>
	public interface IFinite:IDist { }

	/// <summary>
	/// the measure is priori deemed as <see cref="nilnul.num.IReal"/>, as defined by <see cref="nilnul.collection_.axiomic.IMeasure"/>
	/// </summary>
	/// <typeparam name="TSample"></typeparam>
	public interface IFinite<TSample> : IFinite { }

	public interface IFinite<TSample, TMeasure> : IFinite<TSample> {

	}

}