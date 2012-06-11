using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.Extensions
{
	public static class ArrayExtensions
	{
		// Populates an entire array with the specified value.
		public static void Populate<T>(this T[] arr, T value)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = value;
			}
		}

		// Copies a range of items from this array to a target array.
		public static void CopyRangeTo<T>(this T[] self, int startIndex, int numItemsToCopy, T[] target)
		{
			if (startIndex > self.Length)
				throw new ArgumentOutOfRangeException("startIndex");
			if (numItemsToCopy < 0)
				throw new ArgumentOutOfRangeException("numItemsToCopy");
			if (numItemsToCopy > target.Length)
				throw new ArgumentOutOfRangeException("numItemsToCopy");
			if (numItemsToCopy > self.Length - startIndex)
				throw new ArgumentOutOfRangeException("numItemsToCopy");

			for (int i = 0; i < numItemsToCopy; ++i)
			{
				target[i] = self[startIndex + i];
			}
		}

		// Copies a range of items from this array to a target array.
		public static void CopyRangeTo<T>(this T[] self, int startIndex, int numItemsToCopy, T[] target, int targetStartIndex)
		{
			if (startIndex > self.Length)
				throw new ArgumentOutOfRangeException("startIndex");
			if (numItemsToCopy < 0)
				throw new ArgumentOutOfRangeException("numItemsToCopy");
			if (numItemsToCopy > target.Length - targetStartIndex)
				throw new ArgumentOutOfRangeException("numItemsToCopy");
			if (numItemsToCopy > self.Length - startIndex)
				throw new ArgumentOutOfRangeException("numItemsToCopy");

			for (int i = 0; i < numItemsToCopy; ++i)
			{
				target[targetStartIndex + i] = self[startIndex + i];
			}
		}

		public static T[] SubArray<T>(this T[] self, int startIndex)
		{
			if (startIndex > self.Length)
				throw new ArgumentOutOfRangeException("startIndex");

			int numItems = self.Length - startIndex;
			T[] results = new T[numItems];
			self.CopyRangeTo(startIndex, numItems, results);
			return results;
		}

		public static T[] SubArray<T>(this T[] self, int startIndex, int numItems)
		{
			if (startIndex > self.Length)
				throw new ArgumentOutOfRangeException("startIndex");
			if (numItems > self.Length - startIndex)
				throw new ArgumentOutOfRangeException("numItems");

			T[] results = new T[numItems];
			self.CopyRangeTo(startIndex, numItems, results);
			return results;
		}

		// Create a single-element array from the object.
		public static T[] ArrayFromSingle<T>(this T self)
		{
			if (self == null)
				return null;

			T[] results = new T[1];
			results[0] = self;
			return results;
		}
	}
}
