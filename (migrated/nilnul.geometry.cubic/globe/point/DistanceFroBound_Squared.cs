using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.geometry.cubic.globe.point
{

	public class DistanceFroBound_Squared
	{
		/// <summary>
		/// Re: 一道题目(球内一点与球面一点的距离的期望)
		///发信站: 水木社区(Sat Mar 18 16:20:57 2017), 站内
		///与pi无关真是奇怪。能解一下距离平方的期望吗？难道8/5？
		///【 在 dragonheart6 的大作中提到: 】
		///: 根据xxp的思路，利用对称性，轻易解决3维问题。
		///: 二维是32/(9* pi), 三维是6/5. [upload=1]
		/// </summary>

		public R expectation4UnitGlobe()
		{
			return new nilnul.num.real_.Quotient(8, 5);
		}
	}
}
