using System;
using System.Windows;
using System.Windows.Controls;
using LibraryForCoursework;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayC.xaml
    /// </summary>
    public partial class ArrayC : Page
    {
        readonly DataController controller = new();

        public ArrayC()
        {
            InitializeComponent();
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                controller.SetArrayC();
                double[] ArrC = new double[AllData.ArrayC.GetLength(0)];
                for (int i = 0; i < AllData.ArrayC.Length; i++)
                {
                    ArrC[i] = Math.Round(AllData.ArrayC[i, 0],AllData.K);
                }  
                ArrayCGrid.RowHeaderWidth = 0;
                ArrayCGrid.ItemsSource = FormirationDataGrid.ToDataTable(ArrC, "C").DefaultView;
            }
            catch
            {
                MessageBox.Show("Выполните заполнение массива B", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
