﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._prob.rnd
{
	/// <summary>
	/// generate a new rnd
	/// lest they have the same seed if generated by new()
	/// </summary>
	public class Generator
	{
		private int _seed=unchecked((int)DateTime.UtcNow.Ticks);
		public Rnd generate() {
			_seed++;	//no need to use the Random().next(); in fact just using plain "++" is better in that: using Random().Next() will make subsequent Rnd look dependent to the dehead previous one; or Not in that seed will be converted in a hash-similar ways thus subsequent would start from not the specified index 1, but a later index?
			return new Rnd(_seed);

		}
	}
}
