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

		/// <summary>
		/// Returns a new string in which all occurences of a specified string
		/// in the source string are replaced with another string returned by calling newStringFunc.
		/// </summary>
		/// <param name="self">Source string to scan for replacements.</param>
		/// <param name="oldString">Old string to replace.</param>
		/// <param name="newStringFunc">Function to call for each occurence. 
		/// The single integer parameter is a zero-based count of the oldString occurence.
		/// </param>
		/// <returns>A string that is equivalent to the source string except that all occurences of oldString have been replaced.</returns>
		/// <remarks>If the result from myStringFunc contains oldString, 
		/// those occurences will not be replaced.
		/// </remarks>
		public static string Replace(this string self, string oldString, Func<int, string> newStringFunc)
		{
			if (newStringFunc == null)
				throw new ArgumentNullException("newStringFunc", "newStringFunc must not be null");

			// Shortcuts for empty strings
			if (String.IsNullOrEmpty(self))
				return self;
			if (String.IsNullOrEmpty(oldString))
				return self;

			// Keep looping until all occurences have been replaced
			int i = 0;
			int oldStringLength = oldString.Length;
			int startIndex = 0;
			for (int index = self.IndexOf(oldString, startIndex); index >= 0; index = self.IndexOf(oldString, startIndex))
			{
				string before = self.Substring(0, index);
				string after = self.Substring(index + oldStringLength);

				string replacement = newStringFunc(i++);
				if (replacement == null)
					replacement = "";

				// Replace the source string for the next loop iteration
				self = before + replacement + after;

				// Move the start index to just after the replacement string to avoid
				// an infinite loop
				startIndex = index + replacement.Length;
			}
			return self;
		}
	}
}
