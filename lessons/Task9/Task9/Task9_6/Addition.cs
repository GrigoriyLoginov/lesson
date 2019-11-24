using System;

namespace Task9_6
{
    public static class Addition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string result = new string(charArray);
            return result;
        }
        /// <summary>
        /// Сложение двух чисел в формате строки
        /// </summary>
        /// <param name="FirstNumber">первое число</param>
        /// <param name="SecondNumber">второе число</param>
        /// <returns>Результат сложения двух чисел в формате строки</returns>
        public static string FindSum(string FirstNumber, string SecondNumber)
        {
            int maxl = Math.Max(FirstNumber.Length, SecondNumber.Length);

            FirstNumber = FirstNumber.PadLeft(maxl, '0');
            SecondNumber = SecondNumber.PadLeft(maxl, '0');

            string result = "";
            int transfer = 0;
            for (int i = SecondNumber.Length-1; i >=0; i--)
            {
                int sum = int.Parse(FirstNumber[i].ToString()) +
                        int.Parse(SecondNumber[i].ToString()) + transfer;
                result += (char)(sum % 10 + '0');
                transfer = sum / 10;
            }

            if (transfer > 0)
                result += (char)(transfer + '0');

            result = result.Reverse();
            return result;
        }
    }
}
