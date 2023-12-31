using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_.bivar_.borel_.normal._density
{
	/// <summary>
	/// imagine
	///		f(p) =f(r) where p is the point, r is the radius from origin
	///	 and x,y is independent, that is giving x doesnot give any info about y;
	///	 that is f2(x,y) =g(x).h(y)
	///		=g(x) *g(y)   # we assume that the distribution is symmetric;
	///	that is f(r) = g(x)*g(y);
	///	
	///	 when y=0, r=x
	///		so
	///		f(x) = g(x)*g(0)
	///			let's assume g(0) =1 # we can rescale later.
	///	so, f(x) = g(x)
	///	so, f(r)=f(x)*f(y)
	///	so, f( sqrt(x^2+y^2) ) =f(x) * f(y)
	///	let h1(x)=f(sqrt(x))
	///	then h1(x^2) =f(x)
	///	 then h1(x^2+y^2) = h1(x^2) * h1(y^2)
	///	 then h1( x+x+x+...) = h(x)^n
	///	 h(n) = b^n
	///	 h(p/q+...) = h(p/q) ^n
	///	 as the function is continuouse, the h must be c^x=e^cx
	///	 so f(x) =e^c(x^2)
	///		
	/// </summary>
	internal class Deduce
	{
	}
}
