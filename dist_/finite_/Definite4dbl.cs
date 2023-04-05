using nilnul.characters_;
using System.Collections.Generic;

namespace nilnul.stat.dist_.finite_
{
	/// not in <see cref="cmf_"/> as we need the typ to be comparable, and the sample is thought of one of all the instances; or in other words, the scope of the distribution is all the intances of the type;
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Definite4dbl<T>

		:
		_definite_.SampleA<T>
		,
		//_dist_.Prob4dblI<T>
		//,
		//Dist4dblI<T>
		//,
		dist_.Finite4dblI<T>
		,
		dist_.ITrivia
		
	{

		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}


		public Definite4dbl(T mean, IEqualityComparer<T> eq):base(mean)
		{
			this._eq = eq;
		}

		public Definite4dbl(T mean):this(mean, EqualityComparer<T>.Default)
		{
			
		}



		public double pmf(T sample)
		{

			return prob_nil4nonsample(sample) ; 
			//throw new System.NotImplementedException();
		}
		public double prob_xpn4nonsample(T sample)
		{
			return _eq.Equals(sample, this.mean) ? 1 : throw new dist.sample_.xpn_.NotInDomain() ;
			//throw new System.NotImplementedException();
		}


		public double prob_nil4nonsample(T sample)
		{
			return _eq.Equals(sample, this.mean) ? 1 : 0;
			//throw new System.NotImplementedException();
		}


	}
}
