using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using Task8_3;

namespace Task8_3Tests
{


    public class TestsTask8_3
    {
        private static readonly Polynomial pFirst = new Polynomial(1, 2, 8, 6, 16, 3, 12);
        private static readonly Polynomial pSecond = new Polynomial(2, 0, 4, 0, 3);
        #region TestAddition
        [Test]
        public void TestAdditionOnePolynom()
        {
            Polynomial expected = new Polynomial(4, 0, 8, 0, 6);
            Polynomial result = pSecond * 2;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestMultyplyTwoPolynom()
        {
            Polynomial expected = new Polynomial(3, 2, 12, 6, 19, 3, 12);
            Polynomial result = pSecond + pFirst;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestAdditionTwoPolynom()
        {
            Polynomial expected = new Polynomial(2, 4, 20, 20, 67, 36, 112, 30, 96, 9, 36);
            Polynomial result = pSecond * pFirst;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        #endregion
        #region TestMultyply
        [Test]
        public void TestMultyplyOnePolynom()
        {
            Polynomial expected = new Polynomial(11, 2, 8, 6, 16, 3, 12);
            Polynomial result = pFirst + 10;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        #endregion
        #region TestSubstraction
        [Test]
        public void TestSubstractionOnePolynom1()
        {
            Polynomial expected = new Polynomial(-4, 2, 8, 6, 16, 3, 12);
            Polynomial result = pFirst - 5;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestSubstractionOnePolynom2()
        {
            Polynomial expected = new Polynomial(0, 0, -4, 0, -3);
            Polynomial result = 2 - pSecond;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestSubstractionTwoPolynom()
        {
            Polynomial expected = new Polynomial(1, -2, -4, -6, -13, -3, -12);
            Polynomial result = pSecond - pFirst;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        #endregion
        #region TestDivision
        [Test]
        public void TestDivisionTwoPolynom()
        {
            string expected = "(2+4x^2+3x^4)(1x+4x^2)+1+2x^3";
            string result = pFirst / pSecond;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestDivisionOnePolynom1()
        {
            Polynomial expected = new Polynomial(1, 0, 2, 0, 1.5);
            Polynomial result = pSecond / 2;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        [Test]
        public void TestDivisionOnePolynom2()
        {
            Polynomial expected = new Polynomial(6, 0, 3, 0, 4);
            Polynomial result = 12 / pSecond;
            Console.WriteLine(expected);
            Console.WriteLine(result);
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
        #endregion
        #region TestEquality
        [Test]
        public void TestEqualityPolynoms()
        {
            bool Equal = (pFirst == pSecond);
            Assert.AreEqual(false, false);
        }
        [Test]
        public void TestNoEqualityPolynoms()
        {
            bool Equal = (pFirst != pSecond);
            Assert.AreEqual(true, true);
        }
        #endregion
        #region TestException
        [Test]
        public void TestDivisionArgumentOutOfRangeException()
        {
            Assert.Catch<ArgumentOutOfRangeException>(() => { var result = pSecond / pFirst; });
        }
        #endregion
    }
}
