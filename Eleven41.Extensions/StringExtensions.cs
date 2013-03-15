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

		public static string Upto(this string self, char c)
		{
			int index = self.IndexOf(c);
			if (index < 0)
				return "";
			return self.Substring(0, index);
		}

		public static string UptoAndIncluding(this string self, char c)
		{
			int index = self.IndexOf(c);
			if (index < 0)
				return "";
			return self.Substring(0, index + 1);
		}

		public static string After(this string self, char c)
		{
			int index = self.IndexOf(c);
			if (index < 0)
				return "";
			return self.Substring(index + 1);
		}

		// Returns the left characters from the string.
		public static string Left(this string self, int count)
		{
			if (count < 0)
				throw new ArgumentException("count must not be less than 0", "count");
			if (self == null)
				return null;
			if (count == 0)
				return "";
			if (self.Length <= count)
				return self;
			return self.Substring(0, count);
		}

		// Returns the right characters from the string.
		public static string Right(this string self, int count)
		{
			if (count < 0)
				throw new ArgumentException("count must not be less than 0", "count");
			if (self == null)
				return null;
			if (count == 0)
				return "";
			if (self.Length <= count)
				return self;
			return self.Substring(self.Length - count, count);
		}
	}
}
