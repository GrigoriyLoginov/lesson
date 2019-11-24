using NUnit.Framework;
using Task9_6;

namespace Task9.Tests
{
    class TestsTask9_6
    {
        [TestCase("11112241125", "99996236712", ExpectedResult = "111108477837")]
        [TestCase("11112241125", "9996236712", ExpectedResult = "21108477837")]
        [TestCase("63423", "871253343", ExpectedResult = "871316766")]
        public string TestAddition(string FirstNum,string SecondNum)
        {
            string result = Addition.FindSum(FirstNum, SecondNum);
            return result;
        }
    }
}
