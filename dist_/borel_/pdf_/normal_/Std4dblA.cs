using nilnul.num.real.ext;

namespace nilnul.stat.dist_.borel_.pdf_.normal_
{
	public abstract class Std4dblA
		:
		Std4dblI
	{
		/// <summary>
		/// Note that this integral does not exist in a simple closed formula. It is computed numerically.
		/// </summary>
		/// <param name="upperBound"></param>
		/// <returns></returns>
		public abstract double cdf(double upperBound);
		public abstract double density(double sample);
		public abstract double pmf(Bound4dbl sample);
		public abstract double sample();
	}
}
