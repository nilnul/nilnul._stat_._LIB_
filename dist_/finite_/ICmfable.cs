namespace nilnul.stat.dist_.finite_
{
	/// <summary>
	/// the samples are comparable.
	/// So we can transform the elements to intervals.
	/// </summary>
	/// <remarks>
	/// this is necessary for <see cref="_dist_.SampleI{T}"/> to work;
	/// this is to <see cref="IFinite"/> is what <see cref="borel_.IPdf"/> to <see cref="IBorel"/>
	/// </remarks>
	/// alias:
	///		cmf
	///			cumulative mass function, like <see cref="borel.ICdf"/>
	///		ICumulable
	public interface ICmfable
	{
	}

	public interface Cmfable4dblI<T>
		:
		Finite4dblI<T>
	{ }


}
