namespace nilnul.stat.dist_.borel_
{
	/// <summary>
	/// 
	/// if it's pdfable, then it's integrable; and the measure of any point is zero;
	/// the <see cref="borel_._scoped_.Scope4dblI"/> might be not <see cref="num.real.interval_.IAll"/>|omega;
	/// eg:
	///		<see cref="borel_.Exp4dbl"/>
	/// excluding:
	///		<see cref="borel_.IFinite"/>
	///		<see cref="borel_.IDiscrete"/> where some point's measure is not zero;
	/// </summary>
	public interface IPdf : IBorel { }
}
