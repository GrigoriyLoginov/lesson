using NUnit.Framework;
using Task9_1;

namespace Task9.Tests
{
    public class TestsTask9_1
    {

        [TestCase("A", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase("B", ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase("C", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00")]
        [TestCase("D", ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase("E", ExpectedResult = "Customer record: 1,000,000.00")]
        [TestCase("", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        public string TestPrintFormat(string frm)
        {
            //string expected = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100";
            Customers cust = new Customers("Jeffrey Richter", 1000000, "+1 (425) 555-0100");
            return cust.Print(frm);
        }
        [TestCase("A", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase("B", ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase("C", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00")]
        [TestCase("D", ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase("E", ExpectedResult = "Customer record: 1,000,000.00")]
        [TestCase("", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        public string TestExpansion(string frmt)
        {
            Customers cust = new Customers("Jeffrey Richter", 1000000, "+1 (425) 555-0100");
            string[] str = new string[] { cust.Name, cust.Revenue.ToString(), cust.ContactPhone };
            string result = str.FormatS(frmt);
            return result;
        }
    }
}