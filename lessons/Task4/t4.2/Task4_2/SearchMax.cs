using System;

namespace Task4_2
{
    public class SearchMax
    {
       
        /// <summary>
        /// Рекурсивный метод нахождения максимального элемента в неотсортированном массиве
        /// </summary>
        /// <param name="a">Массив целочисленных элементов</param>
        /// <returns>Максимальный элемент массива</returns>
        public int MaxElement(int[] a)
        {
            return MaxElement(a, 0, a.Length - 1);
        }

        private int MaxElement(int[] a, int left, int right)
        {
            if (left == right) return a[left];
            else
            {
                int temp1 = MaxElement(a, left, (left + right) / 2);
                int temp2 = MaxElement(a, (left + right) / 2 + 1, right);
                return Math.Max(temp1, temp2);
            }
        }
    }
   
}
