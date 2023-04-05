using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.borel.sample_.xpn_
{
	/// <summary>
	/// eg:
	///		for <see cref="borel_.Definite4dbl"/>, if cdf =1, we give the value; cdf cannot be other value;
	/// </summary>

	[Serializable]
	public class  NoSuchCdf : Exception
	{
		public NoSuchCdf() { }
		public NoSuchCdf(string message) : base(message) { }
		public NoSuchCdf(string message, Exception inner) : base(message, inner) { }
		protected NoSuchCdf(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
