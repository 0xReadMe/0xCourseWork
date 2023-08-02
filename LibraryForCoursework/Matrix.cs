namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с матрицами
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Метод умножения двух матриц
        /// </summary>
        /// <param name="a">Двумерный массив (матрица)</param>
        /// <param name="b">Двумерный массив (матрица)</param>
        /// <returns>Перемноженная матрица</returns>
        /// <exception cref="Exception">Ошибка в случае неподходящего количества столбцов и строк</exception>
        public double[,] Multiplication(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) 
            {
                throw new Exception("Матрицы нельзя перемножить");
            }
            double[,] r = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += Math.Round(a[i, k],AllData.K) * Math.Round(b[k, j],AllData.K);
                    }
                }
            }
            return r;
        }

        /// <summary>
        /// Вычисление матрицы разделенных разностей для полинома Ньютона
        /// </summary>
        /// <param name="massX">Массив X</param>
        /// <param name="massY">Массив Y</param>
        /// <returns>Матрица разделенных разностей</returns>
        public double[] MatrixDisaddiction(double[] massX, double[] massY)
        {
            int n = massX.Length;
            double[] massA = new double[n];
            double[,] matrixDisaddiction = new double[n, n]; // объявление матрицы разделенных разностей
            for (int i = 0; i < n; i++)
            {
                matrixDisaddiction[i, 0] = massY[i]; // заполнение первого столбца из массива Y
            }     
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (i < j) 
                    {
                        matrixDisaddiction[i, j] = 0; // заполнение нулями поля, которые выше нужной диагонали
                    }  
                    else 
                    {
                        matrixDisaddiction[i, j] = (matrixDisaddiction[i, j - 1] - matrixDisaddiction[j - 1, j - 1]) / (massX[i] - massX[j - 1]); // вычисление коэфициентов
                    }
                    if (i == j) 
                    {
                        massA[i] = matrixDisaddiction[i, j]; // заполнение массива коэфициентов коэфициентами
                    }
                }
            }
            return massA;
        }
    }
}