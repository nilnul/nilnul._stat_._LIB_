namespace nilnul.stat.dist_.borel_.normal.sample_
{
	static public class _ProbitX
	{
		static public double _Probit_0prob(double p) {

			return borel_.pdfable_.normal_._StdX.Invert(p);

			//return nilnul.num.real_.eg_.sqrt_._OfTwoX.DBL *
			//	erfInvert	///erf invert
			//	(2 * p - 1);

		}




	}
}
