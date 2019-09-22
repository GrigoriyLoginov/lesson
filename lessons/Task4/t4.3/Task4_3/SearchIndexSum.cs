namespace Task4_3
{
    public class SearchIndexSum
    {
        /// <summary>
        /// Метод поиска индекса вещественного массива, где сумма элементов справа и слева равна
        /// </summary>
        /// <param name="mass">Вещественный массив</param>
        /// <returns>Индекс элемента массива</returns>
        public static int Search(double[] mass)
        {
            double lsum = 0, rsum = 0;
            for (int i = 1; i < mass.Length; i++)
                rsum += mass[i];
            for (int i = 0; i < mass.Length - 1; i++)
            {
                if (lsum - rsum <= 0.00000001 && lsum - rsum >= -0.00000001) return i;
                lsum += mass[i];
                rsum -= mass[i + 1];
            }
            if (lsum - rsum <= 0.00000001 && lsum - rsum >= -0.00000001) return mass.Length - 1;
            return -1;
        }

    }
}
