using NUnit.Framework;
using Task4_3;

namespace Tests
{
    public class Tests
    {
        [TestCase(new double[] { 2, 4, 1 }, ExpectedResult = -1)]
        [TestCase(new double[] { 2, 3, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new double[] { 0.1, 0, 0.124, 0.241, 1, 0.1, -1, 0.124 }, ExpectedResult = 3)]
        public int Search(double[] mass)
        {
            return SearchIndexSum.Search(mass);
        }
    }
}