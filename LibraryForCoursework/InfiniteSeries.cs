using static LibraryForCoursework.AllData;
namespace LibraryForCoursework
{
    /// <summary>
    /// Класс бесконечных рядов
    /// </summary>
    public class InfiniteSeries
    {
        double slagDenum = 1;   // Инициализация
        double slagNum = 1;     // Инициализация
        double summand = 1;     // Инициализация

        /// <summary>
        /// Умножение числителя
        /// </summary>
        /// <param name="slag">Слагаемое</param>
        /// <param name="i">Текущая итерация</param>
        /// <returns></returns>
        private double MultiplicationNumerator(ref double slag, double i)
        {
            slag *= 2 * i + 1;
            return slag;
        }

        /// <summary>
        /// Умножение знаменателя
        /// </summary>
        /// <param name="slag">Слагаемое</param>
        /// <param name="i">Текущая итерация</param>
        /// <returns></returns>
        private double MultiplicationDenominator(ref double slag, double i)
        {
            slag *= 2 * i;
            return slag;
        }

        /// <summary>
        /// Метод возвращающий подсчитанное слагаемое
        /// </summary>
        /// <param name="x">Заданный X</param>
        /// <param name="i">Текущая итерация</param>
        /// <returns>Значение подсчитанного слагаемого</returns>
        private double Calculation(double i, double x) 
        {
            return summand = Math.Pow(-1, i) * ((MultiplicationNumerator(ref slagNum, i) / MultiplicationDenominator(ref slagDenum, i)) * Math.Pow(x, i));
        }

        /// <summary>
        /// Метод возвращающий подсчитанную контрольную формулу
        /// </summary>
        /// <param name="x">Заданный X</param>
        /// <returns>Значение контрольной формулы</returns>
        public double ControlSummand(double x) => 1 / Math.Sqrt(Math.Pow((1 + x), 3));

        /// <summary>
        /// Метод выполняющий подсчёт заданного ряда (Ряд задаётся программно)
        /// </summary>
        /// <param name="x">Заданный X</param>
        /// <returns>Сумма ряда</returns>
        public double Recurse(double x)
        {
            slagDenum = 1;
            slagNum = 1;
            summand = 1;
            for (double i = 1; Math.Abs(summand) > E; i++)
            {
                Sum += Calculation(i, x);
            }
            return Sum + 1;
        }
    }
}