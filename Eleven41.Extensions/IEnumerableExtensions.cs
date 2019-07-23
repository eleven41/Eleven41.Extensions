using System;
using System.Collections.Generic;
using System.Linq;

namespace Eleven41.Extensions
{
	public static class IEnumerableExtensions
	{
		public static IEnumerable<T> EnsureNotNull<T>(this IEnumerable<T> self)
		{
			if (self == null)
				return new T[0]; // Empty array is IEnumerable
			return self;
		}

        /// <summary>
        /// Determines whether two sequences are equal by comparing the elements by using the default equality comparer for their type.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the input sequences.</typeparam>
        /// <param name="self">An IEnumerable<T> to compare to other. Can be null.</param>
        /// <param name="other">An IEnumerable<T> to compare to the first sequence. Can be null.</param>
        /// <returns>true if the two source sequences are both null or of equal length and their corresponding elements are equal according to the default equality comparer for their type; otherwise, false.</returns>
        public static bool SafeSequenceEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
        {
            if (self == null && other == null)
                return true;
            if (self == null)
                return false;
            if (other == null)
                return false;
            return self.SequenceEqual(other);
        }
    }
}
