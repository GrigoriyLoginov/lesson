using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_6
{
    public static class Filter
    {
        
        public static int[] FilterDigit(int[] array, int digit)
        {
            if (array is null || digit < 0 || digit > 9)
            {
                throw new ArgumentNullException();
            }

            List<int> buff = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {

                int temp = array[i];
                while (temp > 0)
                {
                    if (temp % 10 == digit)
                        buff.Add(array[i]);
                    temp /= 10;
                }
            }
            if (buff.ToArray<int>().Length == 0) return null;
            return buff.ToArray<int>();
        }

    }
}
