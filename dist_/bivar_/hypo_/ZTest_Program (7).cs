using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.statistics.hypothesisTest
{
	public partial class ZTest_Program
	{
		static public void Main() {
			Console.WriteLine("z:{0}",ZTest.Z(2,40,25,41.25,.05));
			Console.WriteLine("interval:{0}",ZTest.RightSide(2,40,25,.05));
			Console.Read();
		}
	}
}
