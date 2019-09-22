using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_5
{
    public static class FindNumber
    {
        public static int FindNextBiggerNumber(int number, ref long time)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (number < 0 || number >= int.MaxValue)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number <= 11)
            {
                time = watch.ElapsedMilliseconds;
                return -1;
            }
            int result = NextHighestNumber(number, ref time);
            time = watch.ElapsedMilliseconds;
            return result;

        }

        /// <summary>
        /// Метод возвращающий принимающий число и возвращающий большее число, состоящее из цифр исходного числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static int NextHighestNumber(int number, ref long time)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] buffer = new int[number.ToString().Length];
            string num = number.ToString();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = int.Parse(number.ToString()[i].ToString());
            }

            int index = -1;

            index = IndexSearch(buffer);

            int temp = 0;

            if (index < buffer.Length - 1 && index > -1)
            {
                temp = buffer[index];
                buffer[index] = buffer[index + 1];
                buffer[index + 1] = temp;

                int[] ArSortMore = new int[buffer.Length - index];
                int j = 0;
                for (int i = index; i < buffer.Length; i++)
                {
                    ArSortMore[j] = buffer[i];
                    j++;
                }
                //Сортируем по убыванию
                SortMass(ArSortMore, true);
                int[] ArSortLess = new int[ArSortMore.Length - 1];
                j = 0;
                for (int i = 1; i < ArSortMore.Length; i++)
                {
                    ArSortLess[j] = ArSortMore[i];
                    j++;
                }
                //Сортируем по возрастанию
                SortMass(ArSortLess, false);

                j = 0;
                int[] ArrayReturn = new int[buffer.Length];
                for (int i = 0; i < buffer.Length; i++)
                {
                    if (i >= 0 && i < index)
                        ArrayReturn[i] = buffer[i];
                    if (i == index)
                        ArrayReturn[i] = ArSortMore[j];
                    if (i > index)
                    {
                        ArrayReturn[i] = ArSortLess[j];
                        j++;
                    }
                }
                string ret = "";
                foreach (int item in ArrayReturn)
                {
                    ret += item;
                }
                return int.Parse(ret);
            }
            return -1;
        }
        /// <summary>
        /// Поиск индекса
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static int IndexSearch(int[] temp)
        {
            for (int i = temp.Length - 1; i > 0; i--)
            {
                if (temp[i] > temp[i - 1])
                {
                    return (i - 1);
                }
            }
            return -1;
        }
        /// <summary>
        /// Метод сортировки массива
        /// </summary>
        /// <param name="mass">Массив для сортировки</param>
        /// <param name="ascdesc">Параметр по возрастанию(false),убыванию(true)</param>
        private static void SortMass(int[] mass, bool ascdesc)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int k = 0; k < mass.Length - i - 1; k++)
                {
                    if (ascdesc)
                    {
                        if (mass[k] < mass[k + 1])
                            Swap(ref mass[k], ref mass[k + 1]);
                    }
                    else
                    {
                        if (mass[k] > mass[k + 1])
                            Swap(ref mass[k], ref mass[k + 1]);
                    }
                }
            }
        }
        /// <summary>
        /// Метод смены местами чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(ref int a, ref int b)
        {
            int res = a;
            a = b;
            b = res;
        }

    }

}
