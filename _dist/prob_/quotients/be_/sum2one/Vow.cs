using nilnul.set;
using nilnul.stat._dist.propense_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace nilnul.stat._dist.prob_.quotients.be_.sum2one
{
	/// <summary>
	/// 
	/// </summary>
	/// tODO: finitedistribution
	
	public class Vow
		:
		nilnul.obj.be.vow_.BeDefaulted4<IEnumerable<Prob8quotient>,Sum2one>
	{

		public void vow(IEnumerable<Quotient8quotient> val)
		{
			base.vow(val.Select(p=>p.probabilityNotNull));
		}


		static public Vow Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Vow>.Unison;
			}
		}

	}
}
