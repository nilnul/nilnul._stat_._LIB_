namespace nilnul.stat.dist_.borel.of_.unary_
{
	static public class _VarianceX
	{

		/// <summary>
		/// (X-mean)^2
		/// ;
		/// we then can get the expectation of this rv, and it's called variance.
		/// note here Variance is a rv transform so the result is a rv, and for <see cref="dist_.borel.IVariance"/> is a real number.
		/// </summary>
		/// <param name="mean"></param>
		/// <param name="rv"></param>
		/// <returns></returns>
		static public double _Of_0mean(double mean, double rv) {
			return nilnul.num.real.op_.unary_.Square.Singleton.op (rv - mean);
		}

	}
}
