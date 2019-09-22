using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_2;

namespace MSTestSearch
{
    [TestClass]
    public class SearhMax
    {
        [TestMethod]
        public void TestMethod()
        {
            SearchMax searchMax = new SearchMax();
            int[] mass = {3,6,1,8,-2,7,12,6,99,192,12,663};
            int Actual = searchMax.MaxElement(mass);

            Assert.AreEqual(663,Actual);
        }
    }
}
