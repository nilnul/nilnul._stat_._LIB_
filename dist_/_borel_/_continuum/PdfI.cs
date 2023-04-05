using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb
{
	public partial interface PdfI<T>
	{
		Prob density(T sample);



	}
}
