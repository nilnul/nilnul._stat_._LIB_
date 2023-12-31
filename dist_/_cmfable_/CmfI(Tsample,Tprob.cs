namespace nilnul.stat.dist_._cmfable_
{
	public interface CmfI<TSample,TProb>
		:ICmf
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="upperBound"></param>
		/// <returns>
		/// p(t<=x)
		/// </returns>
		TProb cumulatedProb(TSample upperBound);

	}


}
