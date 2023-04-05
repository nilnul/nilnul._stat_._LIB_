using System;

namespace nilnul.stat.dist_.borel_
{
	/// <summary>
	/// there exists <see cref="borel.ICdf"/>
	/// </summary>
	///
	[Obsolete(nameof(dist_.IBorel) + " is preferred as all Borel is cdfable;")]
	public interface ICdfable:IBorel
	{ }
}
