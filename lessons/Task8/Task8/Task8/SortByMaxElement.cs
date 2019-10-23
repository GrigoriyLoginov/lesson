using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    public class SortByMaxElement : ISort<int>
    {
        /// <summary>
        /// Сортировка по максимальному элементу
        /// </summary>
        /// <param name="array"></param>
        /// <param name="Isascdescing">true по возрастанию, false по убыванию</param>
        public void SortByElements(IMatrix<int> array, bool Isascdescing)
        {
            for (int i = 0; i < array.Array.Length; i++)
            {
                for (int j = 0; j < array.Array.Length; j++)
                {
                    if (Isascdescing)
                    {
                        if ((array.MaxMinElement(array.Array[i], true) < array.MaxMinElement(array.Array[j], true)))
                            array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                    else
                    {
                        if ((array.MaxMinElement(array.Array[i], true) > array.MaxMinElement(array.Array[j], true)))
                            array.Swap(ref array.Array[i], ref array.Array[j]);
                    }
                }
            }
        }
    }
}
