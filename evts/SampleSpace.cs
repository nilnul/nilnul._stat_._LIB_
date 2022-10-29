using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;


namespace nilnul.prob
{

	/// <summary>
	

	///The set of all possible outcomes of an experiment--------it's a set, not a set of set.
	///
	/// e.g., toss the coin, the sample space will be {H,T}.
	/// 
	/// While event is the subset of sample space. e.g. {H,T}, i.e., it's H -OR- T; and {}, it's neither H nor T.
	/// 
	/// 
	///



	/// </summary>
	public partial class SampleSpace
		:
		SampleSpaceI
	{
		//public SamplePointI[] arr => throw new NotImplementedException();

		//public IEqualityComparer<SamplePointI> eleEq => throw new NotImplementedException();

		public bool contains(SamplePointI a)
		{
			throw new NotImplementedException();
		}
	}



	
}
