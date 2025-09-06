namespace nilnul.stat.dist_.finite.of_.measure_
{
	/// <summary>
	/// sample with a count of how many times it occurs;
	/// the input is a bag, a special measure;
	/// </summary>
	/// <remarks>
	/// not evt is repeated twice. for those repeated same evts, <see cref=""/>
	/// </remarks>
	/// alias:
	///		count
	/// vs:
	///		<see cref="ISurvey"/>, which is a sequence of samples with no count of occurrence, and samples may repeat;
	///		
	public interface IRepeatedTimes:IOfMeasures { }


}
