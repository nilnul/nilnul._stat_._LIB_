namespace nilnul.stat.dist_._cpfable_
{
	///
	/// as there is only <see cref="_dist_.IPmf"/>, no <see cref="_dist_.IPpf"/>, we have <see cref="_cmfable_.ICmf"/> first, and then derive <see cref="ICpf"/>
	/// <summary>
	/// <see cref="_dist_.IPmf"/>
	/// </summary>
	/// vs:
	///		<see cref="_cmfable_.ICmf"/>, where the input is a set.
	///			for this, the input is a sample implying a set of {x|x le sample};
	public interface ICpf
		:_cmfable_.ICmf
	{ }


}
