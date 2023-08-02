using LibraryForCoursework;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayY.xaml
    /// </summary>
    public partial class ArrayY : Page
    {
        readonly DataController controller = new();

        public ArrayY()
        {
            InitializeComponent();

            //запрет на ввод текстовых символов в TextBox
            StepG.PreviewTextInput += new TextCompositionEventHandler(StepG_PreviewTextInput); 
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AllData.G = Convert.ToDouble(StepG.Text);
                controller.SetArrayY();
                ArrayYGrid.RowHeaderWidth = 0;
                ArrayYGrid.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayInterpolation, "Y").DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выполните заполнение массива C", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                MessageBox.Show($"{ex}");
            }
        }
        private void SortArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[] _localArrayY = new double[AllData.ArrayInterpolation.Length];
                AllData.ArrayInterpolation.CopyTo(_localArrayY, 0);
                AllData.ArrayYSort = controller.Sort(_localArrayY);
                ArrayYGridSort.RowHeaderWidth = 0;
                ArrayYGridSort.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayYSort, "Ys").DefaultView;
            }
            catch
            {
                MessageBox.Show("Выполните заполнение массива Y", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void StepG_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,.".IndexOf(e.Text) < 0;
        }
    }
}
