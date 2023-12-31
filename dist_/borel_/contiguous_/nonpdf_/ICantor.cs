namespace nilnul.stat.dist_.borel_.contiguous_.nonpdf_
{
	/// <summary>
	/// the corresponding measure is atomless. This is why there are no jump discontinuities in the function; any such jump would correspond to an atom in the measure.
	/// </summary>
	/// <remarks>
	///no non-constant part of the Cantor function can be represented as an integral of a probability density function;
	/// </remarks>
	/// In particular, as Vitali (1905) pointed out, the function is not the integral of its derivative even though the derivative exists almost everywhere.
	/// 
	///its cumulative distribution function is a devil's staircase.
	///
	///Its cumulative distribution function is continuous everywhere but horizontal almost everywhere, so is sometimes referred to as the Devil's staircase, although that term has a more general meaning.

	public interface ICantor:INonpdfable
		,
		ISingular
	{
//This distribution has neither a probability density function nor a probability mass function,
// as it's samples is not single real number, but intervals;
	}

	public class Cantor4dbl
		:ICantor
	{
		public const double MEAN= .5;
		public const double VARIANCE = 1d / 8;
	}
}
