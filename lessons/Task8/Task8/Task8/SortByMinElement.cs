using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    /// <summary>
    /// Сортировка по сумме элементов
    /// </summary>
    /// <param name="array"></param>
    /// <param name="ascdesc">true по возрастанию, false по убыванию</param>
    public class SortByMinElement : ISort<int>
    {
        public void SortByElements(IMatrix<int> array, bool ascdesc)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                for (int j = 0; j < array.Array.Length; j++)
                {
                    if (ascdesc)
                    {
                        if (array.MaxMinElement(array.Array[i], false) < array.MaxMinElement(array.Array[j], false))
                            array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                    else
                    {
                        if (array.MaxMinElement(array.Array[i], false) > array.MaxMinElement(array.Array[j], false))
                            array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                }
            }
        }
    }
}
