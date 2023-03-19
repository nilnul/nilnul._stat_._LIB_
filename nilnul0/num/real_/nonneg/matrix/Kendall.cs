using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.stat
{
	/// <summary>
	/// a group of judges, each of which scores each contester;
	/// We then get a matrix of scores;
	/// Now we will check whether the score is consistent to some extent;
	/// </summary>
	public class Kendall
	{
		public class Ranks
		{

			private Ranks(double[,] ranks)
			{
				this._ranks = ranks;

			}
			private double[,] _ranks;

			public double[,] ranks
			{
				get { return _ranks; }
				set { _ranks = value; }
			}
			public int judgesCount
			{
				get
				{
					return _ranks.GetLength(0);
				}
			}
			public int subjectsCount
			{
				get
				{
					return _ranks.GetLength(1);
				}
			}

			public double getRank(int judge, int subject)
			{
				return _ranks[judge, subject];
			}


			public double getSubjectRankSumOfAllJudges(int subject)
			{
				double r = 0;
				for (int i = 0; i < judgesCount; i++)
				{
					r += getRank(i, subject);

				}
				return r;
			}

			public double getAvgSubjectRankSumOfAllJudges()
			{
				return (double)judgesCount * (subjectsCount + 1.0) / 2.0;
			}

			public double getSumOfSquaredDev()
			{
				double r = 0;
				var avg_RankSumOfJudges_bySubject = getAvgSubjectRankSumOfAllJudges();

				for (int i = 0; i < subjectsCount; i++)
				{
					r += nilnul.num.real.double_.SquareX.Square((getSubjectRankSumOfAllJudges(i) - avg_RankSumOfJudges_bySubject));
				}
				return r;
			}

			public double getMaxSumOfSquareDev()
			{

				return nilnul.num.real.double_.SquareX.Square(judgesCount) * subjectsCount * (subjectsCount + 1) * (subjectsCount - 1) /12;
			}

			public double getW()
			{

				return getSumOfSquaredDev() / getMaxSumOfSquareDev();


			}



			static public Ranks CreateFromScores(double[,] scores)
			{
				var subjectsCount = scores.GetLength(1);
				var judgesCount = scores.GetLength(0);
				var ranks = new double[judgesCount, subjectsCount];

				for (int judge = 0; judge < judgesCount; judge++)
				{
					var orderedScoreWeight = new SortedDictionary<double, int>();
					for (int subject = 0; subject < subjectsCount; subject++)
					{
						var score = scores[judge, subject];
						if (orderedScoreWeight.ContainsKey(score))
						{
							orderedScoreWeight[score]++;

						}
						else
						{
							orderedScoreWeight.Add(score, 1);
						}

					}
					var scoreRanks=_GetRank(orderedScoreWeight);
					

					for (int subject = 0; subject < subjectsCount; subject++)
					{

				

						ranks[judge, subject] = scoreRanks[scores[judge,subject]];

					}




				}


				return new Ranks(ranks);



			}


			static public Dictionary<double,double> _GetRank(SortedDictionary<double,int> order) {

				var r2 = new Dictionary<double, double>();

				var rankBase = 0;
				int rankUpper;
				
				for (int i = 0; i < order.Count; i++)
				{
					 rankUpper=	rankBase +order.ElementAt(i).Value;

					r2.Add(
						order.ElementAt(i).Key
						, 
						(rankBase+1+rankUpper)
							/
						2.0
					);

					rankBase = rankUpper;

				
				}
				return r2;

				//throw new Exception();


			
			}


			public class Rank
			{
				private double[,] _scores;

				public double[,] scores
				{
					get { return _scores; }
					set { _scores = value; }
				}

				private double[,] _ranks;

				public double[,] ranks
				{
					get { return _ranks; }
					set { _ranks = value; }
				}

				public void set(double[,] scores) { }



			}




		}
		static public double GetW(double[,] scores)
		{

			return Ranks.CreateFromScores(scores).getW();

		}



	}
}
