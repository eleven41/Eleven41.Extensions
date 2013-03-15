using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleven41.Extensions;

namespace Tests
{
	public static class StringTests
	{
		public static void Test()
		{
			Left1();
			Left2();
			Left3();
			Left4();
			Left5();
			Left6();
			Left7();
			Left8();
			Left9();
			Left10();
			Left11();
			Left12();
		}

		static void Left1()
		{
			string s = null;
			string result = s.Left(0);
			System.Diagnostics.Debug.Assert(result == null);
		}

		static void Left2()
		{
			string s = null;
			string result = s.Left(1);
			System.Diagnostics.Debug.Assert(result == null);
		}

		static void Left3()
		{
			try
			{
				string s = null;
				string result = s.Left(-1);
				System.Diagnostics.Debug.Fail("String.Left should have failed.");
			}
			catch (ArgumentException)
			{
				// Pass
			}
			catch
			{
				System.Diagnostics.Debug.Fail("Wrong exception was thrown.");
			}
		}

		static void Left4()
		{
			string s = "";
			string result = s.Left(0);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result.Length == 0);
		}

		static void Left5()
		{
			string s = "";
			string result = s.Left(1);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result.Length == 0);
		}

		static void Left6()
		{
			try
			{
				string s = "";
				string result = s.Left(-1);
				System.Diagnostics.Debug.Fail("String.Left should have failed.");
			}
			catch (ArgumentException)
			{
				// Pass
			}
			catch
			{
				System.Diagnostics.Debug.Fail("Wrong exception was thrown.");
			}
		}

		static void Left7()
		{
			string s = "A";
			string result = s.Left(1);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result == "A");
		}

		static void Left8()
		{
			string s = "A";
			string result = s.Left(0);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result.Length == 0);
		}

		static void Left9()
		{
			string s = "A";
			string result = s.Left(2);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result == "A");
		}

		static void Left10()
		{
			string s = "ABC";
			string result = s.Left(3);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result == "ABC");
		}

		static void Left11()
		{
			string s = "ABC";
			string result = s.Left(2);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result == "AB");
		}

		static void Left12()
		{
			string s = "ABC";
			string result = s.Left(4);
			System.Diagnostics.Debug.Assert(result != null);
			System.Diagnostics.Debug.Assert(result == "ABC");
		}
	}
}
