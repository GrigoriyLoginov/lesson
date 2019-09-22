using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestFilter
{
    [TestClass]
    public class MSTestFilter
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] unfiltered = { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17 };

            int[] actual = Task4_6.Filter.FilterDigit(unfiltered, 7);

            CollectionAssert.AreEqual(new int[] { 7, 70, 17 }, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] unfiltered = { 7, 1, 2, 3, 4, 5, 6, 68, 69, 70, 15, 17, 21, 61, 62, 81, 99, 12, 84 };

            int[] actual = Task4_6.Filter.FilterDigit(unfiltered, 8);

            CollectionAssert.AreEqual(new int[] { 68, 81, 84 }, actual);
        }
    }
}
