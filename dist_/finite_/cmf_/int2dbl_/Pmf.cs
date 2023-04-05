using nilnul.stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.prob.dist._finite.intDouble
{
	public class Pmf
		:IDist
	{
		private SortedDictionary<int, _prob.InDouble> _dict;

		public SortedDictionary<int, _prob.InDouble> dict
		{
			get { return _dict; }
			set {
				Assert(value);
				_dict = value; }
		}

		
		public Pmf(SortedDictionary<int, _prob.InDouble> dict)
		{
			this.dict = dict;

		}

		public Pmf(IEnumerable<KeyValuePair<int,_prob.InDouble>>  combos)
			
		{
			var dict = new SortedDictionary<int, _prob.InDouble>();
			foreach (var item in combos)
			{
				dict.Add(item.Key,item.Value);
			}
			this.dict = dict;

		}
		static public void Assert(SortedDictionary<int, _prob.InDouble> dict) {
			nilnul.obj.AssertX.True(  dict.Sum(x=>x.Value._val)==1  );
		}

		static public Pmf Pack(Pmf pmf)
		{

			return new Pmf(pmf.dict.Where(x => x.Value._val!= 0));

			

		}


		public class Packed
		{
			private Pmf _pmf;

			public Pmf pmf
			{
				get { return _pmf; }
				set { _pmf = Pmf.Pack(value); }
			}
			private Packed()
			{


			}

			public Packed(Pmf cdf)
			{
				this.pmf=cdf;

			}

			public Packed(SortedDictionary<int, _prob.InDouble> val)
			: this(new Pmf(val))

			{

			}




		}




	}
}
