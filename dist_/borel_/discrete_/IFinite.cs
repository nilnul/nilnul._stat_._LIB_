using System;

namespace nilnul.stat.dist_.borel_
{

	/// <summary>
	/// although this can be described by <see cref="IBorel"/>, it's an overkill-borel is for <see cref="borel_.IPdf"/>; it's most becoming description is <see cref="dist_.IFinite"/>
	/// </summary>
	[Obsolete("this can be described by: "+ nameof(dist_.IFinite))]
	public interface IFinite :IBorel{ }

}
