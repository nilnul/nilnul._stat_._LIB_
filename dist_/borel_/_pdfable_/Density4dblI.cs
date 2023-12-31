using nilnul.num.quotient_;
using nilnul.prob._continuum_;

namespace nilnul.stat.dist_.borel_._pdfable_
{
	public interface _DensityI<TSample,TProb>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns>
		/// in [0, +inf]
		/// </returns>
		TProb density(TSample sample);
	}
	public interface _DensityI<T>
		:
		_DensityI<T,T>
	{
		
	}


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.num.real.ext.func_.IUnary"/>, where for inf, the measure must be nil if the func is continous|asmptomic at inf;
	/// </remarks>
	public interface Density4quotientI
		:
		_DensityI<DenomNonnil>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns>
		/// in [0, +inf]
		/// </returns>
		//double density(double sample);
	}
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// <see cref="nilnul.num.real.ext.func_.IUnary"/>, where for inf, the measure must be nil if the func is continous|asmptomic at inf;
	/// </remarks>
	public interface Density4dblI
		:_DensityI<double>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns>
		/// in [0, +inf]
		/// </returns>
		//double density(double sample);
	}

}
