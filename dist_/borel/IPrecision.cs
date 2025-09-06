namespace nilnul.stat.dist_.borel
{
	public interface IPrecision { }

	static public class _PrecisionX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// this is a good definition as it's self-evident that:
		///		precision is positive, cuz variance = deviation^2, and 1/variance means variance cannot be zero.
		///	; by this precision, <see cref="nilnul.num.real_.Quotient_denomNonnil"/> shall be tackled differently from <see cref="nilnul.num._real_.ClampI"/> which clamps at a positive number.
		/// </remarks>
		/// <param name="variance"></param>
		/// <returns></returns>
		static public double _Precision_0variance(double variance) {
			return 1 / variance;
		}
	}

}
