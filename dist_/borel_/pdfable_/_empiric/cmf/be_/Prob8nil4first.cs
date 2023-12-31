using nilnul.stat.dist_.finite_.cmf_;
using nilnul.stat.dist_.finite_.cmf_.quotient2quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel_.pdfable_._empiric.cmf.be_
{
	/// <summary>
	/// the first's prob is nil. so we have at least two samples;
	/// </summary>
	public class Prob8nil4first
		:
		nilnul.obj.BeA_ofIn<
			 nilnul.stat.dist_.finite_.cmf_.Dbl2dbl
		>
		,
		nilnul.obj.BeI1<
			 nilnul.stat.dist_.finite_.cmf_.Dbl2dbl
		>
		,
		nilnul.obj.BeI1<
			 nilnul.stat.dist_.finite_.cmf_.quotient2quotient_.CpfBySortedDict
		>


	{
		public override bool be(in Dbl2dbl val)
		{
			return val.sortedDict.First().Value == 0;
		}

		public bool be(CpfBySortedDict obj)
		{
			return obj.First().Value == 0;
		}

		static public Prob8nil4first Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Prob8nil4first>.Unison;
			}
		}

	}
}
