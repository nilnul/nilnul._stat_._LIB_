using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using R=nilnul.num.rational.Rational_InheritFraction;

namespace nilnul.prob.sample.rational
{
	public partial class BagNonEmpty
		:
		nilnul.num.natural.collection.Bag<R,R.Eq>.Empty.NounAntonym

	{

		public BagNonEmpty(nilnul.num.natural.collection.Bag<R, R.Eq> bag)
			:base(bag)
		{
		}
					
		
	}
}
