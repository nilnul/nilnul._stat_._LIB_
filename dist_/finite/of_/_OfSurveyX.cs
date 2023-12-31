using nilnul.obj.str;
using nilnul.rel_.dict;
using nilnul.stat._dist_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.stat.dist_.finite.of_
{
	static public class _OfSurveyX
	{

		static public Dictionary<TSample, ProbDbl> AsDict2prob<TSample>(IEnumerable<TSample> samples) {

			var dict = new Dictionary<TSample, ProbDbl>();

			var totalCount = samples.Count();

			samples.GroupBy(x => x).ForEach(
				item=>
				dict.Add(item.Key, new ProbDbl( (double)item.Count() / totalCount) )
			);

			return dict;
		}

		static public Dictionary<TSample, double> AsDict<TSample>(IEnumerable<TSample> samples) {

			var dict = new Dictionary<TSample, double>();

			var totalCount =(double) samples.Count();

			samples.GroupBy(x => x).ForEach(
				item=>	dict.Add(
					item.Key
					,
					item.Count() / totalCount
				) 
			);

			return dict;
		}
		
	}

}