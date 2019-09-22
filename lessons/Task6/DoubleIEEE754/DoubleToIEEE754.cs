using System;

namespace DoubleIEEE754
{
    /// <summary>
    /// Класс помогает «добавить» методы конвертации в существующий двойной тип
    /// </summary>
    public class DoubleToIEEE754
    {
        /// <summary>
        /// Преобразует вещетвенное число в формате IEE 754
        /// </summary>
        /// <param name="number"></param>
        /// <returns>
        /// Строка с двоичным представлением двойного числа по IEE 754.
        /// </returns>
        public static string ToIEEE754(double number)
        {
            Convert convert = new Convert(number);
            long point = convert.ToLong();
            System.Text.StringBuilder byteString = new System.Text.StringBuilder();

            while (byteString.Length < 64)
            {
                if ((point & 1) == 1)
                {
                    byteString.Insert(0, "1");
                }
                else
                {
                    byteString.Insert(0, "0");
                }
                point >>= 1;
            }
            return byteString.ToString();
        }
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit, Size = 64)]
        struct Convert
        {
            [System.Runtime.InteropServices.FieldOffset(0)]
            private long Long;
           [System.Runtime.InteropServices.FieldOffset(0)]
            private double Double;

            public Convert(double value) : this()
            {
                Double = value;
            }
            public long ToLong() => Long;
        }
    }
}
