using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.stat.dist_._borel_
{
	/// <summary>
	/// even for <see cref="borel_.IDiscrete"/>, this will work, as for each single point, we just use the <see cref="nilnul.num.real.bound_.closed_.ISingle"/>
	/// </summary>
	/// <typeparam name="TInterval">
	/// for borel, it's not enough if we only specifify the prob of basicEvent or sample; (often it's nil);
	/// according to borel, we need to speficify prob for each interval(open or close, bounded or not);
	/// Note the typePar here means interval the event, whileas in <see cref="_dist_.Prob4dblI{TEvent}"/>, the typePar means event;
	/// </typeparam>
	public interface Prob4dblI<TInterval>
		:
		_dist_.Prob4dblI<TInterval>
		//where TInterval: nilnul.num.real.ext.IBound

	{
	}



}
