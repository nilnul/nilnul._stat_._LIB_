
using nilnul.num.real.double_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob.doubleProb.doubleSample.cdf.contains.pert
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

			private NotNull2<nilnul.num.real.double_.NonNegativeX2.NonNegativeDouble> _lambda;

			public NotNull2<nilnul.num.real.double_.NonNegativeX2.NonNegativeDouble> lambda_typed
			{
				get { return (_lambda); }
				set
				{
					//_lambda = nilnul.bit.AssertX.Create<double>(x=>x>=0).ensure(ref value);

					_lambda = value;


				}
			}
			public double lambda_asDouble
			{
				get { return _lambda.val.val; }
				set
				{
					//_lambda = nilnul.bit.AssertX.Create<double>(x=>x>=0).ensure(ref value);

					_lambda =new NotNull2<NonNegativeX2.NonNegativeDouble>(new NonNegativeX2.NonNegativeDouble(  value));


				}
			}



			public MinModMax_Lambda__Struct(MinModMax_Struct pert, NotNull2<nilnul.num.real.double_.NonNegativeX2.NonNegativeDouble> lambda )
			{
				this._lambda = lambda;

				this._pert = pert;

			}


			public MinModMax_Lambda__Struct(double min,double mod,double max,double lambda=4)
				:this(new MinModMax_Struct(min,mod,max),new NonNegativeX2.NonNegativeDouble(lambda))
			{

			}
					



		}

	}

