namespace nilnul.stat.dist_.borel_.pdfable_
{
	/// <summary>
	/// beta distribution, std or spanned;
	/// </summary>
	/// <remarks>
	/// vs:
	///		<see cref="nilnul.num.real.func_.binary_.IBeta"/> where xpn is thrown outside span ,whileas this would treat it as if the density outside the span is zero;
	/// </remarks>
	public interface IBeta:IBorel { }
}
