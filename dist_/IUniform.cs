namespace nilnul.stat.dist_
{
	/// <summary>
	/// the density of each sample is the same;
	/// <see cref="finite_.IUniform"/> and <see cref="borel_.IUniform"/>
	/// </summary>
	/// vs:
	///		random, where the dist is unknown (undefinite/indefinite, where we can have any distrition except <see cref="dist_.finite_.IDefinite"/>) , whileas this is known distribution where the entropy is maximized;
	///			<seealso cref="borel_.boundaried.survey_.counted_.aim_.avg_._RandomizeThenNormalizeX"/>,where we survey a collection of samples randomly, but the sample is not uniform distributed;
	public interface IUniform { }
}
