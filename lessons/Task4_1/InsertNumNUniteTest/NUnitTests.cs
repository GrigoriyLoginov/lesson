using System;
using NUnit.Framework;
using Task4_1;

namespace InsertNumNUniteTest
{
    public class InsertNumTest
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberNUnitTest1(int one, int two, int i, int j)
        {
            return InsertNum.InsertNumber(one, two, i, j);
        }

        [TestCase(10, 10, -5, 2)]
        public void InsertNumberNUnitTest_ArgumentOutOfRangeException(int one, int two, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => InsertNum.InsertNumber(one, two, i, j));
        }
        [TestCase(10, 8, 7, 2)]
        public void InsertNumberNUnitTest_ArgumentException(int one, int two, int i, int j)
        {
            Assert.Throws<ArgumentException>(() => InsertNum.InsertNumber(one, two, i, j));
        }
    }
}