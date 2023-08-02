namespace LibraryForCoursework
{
    /// <summary>
    /// Статический класс всех используемых данных
    /// </summary>
    public static class AllData
    {
        public static double I { get; set; } // Свойство используется в качетсве итерируемого слагаемого либо в качестве итерируемой переменной
        public static double E { get; set; } // Заданная точность
        public static double XInitial { get; set; } // Начальное значение X
        public static double XFinal { get; set; } // Конечное значение X
        public static double H { get; set; } // Шаг
        public static double G { get; set; } // Шаг №2
        public static double Sum { get; set; } // Сумма бесконечного ряда
        public static int LowerBound { get; set; } // Нижняя граница массива В
        public static int UpperBound { get; set; } // Верхняя граница массива В
        public static int K { get; set; } // Число округления E
        public static int Gk { get; set; } // Число округления G
        public static int Hk { get; set; } // Число округления H

        public static int LenghtA { get; set; } // Размерность массива А 
        public static double[,]? ArrayA { get; set; } // Массив A
        public static double[]? ArrayAControl { get; set; } // Массив A c значениями контрольной формулы
        public static double[,]? ArrayB { get; set; } // Массив B
        public static double[,]? ArrayC { get; set; } // Массив С
        public static double[]? ArrayY { get; set; } // Массив Y
        public static double[]? ArrayInterpolation { get; set; } // Массив интерполяции
        public static double[]? ArrayYSort { get; set; } // Массив Y

        static AllData(){
            E = 0.001;
            I = 0;
        }
    }
}
