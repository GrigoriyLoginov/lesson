using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    public static class Title
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Title">Исходная строка для преобразования</param>
        /// <param name="Words">Набор букв для преобразования</param>
        /// <returns></returns>
        public static string TitleCase(string Title, string Words = "")
        {
            if (string.IsNullOrEmpty(Title))
                throw new ArgumentNullException();
            string[] TitleArr = Title.Split();
            string[] WordsArr = Words.Split();
            for (int i = 0; i < TitleArr.Length; i++)
            {
                string temp = "";
                for (int j = 0; j < TitleArr[i].Length; j++)
                {
                    if (j == 0) temp += TitleArr[i][j].ToString().ToUpper();
                    else temp += TitleArr[i][j].ToString().ToLower();
                }
                TitleArr[i] = temp;

                foreach (var word in WordsArr)
                {
                    if (TitleArr[i].ToLower() == word.ToLower() && i > 0)
                    {
                        temp = "";
                        for (int j = 0; j < TitleArr[i].Length; j++)
                        {
                            temp += TitleArr[i][j].ToString().ToLower();
                        }
                        TitleArr[i] = temp;
                    }

                }
            }
            string result = string.Join(" ", TitleArr);
            return result;
        }
    }
}
