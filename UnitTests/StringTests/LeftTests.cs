using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.StringTests
{
	[TestClass]
	public class LeftTests
	{
		[TestMethod]
		public void null_0()
		{
			string s = null;
			string result = s.Left(0);
			Assert.IsNull(result);
		}

		[TestMethod]
		public void null_1()
		{
			string s = null;
			string result = s.Left(1);
			Assert.IsNull(result);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void null_negative_1()
		{
			string s = null;
			string result = s.Left(-1);
		}

		[TestMethod]
		public void empty_0()
		{
			string s = "";
			string result = s.Left(0);
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void empty_1()
		{
			string s = "";
			string result = s.Left(1);
			Assert.AreEqual("", result);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void empty_negative_1()
		{
			string s = "";
			string result = s.Left(-1);
		}

		[TestMethod]
		public void A_1()
		{
			string s = "A";
			string result = s.Left(1);
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void A_0()
		{
			string s = "A";
			string result = s.Left(0);
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void A_2()
		{
			string s = "A";
			string result = s.Left(2);
			Assert.AreEqual("A", result);
		}

		[TestMethod]
		public void ABC_3()
		{
			string s = "ABC";
			string result = s.Left(3);
			Assert.AreEqual("ABC", result);
		}

		[TestMethod]
		public void ABC_2()
		{
			string s = "ABC";
			string result = s.Left(2);
			Assert.AreEqual("AB", result);
		}

		[TestMethod]
		public void ABC_4()
		{
			string s = "ABC";
			string result = s.Left(4);
			Assert.AreEqual("ABC", result);
		}
	}
}
