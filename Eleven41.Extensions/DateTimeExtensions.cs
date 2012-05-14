using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.Extensions
{
	public static class DateTimeExtensions
	{
		// Null-safe version of .ToString(x)
		public static string SafeToString(this DateTime? self, string format)
		{
			if (self == null)
				return null;
			return self.Value.ToString(format);
		}
	}
}
