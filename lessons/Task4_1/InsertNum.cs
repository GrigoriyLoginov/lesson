using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    public class InsertNum
    {
        #region InsertNum method
        /// <summary>
        /// Метод вставки числа битов числа two в one
        /// </summary>
        /// <param name="one">Число в которое нужно вставить</param>
        /// <param name="two">Число, биты которого нужно вставить</param>
        /// <param name="i">Стартовая позиция</param>
        /// <param name="j">Конечная позиция</param>
        /// <returns>Integer with inserted bits of second number into first number</returns>
        public static int InsertNumber(int one, int two, int i, int j)
        {
            if (i < 0 || j < 0 || i > 31 || j > 31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (i > j)
            {
                throw new ArgumentException();
            }

            int previously = ((2 << (j - i)) - 1) << i;
            return (one & ~previously) | ((two << i) & previously);
        }
        #endregion
    }
}
