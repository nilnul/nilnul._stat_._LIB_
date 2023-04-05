namespace nilnul.stat._dist
{
	/// shall we use this as <see cref="_dist.IMap"/>?
	///
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// note sample is different from event; the former is a member of the Set:event whileas the latter is a member of the family:Field; the former is an obj, the latter is a a set of obje;
	/// </remarks> 
	/// alias:
	///		occur
	///		event
	///			conflicting with c# event;
	///		evt
	///		
	public interface IEvent
		:nilnul.collection._measure_.SpaceI
	{ }
}
