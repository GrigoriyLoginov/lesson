using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    public class SearchMax
    {
       
        /// <summary>
        /// Рекурсивный метод нахождения максимального элемента в неотсортированном массиве
        /// </summary>
        /// <param name="a">Массив целочисленных элементов</param>
        /// <returns>Максимальный элемент массива</returns>
        public int MaxEl(int[] a)
        {
            return MaxEl(a, 0, a.Length - 1);
        }

        int MaxEl(int[] a, int left, int right)
        {
            if (left == right) return a[left];
            else
            {
                int temp1 = MaxEl(a, left, (left + right) / 2);
                int temp2 = MaxEl(a, (left + right) / 2 + 1, right);
                return Math.Max(temp1, temp2);
            }
        }
    }
   
}
