using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.Extensions
{
	public static class StringExtensions
	{
		// Null-safe version of .Trim()
		public static string SafeTrim(this string s)
		{
			if (s == null)
				return s;
			return s.Trim();
		}

		// Ensures the string is non-null.
		public static string EnsureNotNull(this string self)
		{
			if (self == null)
				return "";
			return self;
		}
	}
}
