using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_5;
using System;

namespace FindingNumbersMSTest.Tests
{
    [TestClass]
    public class MSUnitTest
    {
        long time = 0;
        [TestMethod]
        public void TestMethod1()
        {
            int num = 3456432;
            int expected = FindNumber.FindNextBiggerNumber(num,ref time);
            Assert.AreEqual(expected, 3462345);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int num = 1234126;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 1234162);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int num = 20;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, -1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int num = 12;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 21);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int num = 513;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 531);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int num = 2017;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 2071);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int num = 414;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 441);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int num = 144;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 414);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int num = 1234321;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, 1241233);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int num = 10;
            int expected = FindNumber.FindNextBiggerNumber(num, ref time);
            Assert.AreEqual(expected, -1);
        }
        [TestMethod]
        public void TestMethod11()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => FindNumber.FindNextBiggerNumber(-140,ref time));
        }
    }
}
