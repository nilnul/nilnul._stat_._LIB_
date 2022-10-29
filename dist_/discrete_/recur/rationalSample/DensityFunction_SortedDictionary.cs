using nilnul.num.rational;
using nilnul.prob.discrete;
using nilnul.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.prob.rationalProb.rationalSample
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class DensityFunction_sortedDict
	{

		private SortedDictionary<Rational_InheritFraction,Prob> _sortedList=new SortedDictionary<Rational_InheritFraction,Prob>(nilnul.num.rational.order.Comparer.Instance);

		public SortedDictionary<Rational_InheritFraction,Prob> sortedList
		{
			get { return _sortedList; }
			private set {
				_sortedList = value; 
			}
		}

		public DensityFunction_sortedDict(
			NotNull2<
	IEnumerable<Event>> samples
)
		{
			nilnul.prob.rationalProb.DensityFunctionX.SumIsOneAssert(samples.val);
			foreach (var item in samples.val)
			{
				_sortedList.Add(item.sample, item.probability);
			}
		}

		public DensityFunction_sortedDict(
			IEnumerable<Event> samples
		)
			:this(samples.ToNotNull())
			
		{
			
		}

	
					
		

	
					

	}
}
