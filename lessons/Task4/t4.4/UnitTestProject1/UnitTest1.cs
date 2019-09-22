using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string actual = ConcatenationTwoLine.Concatenation("gd,jjj", "gggk32323)");
            Assert.AreEqual("gdjgk", actual);
        }
    }
}
