using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob
{
	/// <summary>
	/// a measure
	/// </summary>
	public partial class Prob1
	{

		public static Random RandomGlobal = new Random();

		public static int Next(int max) {
			return RandomGlobal.Next(max);
		}

	}
}
