using NUnit.Framework;
using Task4_6;
using System;

namespace Tests
{
    public class NUTestFilter
    {
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 70, 17 })]
        [TestCase(new int[] { 7, 1, 2 }, 3, ExpectedResult = null)]
        public int[]  Test(int[] arr, int filter) => Filter.FilterDigit(arr, filter);
        [TestCase(22)]
        public void Test2(int digit)
        {
            int[] arr = new int[] { 7, 1, 2 };
            Assert.Throws<ArgumentNullException>(() => Filter.FilterDigit(arr, digit));
        }
        [TestCase(2)]
        public void Test3(int digit)
        {
            Assert.Throws<ArgumentNullException>(() => Filter.FilterDigit(null, digit));
        }
        [TestCase(null)]
        public void Test4(int digit)
        {
            Assert.Throws<ArgumentNullException>(() => Filter.FilterDigit(null, digit));
        }

    }
}