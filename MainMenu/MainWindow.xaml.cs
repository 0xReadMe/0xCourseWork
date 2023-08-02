using LibraryForCoursework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MainMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly List<Page> list;
        readonly DataController dataController = new();

        public MainWindow()
        {
            InitializeComponent();
            list = new List<Page>
            {
                new ArrayA(),
                new ArrayB(),
                new ArrayC(),
                new ArrayY(),
                new GraphC(),
                new TextResult()
            };
        }

        private void ArrayA_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[0];
        }

        private void ArrayB_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[1];
        }

        private void ArrayC_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[2];
        }
        private void ArrayY_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[3];
        }

        private void GraphC_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[4];
        }

        private void TextResult_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[5];
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            dataController.OpenToFile();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Предупреждение", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("До свидания!", "Предупреждение");
                    Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }          
        }      

        private void Minimized(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void ToolBar(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            } 
        }

        private void Fullscreen(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            string executePath = Environment.CurrentDirectory; // директория исполняемого файла
            string path = executePath + @"\help4.chm"; // путь к файлу

            if (Process.GetProcessesByName("hh").Count() == 0) 
            {
                Process.Start(new ProcessStartInfo(path) 
                { 
                    UseShellExecute = true
                });
            }
            
        }

        private void MenuNavigation_MouseEnter(object sender, MouseEventArgs e)
        {
            ArrayA.Content = "Массив А";
            ArrayB.Content = "Массив B";
            ArrayC.Content = "Массив C";
            ArrayY.Content = "Массив Y";
            GraphC.Content = "График";
            TextResult.Content = "Результат";
            Open.Content = "Открыть файл";
            Exit.Content = "Выход";
        }

        private void MenuNavigation_MouseLeave(object sender, MouseEventArgs e)
        {
            ArrayA.Content = "А";
            ArrayB.Content = "B";
            ArrayC.Content = "C";
            ArrayY.Content = "Y";
            GraphC.Content = "Граф";
            TextResult.Content = "Рез";
            Open.Content = "Файл";
            Exit.Content = "Выход";
        }
    }
}
