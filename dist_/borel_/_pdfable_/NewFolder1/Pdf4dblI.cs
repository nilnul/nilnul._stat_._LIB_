using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.borel_._pdfable_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		pdf
	///			there is a file format called pdf;
	///
	[Obsolete(nameof(Density4dblI))]
	public  interface Pdf4dblI
	{
		double pdf(double sample);
	

	}

}
