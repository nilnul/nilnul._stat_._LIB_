using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite_
{
	public class Egal<TEvent>
		:
		Finite4dblI<TEvent>
		,
		IEgal
	{
		private HashSet<TEvent> _samples;

		public HashSet<TEvent> samples
		{
			get { return _samples; }
			set { _samples = value; }
		}

		public Egal(

			HashSet<TEvent> samples0

		)
		{
			if (samples0.Any())
			{
				this._samples = samples0;
				_listCached = _samples.ToArray();
				return;
			}
			throw new finite_.xpn_.SamplesNone($"samples cannot be empty;");


		}

		TEvent[] _listCached;
		public TEvent sample()
		{
			 double x= 1d / _samples.Count;

			var index=(int) Math.Floor(  borel_.pdf_.uniform_._Preportion4dblX.Sample() / x );
			if (index  >=_samples.Count) // account for precision issue;
			{
				return _listCached.Last();
			}
			return _listCached[index];

			//throw new NotImplementedException();
		}

		public double pmf(TEvent sample)
		{
			return 1d / _samples.Count;
			//throw new NotImplementedException();
		}
	}
}
