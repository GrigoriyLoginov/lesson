using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_5
{

    public static class Reverse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inpstr">входная строка</param>
        /// <returns></returns>
        public static string ReverseWords(string inpstr)
        {
            if (string.IsNullOrEmpty(inpstr))
                throw new ArgumentNullException();
            string[] temp = inpstr.Split(' ');
            string[] result = new string[temp.Length];
            int j = 0;
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                result[j] = temp[i];
                j++;
            }
            return string.Join(" ", result);
        }
    }
}
