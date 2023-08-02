namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с полиномами
    /// </summary>
    /// <summary>
    /// Класс для работы с полиномами
    /// </summary>
    public class Polynoms
    {
        /// <summary>
        /// Массив для нахождения полинома Ньютона
        /// </summary>
        /// <param name="massX">Массив X</param>
        /// <param name="massY">Массив значений</param>
        /// <param name="massA">Массив разностей</param>
        /// <param name="x">Шаг</param>
        /// <returns>Полином Ньютона</returns>
        public double FindNewtonPolynom(double[] massX, double[] massY, double[] massA, double x)
        {
            int n = massA.Length;
            massA[0] = massY[0];
            double polynom = 0;
            for (int i = 0; i < n; i++)
            {
                double recursion = 1;
                for (int j = 0; j <= i - 1; j++)
                {
                    recursion *= x - massX[j];
                }
                polynom += massA[i] * recursion;
            }

            return polynom;
        }
    }
}
