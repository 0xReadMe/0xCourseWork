using System;
using System.Windows;
using System.Windows.Controls;
using LibraryForCoursework;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для TextResult.xaml
    /// </summary>
    public partial class TextResult : Page
    {
        readonly DataController dataController = new();

        public TextResult()
        {
            InitializeComponent(); 
        }

        private void PrintResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Text += "Массив A: \n";
                for (int j = 0; j < AllData.ArrayA.Length; j++)
                {
                    Result.Text += $"A[{j}] = {Convert.ToString(AllData.ArrayA[j, 0])} \n";
                }
                Result.Text += "Массив B: \n";
                for (int i = 0; i < AllData.ArrayB.GetLength(0); i++)
                {
                    for (int j = 0; j < AllData.ArrayB.GetLength(0); j++) 
                    {
                        Result.Text += $"{Convert.ToString(AllData.ArrayB[i, j])}   ";
                    } 
                    Result.Text += $"\n";
                }
                Result.Text += "Массив C: \n";
                for (int j = 0; j < AllData.ArrayC.Length; j++)
                {
                    Result.Text += $"C[{j}] = {Convert.ToString(AllData.ArrayC[j, 0])} \n";
                }   
                Result.Text += "Массив Y: \n";
                for (int j = 0; j < AllData.ArrayY.Length; j++)
                {
                    Result.Text += $"C[{j}] = {Convert.ToString(AllData.ArrayY[j])} \n";
                }
                Result.Text += "Отсортированный массив Y: \n";
                for (int j = 0; j < AllData.ArrayYSort.Length; j++)
                {
                    Result.Text += $"C[{j}] = {Convert.ToString(AllData.ArrayYSort[j])} \n";
                }     
            }
            catch
            {
                MessageBox.Show("Выполните заполнение массива Y и отсортируйте его", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveResult_Click(object sender, RoutedEventArgs e)
        {
            dataController.SaveToFile(Result.Text);
            MessageBox.Show("Реузультат сохранён успешно!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}