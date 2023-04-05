using System;

namespace nilnul.stat._dist_
{
	public interface _PmfI<TEvent,TMeasure>
		//where TMeasure:nilnul.num.IReal //according to measure theory;
		/// unconstrained to allow for double, a loosely|unstandard defined real
		///
		:IPmf
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sample"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(_dist.IProb) +"is occupying the name; so plz use:" + nameof(IPmf))]
		TMeasure pmf(TEvent sample);
	}
}
