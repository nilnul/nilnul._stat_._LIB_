using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.finite_
{

	/// <summary>
	/// some variant/version might use:
	///		Mac Address
	///		and time
	///	So this can be traced back.
	///
	/// some variant/version use randomized. Can not be traced back.
	/// </summary>
	static public class _GuidX
	{
		static public string Sample_NoHyphen() {
			return Guid.NewGuid().ToString("N");
		}

		static public byte[] SampleAsBytes() {
			return Guid.NewGuid().ToByteArray();
		}

		static public BigInteger SampleAsInteger() {
			return new BigInteger(
				Guid.NewGuid().ToByteArray().Append((byte)0).ToArray()
				
			);
		}



	}
}

