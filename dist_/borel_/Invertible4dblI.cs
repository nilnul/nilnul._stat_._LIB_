namespace nilnul.stat.dist_.borel_
{
	/// <summary>
	/// not allow exception; (exception would always be possible; so allowing would not forbid, but unexpect exception)
	/// </summary>
	public interface Invertible4dblI
		:
		Borel4dblI
		,
		_invertible_.Invert4dblI
	{ }

}
