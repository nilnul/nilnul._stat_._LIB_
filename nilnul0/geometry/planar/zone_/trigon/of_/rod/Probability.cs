using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.geometry.planar.zone_.trigon.of_.rod
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///棍子长为1，三段分别是x，y，1-x-y;
	///三段都是大于0，小于1. 其中：
	///直角坐标系中，所有x，y可能点在（0.0）（0.1）（1.0）构成的直角等腰三角形中，所有可能就是这个面积
	///
	///能构成三角形的x，y点要满足两边和大于第三边，分别
	///		: x is in （0，0.5）
	///		: y is in （0，0.5）
	///		: x+y > 1-x-y, that is , in other words, x+y lt 1/2.
	///		hence: 这些点的范围是（0，0.5）,（0.5，0）（0.5，0.5）的三角形(不含边界)面积；计算发现其 占总面积四分之一
	/// </remarks>
	internal class Probability
	{

	}
}
