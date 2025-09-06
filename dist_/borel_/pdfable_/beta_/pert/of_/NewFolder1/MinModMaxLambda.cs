using nilnul.num.rational;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.rational.Rational_InheritFraction;


namespace nilnul.prob.rationalProb.rationalSample.cdf.contains.pert
{

	


		///

		/// <summary>
		/// 
		/// The PERT distribution is used exclusively for modeling expert estimates, where one is given the expert's minimum, most likely and maximum guesses. It is a direct alternative to a Triangle distribution, so a discussion is warranted on comparing the two:
		/// 
		/// 
		/// 
		/// 
		/// </summary>
		/// <remarks>
		/// The implementation is according to http://reference.wolfram.com/mathematica/ref/PERTDistribution.html
		/// </remarks>
		public partial struct MinModMax_Lambda__Struct
		{

			private MinModMax_Struct _pert;



			public MinModMax_Struct pert
			{
				get { return _pert; }
				set { _pert = value; }
			}

			private NotNull2<nilnul.num.rational.NonNegX.NonNegRational> _lambda;

			public NotNull2<nilnul.num.rational.NonNegX.NonNegRational> lambda
			{
				get { return (_lambda); }
				set
				{
					//_lambda = nilnul.bit.AssertX.Create<double>(x=>x>=0).ensure(ref value);

					_lambda = value;


				}
			}
			public R lambda_asRational
			{
				get { return _lambda.val.val; }
				set
				{
					//_lambda = nilnul.bit.AssertX.Create<double>(x=>x>=0).ensure(ref value);

					_lambda =new NotNull2<nilnul.num.rational.NonNegX.NonNegRational>(new nilnul.num.rational.NonNegX.NonNegRational(  value));


				}
			}



			public MinModMax_Lambda__Struct(MinModMax_Struct pert, NotNull2<nilnul.num.rational.NonNegX.NonNegRational> lambda )
			{
				this._lambda = lambda;

				this._pert = pert;

			}


			public MinModMax_Lambda__Struct(R min,R mod,R max,R lambda)
				:this(new MinModMax_Struct(min,mod,max),new NonNegX.NonNegRational(lambda))
			{

			}

			public MinModMax_Lambda__Struct(R min, R mod, R max)
				: this(new MinModMax_Struct(min, mod, max), new NonNegX.NonNegRational(4))
			{

			}
					



		}

	}

