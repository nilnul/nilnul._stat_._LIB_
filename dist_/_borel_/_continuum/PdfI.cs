using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public  interface PdfI<T>
	{
		Prob density(T sample);



	}
}
