using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.StringTests
{
	[TestClass]
	public class RemoveTrailingTests
	{
		[TestMethod]
		public void null_A()
		{
			// Setup
			string source = null;

			// Execute
			string result = source.RemoveTrailing("A");

			// Check results
			Assert.IsNull(result);
		}

		[TestMethod]
		public void empty_A()
		{
			// Setup
			string source = "";

			// Execute
			string result = source.RemoveTrailing("A");

			// Check results
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void A_empty()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveTrailing("");

			// Check results
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void A_null()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveTrailing(null);

			// Check results
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void A_A()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveTrailing("A");

			// Check results
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void ABC_C()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveTrailing("C");

			// Check results
			Assert.AreEqual("AB", result);
		}

		[TestMethod]
		public void ABC_c()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveTrailing("c");

			// Check results
			Assert.AreEqual("ABC", result);
		}

		[TestMethod]
		public void ABC_D()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveTrailing("D");

			// Check results
			Assert.AreEqual("ABC", result);
		}
	}
}
