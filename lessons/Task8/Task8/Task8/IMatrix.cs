using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    /// <summary>
    /// Интерфейс матрицы
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMatrix<T>
    {
        T[][] Array { get; }
        T Sum(T[] arr);
        T MaxMinElement(T[] array, bool maxmin);
        void Swap(ref T[] array1, ref T[] array2);
    }
}
