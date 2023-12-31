using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist.sample_.xpn_
{

	/// <summary>
	/// <see cref="stat.dist_.finite_.Definite4dbl{T}.prob(T)"/> would throw exception if you ask for the probability of an instance not in domain; it's a subtle difference from a sample of 0 probability; for example, In <see cref="dist_.IBorel"/>, for a single point, the prob is nil but it's still possible;
	/// </summary>
	[Serializable]
	public class NotInDomain : Exception
	{
		public NotInDomain() { }
		public NotInDomain(string message) : base(message) { }
		public NotInDomain(string message, Exception inner) : base(message, inner) { }
		protected NotInDomain(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
