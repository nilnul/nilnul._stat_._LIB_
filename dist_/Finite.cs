using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_
{

	/// <summary>
	/// a prob on finite set such that we can measure the elements in the set.
	/// </summary>
	public class FiniteDbl<T>
		: Dictionary<T, ProbDbl>

	{

		public FiniteDbl(Dictionary<T, ProbDbl> dict)
			: base(dict)
		{
			nilnul.stat.prob.str.be_.totalOne._VowX.Vow(this.Values);
		}

		static public FiniteDbl<T> Create( IEqualityComparer<T> eq, IEnumerable<KeyValuePair<T, ProbDbl>> enumerable)
		{
			var r = new
			 Dictionary<T, ProbDbl>(eq);
			nilnul.obj.DictX.AddRange(
				r,
				enumerable
			);
			return new FiniteDbl<T>(r);
		}
	}

	public class FiniteDbl : FiniteDbl<double>
	{
		public FiniteDbl(Dictionary<double, ProbDbl> dict) : base(dict)
		{
		}

		public FiniteDbl OvOccurences( Dictionary<double, int> bag) {


			var total = bag.Values.Cast<int>().Sum();//.Select(kv=>kv.Value)

			var probs = new Dictionary<double, ProbDbl>();

			double totalDbl = total;

			bag.Each(
				kv=> probs.Add(kv.Key, new ProbDbl( kv.Value / totalDbl ) )
			);

			return new FiniteDbl(probs);
		}


		public FiniteDbl OvOccurences( IEnumerable<double> els) {
			//var bag1 = new nilnul.obj.bag_.EqDefault<double, nilnul.num.real.EqDbl>();

			var bag11 = new nilnul.num.real.BagOfDbl(
				els
			);

			return OvOccurences(bag11);


		}

		public FiniteDbl OvOccurences(num.real.BagOfDbl bag)
		{

			var total = bag.cardinality;//.Select(kv=>kv.Value)

			var probs = new Dictionary<double, ProbDbl>();


			bag.Each(
				kv=> probs.Add(
					kv.Key,
					new ProbDbl(
					nilnul.num.quotient.to_._DblX.ByCastNumDen (
						nilnul.num.Quotient1.CreateByDivide ( kv.Value , total )
					)
					)
				)
			);

			return new FiniteDbl(probs);


		}
	}

}