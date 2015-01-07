using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.StringTests
{
	[TestClass]
	public class ReplaceTests
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void null_func()
		{
			string s = "";
			string result = s.Replace("a", (Func<int, string>)null);
		}

		[TestMethod]
		public void source_as_null_string()
		{
			string s = null;
			string result = s.Replace("a", i => "b");
			Assert.IsNull(result);
		}

		[TestMethod]
		public void source_as_empty_string()
		{
			string s = "";
			string result = s.Replace("a", i => "b");
			Assert.AreEqual("", result);
		}

		[TestMethod]
		public void old_string_as_empty_string()
		{
			string s = "a";
			string result = s.Replace("", i => "b");
			Assert.AreEqual("a", result);
		}

		[TestMethod]
		public void old_string_not_found()
		{
			string s = "aaa";
			string result = s.Replace("b", i => "c");
			Assert.AreEqual("aaa", result);
		}

		[TestMethod]
		public void replace_at_start()
		{
			string s = "baa";
			string result = s.Replace("b", i => "c");
			Assert.AreEqual("caa", result);
		}

		[TestMethod]
		public void replace_at_end()
		{
			string s = "aab";
			string result = s.Replace("b", i => "c");
			Assert.AreEqual("aac", result);
		}

		[TestMethod]
		public void replace_in_middle()
		{
			string s = "aba";
			string result = s.Replace("b", i => "c");
			Assert.AreEqual("aca", result);
		}

		[TestMethod]
		public void replace_all_same()
		{
			string s = "bbb";
			string result = s.Replace("b", i => "c");
			Assert.AreEqual("ccc", result);
		}

		[TestMethod]
		public void replace_multiple_different()
		{
			string[] replacements = new string[]
			{
				"c", "d", "e", "f"
			};

			string s = "ababa";
			string result = s.Replace("b", i => replacements[i]);
			Assert.AreEqual("acada", result);
		}

		[TestMethod]
		public void replace_with_old_embedded()
		{
			string s = "ababa";
			string result = s.Replace("b", i => "cbc");
			Assert.AreEqual("acbcacbca", result);
		}

		[TestMethod]
		public void replace_with_empty()
		{
			string s = "ababa";
			string result = s.Replace("b", i => "");
			Assert.AreEqual("aaa", result);
		}

		[TestMethod]
		public void replace_with_null()
		{
			string s = "ababa";
			string result = s.Replace("b", i => null);
			Assert.AreEqual("aaa", result);
		}
	}
}
