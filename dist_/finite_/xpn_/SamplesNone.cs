using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_.xpn_
{

	[Serializable]
	public class SamplesNone : Exception
	{
		public SamplesNone() { }
		public SamplesNone(string message) : base(message) { }
		public SamplesNone(string message, Exception inner) : base(message, inner) { }
		protected SamplesNone(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
