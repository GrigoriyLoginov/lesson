using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4_6;

namespace TestDDT
{
    [TestClass]
    public class UnitTestProj
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [TestMethod()]
        //[DeploymentItem("TestDDT\\data.xlsx")]
        //[DataSource("MyExcelDataSource")]
        [DataSource("System.Data.OleDB", @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=data.xlsx;
    Extended Properties='Excel 12.0;HDR=yes';", "Sheet1$", DataAccessMethod.Sequential)]
        public void MyTestMethod2()
        {
            string[] stringfilter = testContextInstance.DataRow["Val1"].ToString().Split(new char[] { ',' });
            int[] unfiltered = new int[stringfilter.Length];
            for (int i = 0; i < unfiltered.Length; i++)
            {
                unfiltered[i] = int.Parse(stringfilter[i]);
            }
            string[] stringexpected = testContextInstance.DataRow["Val2"].ToString().Split(new char[] { ',' });
            int[] expected = new int[stringexpected.Length];
            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] = int.Parse(stringexpected[i]);
            }
            int digit = int.Parse(testContextInstance.DataRow["Val3"].ToString());

            int[] actual = Filter.FilterDigit(unfiltered, digit);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
