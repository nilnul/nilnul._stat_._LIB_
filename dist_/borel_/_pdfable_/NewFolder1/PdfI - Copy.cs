﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample
{
	[Obsolete()]
	public partial interface PdfI
	{
		double density(double sample);
		double inversePdf(double probability);
		double inversePdf();
		

	}
}
