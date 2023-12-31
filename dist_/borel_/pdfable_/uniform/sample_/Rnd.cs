using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._prob
{
	/// <summary>
	/// return [0, int.max)
	/// </summary>
	/// <remarks>
	///		1) Name:rnd, to avoid conflict with System.Random.
	///		
	///		2) Take the generator that generates integers rather than real numbers as cannonical.
	///		This will generate integerers. For a random number to generate a real number in [0,1) is hard, and may need third party , and maybe theoretically hard to be solidly founed.
	///		System.Random constructor only accept int as seed value; this tells that it's a generator of "integer"s
	/// </remarks>
	public class Rnd
		: _stream_.NextI<int>
	{

		static public Random StaticRnd=new Random();


		private Random _rnd;
		
		public Rnd(
				
		):this( new Random(StaticRnd.Next()))
		{
			
		}

		public Rnd(Random rnd)
		{
			_rnd = rnd;
		}
		public Rnd(int seed)
		{
			_rnd = new Random(seed);
		}
		public int next()
		{
			return _rnd.Next();

			//throw new NotImplementedException();
		}
	}
}
