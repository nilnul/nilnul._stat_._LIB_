using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;
using nilnul.collection.set;

namespace nilnul.statistics.randomVariable.discrete
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class FiniteDensityFunction:IFiniteDensityFunction
	{
		private Dictionary<IReal, IReal> _probability;

		#region IFunction<IEnumerableSet<IReal>,IReal,IReal> Members

		public nilnul.collection.set.IEnumerableSet<nilnul.number.real.IReal> domain
		{
			get { 
				return new FiniteSet<IReal>(_probability.Keys); 
			}
		}

		public nilnul.collection.set.ISet<nilnul.number.real.IReal> range
		{
			get {
				return new FiniteSet<IReal>(_probability.Values); 
			}
		}

		public System.Linq.Expressions.Expression<Func<nilnul.number.real.IReal, nilnul.number.real.IReal>> rule
		{
			get {
				return x=>_probability[x]; 
			}
		}

		#endregion
	}
}
