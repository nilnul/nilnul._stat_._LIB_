namespace nilnul.stat.dist_
{
	/// <summary>
	/// the measure is double.
	/// typical sample's type is num/int;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface Finite4dblI<T>
		:DistI<T>
		,
		_finite_.Pmf4dblI<T>
	{ }

}