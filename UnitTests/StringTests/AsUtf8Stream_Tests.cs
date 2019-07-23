using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eleven41.Extensions;

namespace UnitTests.StringTests
{
    [TestClass]
    public class AsUtf8Stream_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void null_string()
        {
            // Setup
            string s = null;

            // Execute
            var result = s.AsUtf8Stream();
        }

        [TestMethod]
        public void empty_string()
        {
            // Setup
            string s = "";

            // Execute
            var result = s.AsUtf8Stream();

            // Check results
            Assert.IsNotNull(result);

            using (var reader = new System.IO.StreamReader(result, System.Text.Encoding.UTF8))
            {
                Assert.AreEqual("", reader.ReadToEnd());
            }
        }


        [TestMethod]
        public void guid_to_string()
        {
            // Setup
            string s = Guid.NewGuid().ToString();

            // Execute
            var result = s.AsUtf8Stream();

            // Check results
            Assert.IsNotNull(result);

            using (var reader = new System.IO.StreamReader(result, System.Text.Encoding.UTF8))
            {
                Assert.AreEqual(s, reader.ReadToEnd());
            }
        }
    }
}
