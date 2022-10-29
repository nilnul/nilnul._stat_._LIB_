using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.hash
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// when we hash txt of various length, we get a fixed lengthed vec.
	/// How about the distribution?
	///		it might be cyclic (big one). If it's cyclic, then it can be uniform inside the initial cycle. Eg: it can be uniform for the range of [0,6). for [6,12), we map [6,12) to [0,6) and we get the same result. In this way, the hashed result is evenly distributed.
	///		if it's not cyclic, it's surely not uniform, as there is no uniform distribution for infinite many txts.
	///		
	/// todo: further investigation needed. We may first get the distribution of hash function, then we can, from the characteristics of the distribution, determine whether it's cyclic at some interval.
	///  or we can treat each char as an opCode, which transits the state of the hash machine. When the states are collected as the input goes long enought, we might find a state machine that surely transits to a state given an initial state and a specific opCode.
	///
	/// </remarks>
	class Dist
	{
	}
}
