using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite
{
	/// <summary>
	/// assign  probs to  a str of distributions. distribution of distributions 
	/// </summary>
	public class ConditionalInDbl<TKey, TKey1>
		: Dictionary<TKey, (stat.ProbDbl, nilnul.stat.dist_.FiniteDbl<TKey1>)>
	{
	

		public ConditionalInDbl(IDictionary<TKey, (ProbDbl, FiniteDbl<TKey1>)> dictionary) : base(dictionary)
		{

			nilnul.stat.prob.str.be_.totalOne._VowX.Vow(
				dictionary.Values.Cast< (ProbDbl, FiniteDbl<TKey1>)>().Select(tuple=>tuple.Item1)
			);

		}



		
	}
}
