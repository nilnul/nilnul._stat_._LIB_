using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.prob_.borel_.rv.co_
{
	/*
	 发信人: bsxfun (色即是空), 信区: Mathematics
标  题: Re: 请教：如何理解“n个独立均匀分布相加，结果为正态分布”？
发信站: 水木社区 (Mon Sep  4 13:49:29 2017), 站内

比如  X ~ N(0, 1), Y = (2B - 1)*X
其中 B是一个与Y独立的符合Bernoulli分布的随机变量，P(B=0) = P(B=1) = 0.5

可以证明Y也是一个标准正态分布，然而：
X + Y = 2BX
并非正态分布。

此外，@gloop 举的例子不算反例。因为通常可以把常数看成是一个特殊的正态分布（方差为零的情形）。 

		 */
	class NormBernouli
	{

	}
}
