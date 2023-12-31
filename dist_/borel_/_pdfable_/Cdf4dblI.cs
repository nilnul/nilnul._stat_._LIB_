using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_._pdfable_
{

	/// <summary>
	/// for one point, the prob is always nil. so the density of one point doesnot matter much. Why? cuz sigma field is defined upon discrete union, and discrete union in continuum carries no much weight;
	/// </summary>
	/// <remarks>
	/// the prob of [-inf, x]. note whether the border is closed or not doesnot matter much, as the prob of single point is zero.
	/// This implies that <see cref="IDensity"/> is nil at +inf, or -inf;
	/// </remarks>
	public partial interface Cdf4dblI
		:
		//cpf_.ICdf
		//,
		_borel_.Cpf4dblI


	{
		///// <summary>
		///// 
		///// </summary>
		///// <param name="upperBound"></param>
		///// <returns>
		///// p(t<=x)
		///// </returns>
		//double cpf(double upperBound);


		



	}
}
