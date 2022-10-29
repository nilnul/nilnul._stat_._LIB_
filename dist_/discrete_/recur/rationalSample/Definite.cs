using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rational2 = nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.rationalProb.rationalSample
{
	public partial class Definite
		:nilnul.prob.rationalProb.Definite<nilnul.num.rational.Rational_InheritFraction>
		
	
	{
		private Rational2 _mean;

		public Rational2 mean
		{
			get { return _mean; }
			set {
				
				_mean = value.EnsureNotNull(); 
			
			}
		}
		

		public Definite(Rational2 mean)
			:base(mean)
		{
			
		}





	



		public Prob probability(Rational2 x)
		{
			if (nilnul.num.rational.Rational_InheritFraction.Eq.Instance.contains(x, mean)) {
				return Prob.One;
			}
			return Prob.Zero;
		}
	}
}
