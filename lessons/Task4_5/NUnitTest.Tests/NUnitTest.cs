using NUnit.Framework;
using System;
namespace Tests
{
    public class NUnitTest
    {
        long time = 0;
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]
        public int TestMethod(int number)
        {

            int result = Task4_5.FindNumber.FindNextBiggerNumber(number, ref time);
            System.Diagnostics.Debug.WriteLine($"Время выполнения {time}");
            return result;
        }
    }
}