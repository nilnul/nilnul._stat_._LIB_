namespace nilnul.stat.dist_._borel_
{
	/// <summary>
	/// for borel, the sample is not real numbers, but incomple interval: [-inf, x) or [-inf, x].
	/// as x grows, the interval grows (becomes a supset of the previous); and in this sense, Cpf is a nondecreasing function;
	/// </summary>
	/// <remarks>
	/// and other interval, or calculation of interval can be derived eversince;
	/// We cannot call this cdf, as density is not well defined here cuz some points are discontinuous thus only prob, not density, is defined for it 
	/// </remarks>
	/// 
	public interface ICpf { }


}
