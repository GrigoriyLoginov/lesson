using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTest.Tests
{
    [TestClass]
    public class Tests
    {
        [DataTestMethod]
        [DataRow(1, 5, 0.0001, 1)]
        [DataRow(8, 3, 0.0001,  2)]
        [DataRow(0.001, 3, 0.0001,  0.1)]
        [DataRow(0.04100625, 4, 0.0001,  0.45)]
        [DataRow(8, 3, 0.0001,  2)]
        [DataRow(0.0279936, 7, 0.0001,  0.6)]
        [DataRow(0.0081, 4, 0.1,  0.3)]
        [DataRow(-0.008, 3, 0.1,  -0.2)]
        [DataRow(0.004241979, 9, 0.00000001,  0.545)]
        //[DataRow(1, 5, 0.0001,  1)]
        public void Test(double number, int degree, double precision,double actual)
        {
            Assert.AreEqual(Task5_1.Task5_1.FindNthRoot(number, degree, precision), actual);
        }

        //        [a = -0.01, n = 2, accurancy = 0.0001] <- ArgumentException
        //[a = 0.001, n = -2, accurancy = 0.0001] <- ArgumentException
        //[a = 0.01, n = 2, accurancy = -1] <- ArgumentException...
        [DataTestMethod]
        [DataRow(-0.01,2,0.00001)]
        [DataRow(0.001, -2, 0.00001)]
        [DataRow(0.01, 2, -1)]
        public void MethodName_Number_Degree_Precision_ArgumentOutOfRangeException(double number,int degree,double precision)
        {
            Assert.ThrowsException<ArgumentException>(() => Task5_1.Task5_1.FindNthRoot(number, degree, precision));
        }
    }
}
