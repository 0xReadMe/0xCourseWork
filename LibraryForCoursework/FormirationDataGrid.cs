using System.Data;

namespace LibraryForCoursework
{
    /// <summary>
    /// Класс для вывода массивов в DataGrid
    /// </summary>
    public static class FormirationDataGrid 
    {
        /// <summary>
        /// Метод для формирования DataGrid для одномерного массива
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">Одномерный массив</param>
        /// <param name="X">Название массива</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this T[] arr, string X)
        {
            var res = new DataTable();
            res.Columns.Add("№ элемента", typeof(string));
            res.Columns.Add("Элемент массива", typeof(double));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var row = res.NewRow();
                row[0] = $"{X}[{i}]";
                row[1] = $"{arr[i]:f5}";
                res.Rows.Add(row);
            }
            return res;
        }

        /// <summary>
        /// Метод для формирования DataGrid для двумерного массива
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix">Двумерный массив</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add($"{i+1}", typeof(T));
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = $"{matrix[i, j]:f5}";
                }
                res.Rows.Add(row);
            }
            return res;
        }

        /// <summary>
        /// Специальный метод для формирования DataGrid для массива А
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix">Массив А</param>
        /// <param name="control">Контрольная формула массива А</param>
        /// <returns></returns>
        public static DataTable ToDataTableA<T>(T[,] matrix, double[] control)
        {
            var res = new DataTable();
            res.Columns.Add("№ элемента", typeof(string));
            res.Columns.Add("Элемент массива", typeof(double));
            res.Columns.Add("Значение контрольной суммы", typeof(double));
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();
                row[0] = $"A[{i}]";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[1] = $"{matrix[i, j]:f5}";
                }
                row[2] = $"{control[i]:f4}";
                res.Rows.Add(row);
            }
            return res;
        }
    }
}
