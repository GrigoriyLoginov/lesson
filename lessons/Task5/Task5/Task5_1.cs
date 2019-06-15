using System;

namespace Task5_1
{
    public class Task5_1
    {
        /// <summary>
        /// Алгоритм Ньютона нахождения корня n-ой степени(grades) из вещественного числа(number) с заданной точнстью(accurancy)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="grades"></param>
        /// <param name="accurancy"></param>
        /// <returns></returns>
        public static double FindNthRoot(double number, int grades, double accurancy)
        {
            if ((grades < 0 || accurancy < 0) || (number < 0 && grades % 2 == 0)) throw new ArgumentException();
            if (number == 0) return 0;
            double res = accurancy;
            int decimals = 0;
            do
            {
                decimals++;
                res *= 10;
            }
            while (res != 1);
            double x = 0, result = 1;
            while (Math.Abs((x - result) * 10) > accurancy)
            {
                x = result;
                result = ((grades - 1) * x + number / Pow(x, grades - 1)) / grades;
            }
            result = (double)decimal.Round(decimal.Parse(result.ToString()), decimals);
            return result;

        }
        private static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }
    }
}
