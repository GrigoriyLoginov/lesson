using NUnit.Framework;
using Task9_2;
namespace Task9.Tests
{
    class TestsTask9_2
    {
        [TestCase("the quick brown fox", "", ExpectedResult = "The Quick Brown Fox")]
        [TestCase("a clash of KINGS", "a an the of", ExpectedResult = "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", ExpectedResult = "The Wind in the Willows")]
        [TestCase("implement if the function the", "uniqueinorder implement THE", ExpectedResult = "Implement If the Function the")]
        public string TestTitleCase(string title, string words)
        {
            string result = Title.TitleCase(title, words);
            return result;
        }
    }
}
