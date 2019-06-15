using System;

namespace Task5_2
{
    public class Matrix
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
                for (int i = 0; i < array.Length; i++)
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
                for (int i = 0; i < array.Length; i++)
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

    public class SortBySumElement
    {
        /// <summary>
        /// Сортировка по сумме элементов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="ascdesc">true по возрастанию, false по убыванию</param>
        public void GetSortedToSumElements(Matrix array, bool ascdesc)
        {

            for (int i = 0; i < array.Array.Length; i++)
            {
                for (int j = 0; j < array.Array[i].Length; j++)
                {
                    if ((array.Sum(array.Array[i]) < array.Sum(array.Array[j])) && (ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                    if ((array.Sum(array.Array[i]) > array.Sum(array.Array[j])) && (!ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                }
            }
        }
    }

    public class SortByMinElement
    {
        /// <summary>
        /// Сортировка по минимальному элементу
        /// </summary>
        /// <param name="array"></param>
        /// <param name="ascdesc">true по возрастанию, false по убыванию</param>
        public void GetSortedToMinElements(Matrix array, bool ascdesc)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                for (int j = 0; j < array.Array[i].Length; j++)
                {
                    if ((array.MaxMinElement(array.Array[i], false) < array.MaxMinElement(array.Array[j], false)) && (ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                    if ((array.MaxMinElement(array.Array[i], false) > array.MaxMinElement(array.Array[j], false)) && (!ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                }
            }
        }
    }

    public class SortByMaxElement
    {
        /// <summary>
        /// Сортировка по максимальному элементу
        /// </summary>
        /// <param name="array"></param>
        /// <param name="ascdesc">true по возрастанию, false по убыванию</param>
        public void GetSortedToMaxElements(Matrix array, bool ascdesc)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                for (int j = 0; j < array.Array[i].Length; j++)
                {
                    if ((array.MaxMinElement(array.Array[i], true) < array.MaxMinElement(array.Array[j], true)) && (ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                    if ((array.MaxMinElement(array.Array[i], true) > array.MaxMinElement(array.Array[j], true)) && (!ascdesc))
                    {
                        array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                }
            }
        }
    }
}
