﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.doubleProb.doubleSample
{
	public partial interface PdfI
	{
		double density(double sample);
		double inversePdf(double probability);
		double inversePdf();
		

	}
}
