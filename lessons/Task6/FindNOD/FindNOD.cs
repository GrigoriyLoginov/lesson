using System;
using System.Diagnostics;

namespace Find
{
    public class FindNOD
    {
        /// <summary>
        /// Алгоритм Евклида на 2 цифрах
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>НОД</returns>
        public static long SearchByEuclid(long a, long b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return Math.Abs(a);
        }
        /// <summary>
        /// Алгоритм Евклида на нескольких цифрах
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>НОД</returns>
        public static long SearchByEuclid(params long[] nums) => NOD(SearchByEuclid, nums);

        public static long SearchByEuclid(out long time, params long[] nums) => NOD(SearchByEuclid, out time, nums);
        /// <summary>
        /// Алгоритм Стейна на 2 цифрах
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>НОД</returns>
        public static long SearchByStein(long a, long b)
        {
            long? nod = null;

            if (a == 0)
                nod = b;
            else if (b == 0)
                nod = a;
            else if (a == b)
                nod = a;
            else if (a == 1 || b == 1)
                nod = 1;

            if (nod != null)
                return Math.Abs((long)nod);

            if ((a & 1) == 0)
                nod = ((b & 1) == 0)
                    ? SearchByStein(a >> 1, b >> 1) << 1
                    : SearchByStein(a >> 1, b);
            else
                nod = ((b & 1) == 0)
                    ? SearchByStein(a, b >> 1)
                    : SearchByStein(b, a > b ? a - b : b - a);

            return Math.Abs((long)nod);
        }
        /// <summary>
        /// Алгоритм Стейна на нескольких цифрах
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>НОД</returns>
        public static long SearchByStein(params long[] nums) => NOD(SearchByStein, nums);

        public static long SearchByStein(out long time, params long[] nums) => NOD(SearchByStein, out time, nums);

        private static void CheckInputArray(long[] nums)
        {
            if (nums == null)
                throw new ArgumentNullException();

            if (nums.Length < 2)
                throw new ArgumentException();
        }
        private static long NOD(Func<long, long, long> FuncSearch, long a, long b, out long time)
        {
            var sw = Stopwatch.StartNew();

            long nod = FuncSearch(a, b);

            time = sw.ElapsedTicks;


            return nod;
        }

        private static long NOD(Func<long, long, long> FuncSearch, params long[] nums)
        {
            CheckInputArray(nums);

            long nod = FuncSearch(nums[0], nums[1]);

            for (int i = 2; i < nums.Length; i++)
            {
                nod = FuncSearch(nod, nums[i]);
            }

            return nod;
        }

        private static long NOD(Func<long[], long> FuncSearch, out long time, params long[] nums)
        {
            var sw = Stopwatch.StartNew();

            long nod = FuncSearch(nums);

            time = sw.ElapsedTicks;


            return nod;
        }

    }
}
