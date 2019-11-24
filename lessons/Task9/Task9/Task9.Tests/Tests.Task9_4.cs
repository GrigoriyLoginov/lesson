using NUnit.Framework;
using System.Collections.Generic;
using Task9_4;

namespace Task9.Tests
{
    class TestsTask9_4
    {
        [TestCase("AAAABBBCCDAABBB", ExpectedResult = "ABCDAB")]
        [TestCase("ABBCcAD", ExpectedResult = "ABCcAD")]
        [TestCase("12233", ExpectedResult = "123")]
        public List<char> TestUnique(string obj)
        {
            List<char> result = Unique.UniqueInOrder(obj);
            return result;
        }
        [Test]
        public void TestDoubleUnique()
        {
            List<double> input = new List<double> { 1.1, 2.2, 2.2, 3.3 };
            List<double> expected = new List<double> { 1.1, 2.2, 3.3 };
            List<double> actual = Unique.UniqueInOrder(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
