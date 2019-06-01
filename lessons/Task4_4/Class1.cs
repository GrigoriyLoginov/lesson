using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    public class ConcatanationTwoLine
    {
        /// <summary>
        /// Метод конкатенации двух строк с удаление повторяющихся символов
        /// </summary>
        /// <param name="first">Первая строка</param>
        /// <param name="second">Вторая строка</param>
        /// <returns>Соединенная строка</returns>
        public string Conc(string first, string second)
        {
            string str = "";
            foreach (char c in first)
            {
                if (char.IsLetter(c) && !char.IsDigit(c))
                    str += c;
            }
            foreach (char c in second)
            {
                if (char.IsLetter(c) && !char.IsDigit(c))
                    str += c;
            }
            string result = "";
            result += str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] != str[i])
                    result += str[i];
            }
            return result;
        }
    }
}
