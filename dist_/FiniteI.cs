namespace nilnul.stat.dist_
{
	/// <summary>
	/// typical sample's type is num/int;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface FiniteI<T>
		:DistI<T>
		,
		IFinite<T>
	{ }

	public interface _FiniteI<T,TMeasure>
		:FiniteI<T>
		
	{ }


}