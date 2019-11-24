using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_4
{
    /// <summary>
    /// 
    /// </summary>
    public static class Unique
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">входные данны</param>
        /// <returns></returns>
        public static List<T> UniqueInOrder<T>(IEnumerable<T> input)
        {
            T temp = default(T);
            List<T> result = new List<T>();
            bool trfl = false;
            foreach (var item in input)
            {
                if (!trfl)
                {
                    trfl = true;
                    result.Add(item);
                }
                else if (!item.Equals(temp))
                    result.Add(item);
                temp = item;
            }
            return result;

        }
    }
}
