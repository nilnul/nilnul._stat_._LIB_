using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.number.real;
using nilnul.number.integer;
using nilnul.combinatorics;
using nilnul.statistics.basic;
using nilnul.collection.interval;


namespace nilnul.statistics.randomVariable.discrete.distributions
{

	//public delegate IReal combi(IReal a);

	public class BinomialDensityFunction:IBinomialDensityFunction
	{
		private IProbabilityReal _p;
		private INonnegativeInteger _n;

		public IProbabilityReal p {
			get {
				return _p;
			}
			set {
				this._p= value;
				

			}
		}


		#region IFunction<IEnumerableSet<IReal>,IReal,IReal> Members

		public nilnul.collection.set.IEnumerableSet<nilnul.number.real.IReal> domain
		{
			get { 
				return new ClosedInterval<IReal>(0,n);
			}
		}

		public nilnul.collection.set.ISet<nilnul.number.real.IReal> range
		{
			get { throw new NotImplementedException(); }
		}

		public System.Linq.Expressions.Expression<Func<nilnul.number.real.IReal, nilnul.number.real.IReal>> rule
		{
			get { 
				return k=>new Combination(n,k) * p^ k *(1-p)^(1-k);
			}
		}

		#endregion

		#region IFunction<IEnumerableSet<IReal>,IReal,IReal> Members

		nilnul.collection.set.IEnumerableSet<IReal> nilnul.function.basic.IFunction<nilnul.collection.set.IEnumerableSet<IReal>, IReal, IReal>.domain
		{
			get { throw new NotImplementedException(); }
		}

		nilnul.collection.set.ISet<IReal> nilnul.function.basic.IFunction<nilnul.collection.set.IEnumerableSet<IReal>, IReal, IReal>.range
		{
			get { throw new NotImplementedException(); }
		}

		System.Linq.Expressions.Expression<Func<IReal, IReal>> nilnul.function.basic.IFunction<nilnul.collection.set.IEnumerableSet<IReal>, IReal, IReal>.rule
		{
			get { throw new NotImplementedException(); }
		}

		#endregion

		#region IBinomialDensityFunction Members


		public nilnul.number.integer.INonnegativeInteger n
		{
			get
			{
				return _n;
			}
			set
			{
				_n=value;
			}
		}

		#endregion
	}
}
