using System;

namespace nilnul.stat.dist_.borel_
{
	/// <summary>
	/// there exists <see cref="borel.ICdf"/>
	/// </summary>
	/// <remarks>
	/// the samples are borel sets; but the prob might be discontinous, thus not derivable, thus no pdf 
	/// </remarks>
	/// <see cref="IPdf"/>
	///
	[Obsolete(nameof(dist_.IBorel) + " is preferred as all Borel is cdfable;")]

	public interface ICdfable:IBorel
	{ }
}
