using nilnul.num.real.ext;




namespace nilnul.stat.dist_.borel_
{
	static public class _BorelX
	{
		static public double Pmf(this _borel_.Cpf4dblI cpf,  Bound4dbl sample)
		{
			/// as we disregard whether border is closed or not, hence we can only do the following on <see cref="IPdf"/>
			return cpf.cumulatedProb(sample.upper.mark.errable) - cpf.cumulatedProb(sample.lower.mark.errable);

		}

	}
}//namespace
