using NUnit.Framework;
using Task8_1;
using System;
using System.Runtime.Serialization;

namespace Task8_1Tests
{
    public class AssertMatrix : Assert
    {
        public static void AreEqual(IMatrix<int> expected, IMatrix<int> actual)
        {
            if (actual == null)
                throw new NullReferenceException();
            for (int i = 0; i < expected.Array.Length; i++)
            {
                if (expected.Array.Length == actual.Array.Length)
                {
                    for (int j = 0; j < expected.Array[i].Length; j++)
                    {
                        if (expected.Array[i][j] != actual.Array[i][j])
                            throw new MismatchElements();
                    }
                }
                else throw new ArgumentOutOfRangeException();
            }
        }
    }


    internal class MismatchElements : Exception
    {
        public MismatchElements()
        {
        }

        public MismatchElements(string message) : base(message)
        {
        }
    }

    public static class Print
    {
        public static void PrintMatrix(IMatrix<int> matrix)
        {
            for (int i = 0; i < matrix.Array.Length; i++)
            {
                for (int j = 0; j < matrix.Array[i].Length; j++)
                {
                    Console.Write(matrix.Array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class Tests
    {

        private readonly IMatrix<int> matrix = new Matrix(new int[][]
        {
            new int[] {1,3,5,7,8,10},
            new int[] {11,22,2},
            new int[] {7,3,4,6},
            new int[] {1,4,33,0}
        });

        #region SortBySumTest
        [Test]
        public void SortBySumElementAscTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {7,3,4,6},
                new int[] {1,3,5,7,8,10},
                new int[] {11,22,2},
                new int[] {1,4,33,0}
            });


            (new SortBySumElement()).SortByElements(matrix, true);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        [Test]
        public void SortBySumElementDescTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {1,4,33,0},
                new int[] {11,22,2},
                new int[] {1,3,5,7,8,10},
                new int[] {7,3,4,6}
            });



            (new SortBySumElement()).SortByElements(matrix, false);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        #endregion
        #region SortByMaxTest
        [Test]
        public void SortByMaxElementDescTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {1,4,33,0},
                new int[] {11,22,2},
                new int[] {1,3,5,7,8,10},
                new int[] {7,3,4,6}
            });

            (new SortByMaxElement()).SortByElements(matrix, false);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        [Test]
        public void SortByMaxElementAscTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {7,3,4,6},
                new int[] {1,3,5,7,8,10},
                new int[] {11,22,2},
                new int[] {1,4,33,0}
            });

            (new SortByMaxElement()).SortByElements(matrix, true);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        #endregion
        #region SortByMinTest
        [Test]
        public void SortByMinElementAscTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {1,4,33,0},
                new int[] {1,3,5,7,8,10},
                new int[] {11,22,2},
                new int[] {7,3,4,6}
            });

            (new SortByMinElement()).SortByElements(matrix, true);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        [Test]
        public void SortByMinElementDescTest()
        {
            IMatrix<int> expectedMatrix = new Matrix(new int[][]
            {
                new int[] {7,3,4,6},
                new int[] {11,22,2},
                new int[] {1,3,5,7,8,10},
                new int[] {1,4,33,0}
            });

            (new SortByMinElement()).SortByElements(matrix, false);

            Print.PrintMatrix(matrix);
            Print.PrintMatrix(expectedMatrix);
            AssertMatrix.AreEqual(expectedMatrix, matrix);
        }
        #endregion
        #region TestException
        [Test]
        public void ArgumentNullExceptionTest()
        {

            Assert.Catch<ArgumentNullException>(() =>
            new Matrix(new int[][]
            {
                new int[] {7,3,4,6},
                new int[] {},
                new int[] {1,3,5,7,8,10},
                new int[] {1,4,33,0}
            }));
        }
        [Test]
        public void ArgumentExceptionTest()
        {
            Assert.Catch<ArgumentException>(() =>
            new Matrix(new int[][]
            {
            }));
        }
        #endregion
    }
}