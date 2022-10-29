using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.random
{
	public class Rand
	{

		static public readonly Random Instance = new Random(DateTime.Now.Millisecond);
		
				
	}
}
