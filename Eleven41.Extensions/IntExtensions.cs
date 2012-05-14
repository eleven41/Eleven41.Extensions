using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.Extensions
{
	public static class IntExtensions
	{
		// Returns the current value, or the next multiple.
		public static int MultipleOf(this int self, int value)
		{
			System.Diagnostics.Debug.Assert(value > 1);
			int mod = self % value;
			if (mod == 0)
				return self;

			return (self + (value - mod));
		}

		// Returns the next multiple.
		public static int NextMultipleOf(this int self, int value)
		{
			System.Diagnostics.Debug.Assert(value > 1);
			int mod = self % value;
			if (mod == 0)
				return self + value;

			return (self + (value - mod));
		}
	}
}
