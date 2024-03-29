﻿using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_
{

	/// <summary>
	/// the sample|domain is double; all other points is measured nil and this is still a borel distribution, but may be this is better suited to be processed as <see cref="stat.dist_.IFinite"/>; or placed here to save the typePar;
	/// </summary>
	public class Finite4dbl : Finite4dbl<double>
	{
		public Finite4dbl(Dictionary<double, ProbDbl> dict) : base(dict)
		{
		}
		public Finite4dbl(Dictionary<double, double> dict) : base(dict)
		{
		}

		static public Finite4dbl OfOccurences( Dictionary<double, int> bag) {
			return new Finite4dbl(
				dist_.Finite4dbl<double>._AsDict_0freq(bag)
			);
		}
		[Obsolete(nameof(OfOccurences))]
		static public Finite4dbl OvOccurences( Dictionary<double, int> bag) {
			return new Finite4dbl(
				dist_.Finite4dbl<double>._AsDict_0freq(bag)
			);
		}

		static public Finite4dbl OfSurvey(IEnumerable<double> bag)
		{
			return new Finite4dbl(
				Finite4dbl<double>.AsDict_ofSamples(bag)
			);
		}

		static public Finite4dbl OfOccurences(num.real.BagOfDbl bag)
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

			return new Finite4dbl(probs);


		}

		[Obsolete(nameof(OfOccurences))]
		static public Finite4dbl OvOccurences(num.real.BagOfDbl bag)
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

			return new Finite4dbl(probs);


		}


		static public Finite4dbl OfSamples( IEnumerable<double> els) {
			//var bag1 = new nilnul.obj.bag_.EqDefault<double, nilnul.num.real.EqDbl>();

			var bag11 = new nilnul.num.real.BagOfDbl(
				els
			);

			return OfOccurences(bag11);


		}

		[Obsolete(nameof(OfSamples))]
		static public Finite4dbl OvOccurences( IEnumerable<double> els) {
			//var bag1 = new nilnul.obj.bag_.EqDefault<double, nilnul.num.real.EqDbl>();

			var bag11 = new nilnul.num.real.BagOfDbl(
				els
			);

			return OvOccurences(bag11);


		}

	}

}