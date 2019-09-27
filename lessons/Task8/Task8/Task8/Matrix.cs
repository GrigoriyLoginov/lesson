using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    /// <summary>
    /// Класс матрицы
    /// </summary>
    public class Matrix : IMatrix<int>
    {
        private readonly int[][] arr;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">Матрица</param>
        public Matrix(int[][] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length == 0) throw new ArgumentException(nameof(array));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 0) throw new ArgumentNullException();
            }
            this.arr = array;
        }
        public int[][] Array { get { return arr; } }
        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        /// <summary>
        /// Поиск минимального(минимального) элемента массива
        /// </summary>
        /// <param name="array"></param>
        /// <param name="maxmin">true максимальный, false минимальный</param>
        /// <returns></returns>
        public int MaxMinElement(int[] array, bool maxmin)
        {
            if (maxmin)
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
                return min;
            }
        }
        /// <summary>
        /// Перестановка строк матрицы
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        public void Swap(ref int[] array1, ref int[] array2)
        {
            int[] res = array1;
            array1 = array2;
            array2 = res;
        }
    }
}
