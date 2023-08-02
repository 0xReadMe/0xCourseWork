using System.Diagnostics;
using System.Text;
using static LibraryForCoursework.AllData;

namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для работы с данными
    /// </summary>
    public class DataController
    {
        readonly InfiniteSeries infiniteSeries = new();
        readonly Matrix matrix = new();
        readonly Polynoms polynom = new();
        readonly Random random = new();

        /// <summary>
        /// Метод используется для установки значений в массив А
        /// </summary>
        public void SetArrayA()
        {
            Hk = Round(H);
            int i = 0;
            //                        Округляем из-за           
            //                        особенностей значений
            //      Бежим по X        double в C#
            for (double x = XInitial; Math.Round(x, Hk) <= XFinal; x += H)
            {
                if (Math.Abs(x) < 1)
                {
                    Sum = 0;
                    ArrayA[i, 0] = Math.Round(infiniteSeries.Recurse(x), K);
                    ArrayAControl[i] = Math.Round(infiniteSeries.ControlSummand(x), K);
                    i++;
                }
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив B
        /// </summary>
        public void SetArrayB()
        {
            for (int i = 0; i < ArrayB.GetLength(0); i++)
            {
                for (int j = 0; j < ArrayB.GetLength(1); j++)
                {
                    ArrayB[i, j] = random.Next(LowerBound, UpperBound);
                }
            }
        }

        /// <summary>
        /// Метод используется для установки значений в массив C
        /// </summary>
        public void SetArrayC()
        {
            double[,] ArrayBSqrt = matrix.Multiplication(ArrayB, ArrayB);
            ArrayC = matrix.Multiplication(ArrayBSqrt, ArrayA);
        }

        /// <summary>
        /// Метод используется для установки значений в массив Y
        /// </summary>
        public void SetArrayY()
        {
            int n = ArrayC.GetLength(0);///////////////ArrayC.Length


            int m = Convert.ToInt32(Math.Round(((n - 1) / G), 0) + 1);
            ArrayInterpolation = new double[m];
           
            double[] tempArrayX = new double[n]; // Массив X
            double[] tempArrayY = new double[n]; // Массив Y

            for (int i = 0; i < n; i++)
            {
                tempArrayX[i] = i;
                tempArrayY[i] = ArrayC[i, 0];///////////////ArrayC[i]
            }
            int j = 0;
            double[] dissadictionArray = matrix.MatrixDisaddiction(tempArrayX, tempArrayY);
            for (double x = tempArrayX[0]; x < tempArrayX[n - 1]; x += G)
            {
                ArrayInterpolation[j] = polynom.FindNewtonPolynom(tempArrayX, tempArrayY, dissadictionArray, x); j++; // Интерполяция
            }
        }

        /// <summary>
        /// Метод для сохранения результата подсчётов в файл
        /// </summary>
        /// <param name="text">Данные для сохранения</param>
        public void SaveToFile(string text)
        {
            string executePath = Environment.CurrentDirectory; // директория исполняемого файла
            string path = executePath + "/result.txt"; // путь к файлу с данными
            File.WriteAllBytes(path, Array.Empty<byte>()); // очищаем файл перед записью
            byte[] buffer = Encoding.Default.GetBytes(text); // преобразуем строку в байты
            File.WriteAllBytes(path, buffer);
        }

        /// <summary>
        /// Метод открытия файла с результатом расчётов
        /// </summary>
        public void OpenToFile()
        {
            string executePath = Environment.CurrentDirectory; // директория исполняемого файла
            string path = executePath + "/result.txt"; // путь к файлу
            Process proc = Process.Start("notepad.exe", path);
            proc.WaitForExit();
            proc.Close();
        }

        /// <summary>
        /// Метод сортировки простым выбором
        /// </summary>
        /// <param name="mas">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>
        public double[] Sort(double[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++) //поиск минимального числа
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                (mas[i], mas[min]) = (mas[min], mas[i]); //обмен элементов
            }
            return mas;
        }
        private int Round(double approximateNumber)
        {
            int K = 1;
            while (approximateNumber < 1)
            {
                approximateNumber *= 10;
                K++;
            }
            return K;
        }
    }
}