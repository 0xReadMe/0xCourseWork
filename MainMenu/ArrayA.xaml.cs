using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using LibraryForCoursework;
using static LibraryForCoursework.AllData;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для ArrayA.xaml
    /// </summary>
    public partial class ArrayA : Page
    {
        readonly DataController controller = new();

        public ArrayA()
        {
            InitializeComponent();
            xInitial.Text = "-0,9";
            xFinal.Text = "0,9";
            hStep.Text = "0,1";
            epsilon.Text = "0,001";

            //запрет на ввод текстовых символов в TextBox
            xInitial.PreviewTextInput += new TextCompositionEventHandler(XInitial_PreviewTextInput);
            xFinal.PreviewTextInput += new TextCompositionEventHandler(XInitial_PreviewTextInput);
            hStep.PreviewTextInput += new TextCompositionEventHandler(eInitial_PreviewTextInput);
            epsilon.PreviewTextInput += new TextCompositionEventHandler(eInitial_PreviewTextInput);
        }

        public void CalculateSumSeries_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Math.Abs(Convert.ToDouble(xInitial.Text)) >= 1 || Math.Abs(Convert.ToDouble(xFinal.Text)) >= 1)
                {
                    MessageBox.Show("Проверьте правильность заполнения полей \n" +
                        "1) Значение x не должно быть больше или равно 1 или меньше или равно -1 \n" +
                        "2) Точность не должна быть меньше или равна 0 \n" +
                        "3) Шаг не должен быть меньше или равн 0",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else 
                {
                    InitializeData();
                    controller.SetArrayA();
                    if (AllData.ArrayA[0, 0] == 0 || AllData.ArrayA[0, 0] == 1)
                    {
                        xInitial.Text = xInitial.Text.Replace(",", ".");
                        xFinal.Text = xFinal.Text.Replace(",", ".");
                        hStep.Text = hStep.Text.Replace(",", ".");
                        epsilon.Text = epsilon.Text.Replace(",", ".");
                        InitializeData();
                        controller.SetArrayA();
                    }
                    outpuAarrayA.RowHeaderWidth = 0;
                    outpuAarrayA.ItemsSource = FormirationDataGrid.ToDataTableA(AllData.ArrayA, ArrayAControl).DefaultView;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность заполнения полей", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void InitializeData()
        {
            AllData.E = Convert.ToDouble(epsilon.Text);
            XInitial = Convert.ToDouble(xInitial.Text);
            XFinal = Convert.ToDouble(xFinal.Text);
            H = Convert.ToDouble(hStep.Text);
            int c = 0;
            for (double i = XInitial; Math.Round(i, 1) <= XFinal; i += H)
            {
                c++;
            }
            LenghtA = c;
            AllData.ArrayA = new double[LenghtA, 1];
            ArrayAControl = new double[LenghtA];
            AllData.ArrayB = new double[AllData.ArrayA.GetLength(0), AllData.ArrayA.GetLength(0)];
            AllData.ArrayC = new double[AllData.ArrayA.GetLength(0), 1];
            AllData.ArrayY = new double[AllData.ArrayA.GetLength(0)];
            K = 0;
            double E = AllData.E;
            while (E < 1)
            {
                E *= 10;
                K++;
            }
        }

        private void XInitial_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,.-".IndexOf(e.Text) < 0;
        }

        private void eInitial_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,.".IndexOf(e.Text) < 0;
        }
    }
}
