using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using LibraryForCoursework;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayB.xaml
    /// </summary>
    public partial class ArrayB : Page
    {
        readonly DataController controller = new();

        public ArrayB()
        {
            InitializeComponent();
            lowerBound.Text = "-25";
            upperBound.Text = "30";

            //запрет на ввод текстовых символов в TextBox
            lowerBound.PreviewTextInput += new TextCompositionEventHandler(LowerBound_PreviewTextInput);
            upperBound.PreviewTextInput += new TextCompositionEventHandler(LowerBound_PreviewTextInput);
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AllData.LowerBound = Convert.ToInt32(lowerBound.Text);
                AllData.UpperBound = Convert.ToInt32(upperBound.Text);
                controller.SetArrayB();
                ArrayBGrid.RowHeaderWidth = 0;
                ArrayBGrid.ItemsSource = FormirationDataGrid.ToDataTable(AllData.ArrayB).DefaultView;
            }
            catch
            {
                MessageBox.Show("Выполните заполнение массива A", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LowerBound_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "-0123456789".IndexOf(e.Text) < 0;
        }
    }
}
