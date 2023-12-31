namespace nilnul.stat.dist_.finite.of_
{
	/// <summary>
	/// sample with a count of how many times it occurs;
	/// the input is a bag, a special measure;
	/// </summary>
	/// vs:
	///		<see cref="ISurvey"/>, which is a sequence of samples with no count of occurrence, and samples may repeat;
	/// alias:
	///		ofCounts
	///		OfRepeats
	///		ofRepeation
	///		recur
	///		reoccur
	///		cardinality
	///		replicate
	///			not duplicate
	///		OfRepetition
	public interface IOfOccurs:measure_.IRepeatedTimes { }
}
