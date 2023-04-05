using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._stream_;

namespace nilnul._prob.rnd
{
	public class Slider : nilnul.stream.Slider<int>
	{
		public Slider() : base(new _prob.Rnd())
		{
		}
	}
}
