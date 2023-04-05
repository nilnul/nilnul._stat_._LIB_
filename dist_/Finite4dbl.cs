using nilnul.obj.str;
using nilnul.stat._dist_;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_
{
	/// <summary>
	/// a prob on finite set such that we can measure the elements in the set. the prob|range is double;
	/// </summary>
	public class Finite4dbl<TSample>
		: Dictionary<TSample, ProbDbl>
		,
		Finite4dblI<TSample>

	{

		public Finite4dbl(Dictionary<TSample, ProbDbl> dict)
			: base(dict)
		{
			nilnul.stat.prob.str.be_.totalOne._VowX.Vow(this.Values);
		}


		public double pmf(TSample sample)
		{

			throw new System.NotImplementedException();
		}

		public TSample sample(double cmf)
		{
			double rand = cmf;
			double cumulativeProb = 0;

			var evts = this.ToArray();

			for (int i = 0; i < this.Count-1 ; i++)
			{
				if (
					rand <this.ElementAt(i).Value._val
				)
				{
					return this.ElementAt(i).Key;

				}
				cumulativeProb +=this.ElementAt(i).Value._val ;

			}
			return this.Last().Key;


		}
		public TSample sample()
		{
			return sample(
				nilnul.stat.dist_.borel_.pdf_.uniform_._Preportion4dblX.Sample()
			);
		


		}
		static public Finite4dbl<TSample> Create(IEqualityComparer<TSample> eq, IEnumerable<KeyValuePair<TSample, ProbDbl>> enumerable)
		{
			var r = new
			 Dictionary<TSample, ProbDbl>(eq);
			nilnul.obj.DictX.AddRange(
				r,
				enumerable
			);
			return new Finite4dbl<TSample>(r);
		}


		static public Finite4dbl<TSample> OfSamples(IEnumerable<TSample> samples) {

			var dict = new Dictionary<TSample, ProbDbl>();

			var totalCount = samples.Count();

			samples.GroupBy(x => x).ForEach(
				item=>
				dict.Add(item.Key, new ProbDbl( (double)item.Count() / totalCount) )
			);

			return new Finite4dbl<TSample>(dict);


		}

		static public Dictionary<TSample, ProbDbl> _AsDict_0freq( Dictionary<TSample, int> bag) {


			var total = bag.Values.Cast<int>().Sum();//.Select(kv=>kv.Value)

			var probs = new Dictionary<TSample, ProbDbl>();

			double totalDbl = total;

			bag.Each(
				kv=> probs.Add(kv.Key, new ProbDbl( kv.Value / totalDbl ) )
			);

			return probs;

		}

		static public Finite4dbl<TSample> OfOccurences( Dictionary<TSample, int> bag) {



			return new Finite4dbl<TSample>(_AsDict_0freq(bag));
		}

		
	}

}