using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.IEnumerableTests
{
    [TestClass]
    public class SafeSequenceEqual_Tests
    {
        [TestMethod]
        public void null_to_null()
        {
            // Setup
            IEnumerable<int> source = null;
            IEnumerable<int> other = null;

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void null_to_empty()
        {
            // Setup
            IEnumerable<int> source = null;
            IEnumerable<int> other = new List<int>();

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void empty_to_null()
        {
            // Setup
            IEnumerable<int> source = new List<int>();
            IEnumerable<int> other = null;

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void empty_to_empty()
        {
            // Setup
            IEnumerable<int> source = new List<int>();
            IEnumerable<int> other = new List<int>();

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void empty_to_non_empty()
        {
            // Setup
            IEnumerable<int> source = new List<int>();
            IEnumerable<int> other = new List<int>() { 1 };

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void non_empty_to_non_empty_same()
        {
            // Setup
            IEnumerable<int> source = new List<int>() { 1 };
            IEnumerable<int> other = new List<int>() { 1 };

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void non_empty_to_non_empty_different_values()
        {
            // Setup
            IEnumerable<int> source = new List<int>() { 1 };
            IEnumerable<int> other = new List<int>() { 2 };

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void non_empty_to_non_empty_different_lengths()
        {
            // Setup
            IEnumerable<int> source = new List<int>() { 1 };
            IEnumerable<int> other = new List<int>() { 1, 1 };

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void non_empty_to_non_empty_different_order()
        {
            // Setup
            IEnumerable<int> source = new List<int>() { 1, 2 };
            IEnumerable<int> other = new List<int>() { 2, 1 };

            // Execute
            var result = source.SafeSequenceEqual(other);

            // Check result
            Assert.IsFalse(result);
        }
    }
}
