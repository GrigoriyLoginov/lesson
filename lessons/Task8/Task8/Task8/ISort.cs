using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_1
{
    /// <summary>
    /// Интерфейс сортировки
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISort<T>
    {
        void SortByElements(IMatrix<T> matrix, bool ascdesc);
    }
}
