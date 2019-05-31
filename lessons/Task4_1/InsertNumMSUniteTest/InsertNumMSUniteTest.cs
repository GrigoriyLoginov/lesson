using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_1;

namespace InsertNumMSUniteTest
{
    [TestClass]
    public class InsertNumTests
    {
        [TestMethod]
        public void Test15_and_15_expected_15_i0j0()
        {
            int actual = InsertNum.InsertNumber(15, 15, 0, 0);
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void Test8_and_15_expected_9_i0j0()
        {
            int actual = InsertNum.InsertNumber(8, 15, 0, 0);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Test8_and_15_expected_120_i3j8()
        {
            int actual = InsertNum.InsertNumber(8, 15, 3, 8);
            Assert.AreEqual(120, actual);
        }

        [TestMethod]
        public void Test15_and_13_expected_27_i1j7()
        {
            int actual = InsertNum.InsertNumber(15, 13, 1, 7);
            Assert.AreEqual(27, actual);
        }

        [TestMethod]
        public void Test3_and_5_expected_23_i2j5()
        {
            int actual = InsertNum.InsertNumber(3, 5, 2, 5);
            Assert.AreEqual(23, actual);
        }

        [TestMethod]
        public void TestOutOfRange_i()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => InsertNum.InsertNumber(8, 15, -7, 0));
        }

        [TestMethod]
        public void TestOutOfRange_ij()
        {
            Assert.ThrowsException<ArgumentException>(() => InsertNum.InsertNumber(8, 15, 7, 1));
        }
    }
}
