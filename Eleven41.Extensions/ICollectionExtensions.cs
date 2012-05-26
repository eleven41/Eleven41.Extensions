using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eleven41.Extensions
{
	public static class ICollectionExtensions
	{
		public static ICollection<T> Add2<T>(this ICollection<T> self, T value)
		{
			self.Add(value);
			return self;
		}

		public static ICollection<T> CondAdd<T>(this ICollection<T> self, Predicate<T> pred, T value)
		{
			if (pred(value))
				self.Add(value);
			return self;
		}

		public static ICollection<T> CondAdd<T>(this ICollection<T> self, bool isAdd, T value)
		{
			if (isAdd)
				self.Add(value);
			return self;
		}
	}
}
