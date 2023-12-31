using nilnul.num.rational;
using nilnul.obj.str;
using nilnul.stat._dist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat.dist_.finite_.cmf.of_
{
	static public  class _PmfX
	{

		static public SortedDictionary<double, double> CmfAsDict4dbl(
			nilnul.stat.dist_.Finite4dbl finiateDbl
		) {
			var r = new SortedDictionary<double, double>();
			var totalProb = 0d;
			foreach (var item in finiateDbl.OrderBy(kv=>kv.Key))
			{
				totalProb += item.Value;
				r.Add(item.Key,( totalProb) );
			}
			return r;
		}

		static public SortedDictionary<double, double> CmfAsDict4dbl(
			Dictionary<double,double> finiateDbl
		) {
			var r = new SortedDictionary<double, double>();
			var totalProb = 0d;
			foreach (var item in finiateDbl.OrderBy(kv=>kv.Key))
			{
				totalProb += item.Value;
				r.Add(item.Key,( totalProb) );
			}
			return r;
		}

		static public SortedDictionary<TSample, double> CmfAsDict2dbl<TSample>(
			SortedDictionary<TSample,double> finiateDbl
		) {
			var r = new SortedDictionary<TSample, double>( finiateDbl.Comparer);
			var totalProb = 0d;
			foreach (var item in finiateDbl)
			{
				totalProb += item.Value;
				r.Add(item.Key,( totalProb) );
			}
			return r;
		}


		static public SortedDictionary<double, Prob4dbl> CmfAsDict2prob(
			nilnul.stat.dist_.Finite4dbl finiateDbl
		) {
			var r = new SortedDictionary<double, Prob4dbl>();
			var totalProb = 0d;
			foreach (var item in finiateDbl.OrderBy(kv=>kv.Key))
			{
				totalProb += item.Value;
				r.Add(item.Key,new Prob4dbl( totalProb) );
			}

			return r;
		}

		/// <summary>
		/// from pmf to cmf;
		/// </summary>
		/// <param name="finiateDbl"></param>
		/// <returns></returns>
		static public SortedDictionary<double, ProbDbl> CmfAsDict2ProbDbl(
			nilnul.stat.dist_.Finite4dbl finiateDbl
		) {
			var r = new SortedDictionary<double, ProbDbl>();
			var totalProb = 0d;
			foreach (var item in finiateDbl.OrderBy(kv=>kv.Key))
			{
				totalProb += item.Value;

				r.Add(item.Key,new ProbDbl( totalProb) );

			}

			return r;
		}

	

	}



}
