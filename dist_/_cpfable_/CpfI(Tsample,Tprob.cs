namespace nilnul.stat.dist_._cpfable_
{
	public interface CpfI<TSample,TProb>
		:ICpf
		,
		_cmfable_.CmfI<TSample,TProb>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="upperBound"></param>
		/// <returns>
		/// p(t<=x)
		/// </returns>
		//TProb cumulatedProb(TSample upperBound);

	}


}
