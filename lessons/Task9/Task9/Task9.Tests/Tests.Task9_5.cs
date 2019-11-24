using NUnit.Framework;
using System.Collections.Generic;
using Task9_5;

namespace Task9.Tests
{

    class TestsTask9_5
    {
        [Test]
        public void TestDoubleUnique()
        {
            string input = "The greatest victory is that which requires no battle";
            string expected = "battle no requires which that is victory greatest The";
            string actual = Reverse.ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
