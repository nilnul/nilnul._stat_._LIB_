using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PosInt=nilnul.math.complex.real.rational.integer.Positive;
using NonnegReal=nilnul.math.complex.real.NonnegativeReal;
using RealSet=nilnul.math.complex.real.set.Set;
using RealSetType = nilnul.math.complex.real.set.Type;
using RealInterval = nilnul.math.complex.real.set.Interval;
using RealInf = nilnul.math.complex.real.Infinite;
using nilnul.math.complex.real.rational.integer.set;
using nilnul.math.complex.real;
using IntInf = nilnul.math.complex.real.rational.integer.IntegerInfinite;
using BetaFunc = nilnul.math.complex.real.function.Beta;
using nilnul.math.statistics.operators;



namespace nilnul.math.statistics.distribution
{
	public class F:DistributionFunction
	{
		public PosInt degree1{
			get;
			set;
		}
		public PosInt degree2{
			get;
			set;
		}

		public F(PosInt degree1,PosInt degree2){
			this.degree1=degree1;
			this.degree2=degree2;
		}

		public NonnegReal density(Real x) {
			return
				degree1.Power(degree1 / 2) 
				* degree2.Power(degree2 / 2)
				* x.Power(degree1 / 2 - 1)
				/
				(degree2 + degree1 * x).Power((degree1 + degree2) / 2)
				/ new BetaFunc(degree1, degree2);
		}
		public Real uppperDividePoint(NonnegativeReal a) {
			return new UpperDividePoint(this,a);

		}

		public Real mean {
			get {
				if (degree2 > 2)
				{
					return degree2 / (degree2 - 2);///?????
				}
				else return null;
				
			}
		}

		public Real variance {
			get {
				return null;////??????
			}
		}



		static public RealSet Domain {
			get {

				return new RealInterval(0, RealInf.Positive, RealInterval.Type.Open);
				

			}
		}

		static public Set Degree1Domain {
			get {
				return new Interval(1, IntInf.Positive, Interval.Type.leftClosedRightOpen);
			}
		}
		static public Set Degree2Domain {
			get {
				return Degree1Domain;
			}
		}

		public class UpperDividePoint:Real {
			public DistributionFunction d
			{
				get;
				set;
			}
			public NonnegativeReal a { }
			public UpperDividePoint(DistributionFunction d,NonnegativeReal a) {
				this.d = d;
				this.a = a;
			}

			static public Real Equals(Real u){

				if(u is UpperDividePoint){
					UpperDividePoint udpU=(UpperDividePoint)u;

					if(udpU.d is F){
						F fd=((F)(udpU.d));


						return new UpperDividePoint(
							new F(
								fd.degree2,
								fd.degree1
							)
							,
							1 - udpU.a
						);
					}

				}
				return null;
			
			}

		}

	}//class


	static public class F_Extension {
		static public F Distribution(this RandomVariable a) { 
			if(a is Divide){

				if(((Divide)a).right is F){
					return new F(

							((F)(
									((Divide)a).right
							)).degree2
							,
							(
								(F)(
									((Divide)a).right
								)
							).degree1
					);

				}
			}
			return null;
		}
	}//class


}
