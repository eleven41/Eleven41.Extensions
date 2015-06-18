using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.StringTests
{
	[TestClass]
	public class RemoveLeadingTests
	{
		[TestMethod]
		public void null_A()
		{
			// Setup
			string source = null;

			// Execute
			string result = source.RemoveLeading("A");

			// Check results
			Assert.IsNull(result);
		}

		[TestMethod]
		public void empty_A()
		{
			// Setup
			string source = "";

			// Execute
			string result = source.RemoveLeading("A");

			// Check results
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void A_empty()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveLeading("");

			// Check results
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void A_null()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveLeading(null);

			// Check results
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void A_A()
		{
			// Setup
			string source = "A";

			// Execute
			string result = source.RemoveLeading("A");

			// Check results
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void ABC_A()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveLeading("A");

			// Check results
			Assert.AreEqual("BC", result);
		}

		[TestMethod]
		public void ABC_a()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveLeading("a");

			// Check results
			Assert.AreEqual("ABC", result);
		}

		[TestMethod]
		public void ABC_D()
		{
			// Setup
			string source = "ABC";

			// Execute
			string result = source.RemoveLeading("D");

			// Check results
			Assert.AreEqual("ABC", result);
		}
	}
}
