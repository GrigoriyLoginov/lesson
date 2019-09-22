using NUnit.Framework;
using DoubleIEEE754;
using ClassNulable;
using Find;
using System;
namespace TestsTask6
{
    public class DoubleIEEE754Tests
    {
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        public string TestsDoules(double num)
        {
            return DoubleToIEEE754.ToIEEE754(num);
        }
    }

    public class FindNODTest
    {
        [TestCase(new long[] { 2, 3, 5, 6, 7 }, ExpectedResult = 1)]
        [TestCase(new long[] { 2, 112, 5, 6, 7 }, ExpectedResult = 1)]
        [TestCase(new long[] { 22, 11, 33, 14, 2, 5 }, ExpectedResult = 1)]
        [TestCase(new long[] { 100, 50, 10 }, ExpectedResult = 10)]
        [TestCase(new long[] { 1, 2 }, ExpectedResult = 1)]
        public long TestNODEuclid(long[] nums)
        {
            long result = FindNOD.SearchByEuclid(out long time, nums);
            Console.WriteLine(time);
            return result;
        }
        [TestCase(1, 2, ExpectedResult = 1)]
        public long TestNODEuclid(long a, long b)
        {
            long result = FindNOD.SearchByEuclid(a, b);
            return result;
        }
        [TestCase(new long[] { 2, 3, 5, 6, 7 }, ExpectedResult = 1)]
        [TestCase(new long[] { 2, 112, 5, 6, 7 }, ExpectedResult = 1)]
        [TestCase(new long[] { 22, 11, 33, 14, 2, 5 }, ExpectedResult = 1)]
        [TestCase(new long[] { 100, 50, 10 }, ExpectedResult = 10)]
        [TestCase(new long[] { 1, 2 }, ExpectedResult = 1)]
        public long TestNODStein(long[] nums)
        {
            long result = FindNOD.SearchByStein(out long time, nums);
            Console.WriteLine(time);
            return result;
        }
        [TestCase(1, 2, ExpectedResult = 1)]
        public long TestNODStein(long a, long b)
        {
            long result = FindNOD.SearchByStein(a, b);
            return result;
        }
    }

    public class IsNullTests
    {
        [Test]
        public void TestIsNullString()
        {
            string obj = "Kathy";
            string obj2 = null;
            var result = obj.IsNull();
            var result2 = obj2.IsNull();
            Assert.AreEqual(result, false);
            Assert.AreEqual(result2, true);
        }
        [Test]
        public void TestIsNullInt()
        {
            int? obj = null;
            int? obj2 = 2;
            var result = obj.IsNull();
            var result2 = obj2.IsNull();
            Assert.AreEqual(result, true);
            Assert.AreEqual(result2, false);
        }
        [Test]
        public void TestIsDateTime()
        {
            DateTime? obj = null;
            DateTime obj2 = DateTime.Now;
            DateTime? obj3 = DateTime.Now;
            var result = obj.IsNull();
            var result2 = obj2.IsNull();
            var result3 = obj2.IsNull();
            Assert.AreEqual(result, true);
            Assert.AreEqual(result2, false);
            Assert.AreEqual(result3, false);
        }


    }
}