using nilnul.num.real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.func_.unary_._erf

{
	public class Integrand4dbl
		:
		nilnul.num.real.ext.of_.Unary4dblA 
	{
		static public double TwoOverSqrtPi = 2 / Math.Sqrt(Math.PI); ///todo: use static calcued
		/// <summary>
		///  exp(-t^2); 
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public  double _op_0ext(double par)
		{

			return TwoOverSqrtPi
				/ Math.Exp( par*par);
		}

		public override double op4dbl(Ext4dblI par)
		{
			return _op_0ext(par.errable);
		}

		static public Integrand4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Integrand4dbl>.Instance;
			}
		}

	}
}
