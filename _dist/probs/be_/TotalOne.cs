using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M= nilnul.stat.ProbDbl;


namespace nilnul.stat._dist.probs.be_
{
	 public class TotalOne4Dbl: probs._be_.IOfSeq4Dbl
		,
		nilnul.num.real.str.Be4dblI
	{

		public bool be(IEnumerable<Prob4dbl> obj)
		{
			return probs._TotalX.Dbl(obj) == 1;
		}

		public bool be(IEnumerable<double> obj)
		{
			return obj.Sum() == 1;
			//throw new NotImplementedException();
		}

		static public TotalOne4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<TotalOne4Dbl>.Instance;
			}
		}

	}
}
