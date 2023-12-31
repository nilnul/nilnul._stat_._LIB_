namespace nilnul.stat.dist_
{
	/// <summary>
	/// typical sample is of type int/uint/num;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface Discrete4dblI<T>
		:DistI<T>
		,
		_finite_.Pmf4dblI<T>
	{ }

}