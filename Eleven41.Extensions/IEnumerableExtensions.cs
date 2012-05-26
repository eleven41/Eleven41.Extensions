using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
	}
}
