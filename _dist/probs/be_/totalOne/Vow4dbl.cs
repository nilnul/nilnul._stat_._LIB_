using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M= nilnul.stat.ProbDbl;


namespace nilnul.stat._dist.probs.be_.totalOne
{
	public class Vow4dbl
	   : probs.be.vow_.BeDefault<TotalOne4Dbl>
	   ,
	   nilnul.num.real.str.Vow4dblI

	{
		public void vow(IEnumerable<double> obj)
		{
			if ( ! TotalOne4Dbl.Singleton.be(obj) ) {
				throw new nilnul.obj.be._vow.xpn_.false_.Be8static<
					IEnumerable<
						double
					>
					,
					TotalOne4Dbl
				>(obj);
			}
			//throw new NotImplementedException();
		}


		static public Vow4dbl Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Vow4dbl>.Unison;
			}
		}

	}
}
