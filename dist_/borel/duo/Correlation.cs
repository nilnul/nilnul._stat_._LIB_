using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob_.borel
{
	/// <summary>
	/// linear correlation.
	/// 
	/// 怎么理解概率中的相关性和独立性啊
	/// 发信站: 水木社区(Fri May 12 22:33:35 2017), 站内
	/// a = X - EX
	/// b=Y-EY
	/// DX = sqrt(E | a |^ 2)
	/// DY=sqrt(E|b|^2)
	/// DX和DY可以看成a和b在L^2中的范数，不好理解就当是a和b的模长
	/// cov（X,Y）=E(ab）是a和b在L^2中的内积，不好理解就当是普通的内积（数积）
	///也就是说
	/// rho = cov(X, Y) /[DXDY] = a与b的内积 / a与b的模长之积
	/// 实际上是a与b的“夹角”的余弦
	/// |rho|=1，a，b共线，当然就线性相关【两向量共线就是线性相关了】
	/// rho= 0，当然是最不相关，此时a，b正交
	/// </summary>
	public interface CorrelationI
	{
	}

	
}
