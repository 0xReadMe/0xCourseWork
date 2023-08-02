using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using LibraryForCoursework;

namespace MainMenu
{
    /// <summary>
    /// Логика взаимодействия для GraphC.xaml
    /// </summary>
    public partial class GraphC : Page
    {
        
        public GraphC()
        {
            InitializeComponent();

            #region Оси
            Line verticalLine = InitLine(40, 40, 0, 620);       //-|
            verticalLine.Stroke = Brushes.White;                // | Ось Y
            canvasGraph.Children.Add(verticalLine);             //-|

            Line horizontalLine = InitLine(40, 760, 310, 310);  //-|
            horizontalLine.Stroke = Brushes.White;              // | Ось X
            canvasGraph.Children.Add(horizontalLine);           //-|
            #endregion

            #region 0 на оси Y
            Label zero = InitLabel(15, 297, 0, 0, "0");
            canvasGraph.Children.Add(zero);
            #endregion

            #region Указатели
            // Верхний указатель
            Polyline vertArr = new()
            {
                Points = new PointCollection
                {
                    new Point(35, 10),
                    new Point(40, 0),
                    new Point(45, 10)
                },
                Stroke = Brushes.White
            };
            canvasGraph.Children.Add(vertArr);

            // Правый указатель
            Polyline rightArr = new()
            {
                Points = new PointCollection
                {
                    new Point(750, 305),
                    new Point(760, 310),
                    new Point(750, 315)
                },
                Stroke = Brushes.White
            };
            canvasGraph.Children.Add(rightArr);
            #endregion
        }

        private Line InitLine(double X1, double X2, double Y1, double Y2)
        {
            Line _ = new()
            {
                X1 = X1,
                Y1 = Y1,
                X2 = X2,
                Y2 = Y2
            };
            return _;
        }

        private Label InitLabel(double thickLeft, double thickTop, double thickRight, double thickBottom, string content) 
        {
            Label _ = new()
            {
                Foreground = Brushes.White,
                Margin = new Thickness(thickLeft, thickTop, thickRight, thickBottom),
                Content = content
            };
            return _;
        }

        private void PrintGraph_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                canvasGraph.Children.Clear();

                #region Оси
                Line verticalLine = InitLine(40, 40, 0, 620);       //-|
                verticalLine.Stroke = Brushes.White;                // | Ось Y
                canvasGraph.Children.Add(verticalLine);             //-|

                Line horizontalLine = InitLine(40, 760, 310, 310);  //-|
                horizontalLine.Stroke = Brushes.White;              // | Ось X
                canvasGraph.Children.Add(horizontalLine);           //-|
                #endregion

                #region 0 на оси Y
                Label zero = InitLabel(15, 297, 0, 0, "0"); ;
                canvasGraph.Children.Add(zero);
                #endregion

                #region Указатели
                // Верхний указатель
                Polyline vertArr = new()
                {
                    Points = new PointCollection
                    {
                        new Point(35, 10),
                        new Point(40, 0),
                        new Point(45, 10)
                    },
                    Stroke = Brushes.White
                };
                canvasGraph.Children.Add(vertArr);

                // Правый указатель
                Polyline rightArr = new()
                {
                    Points = new PointCollection
                    {
                        new Point(750, 305),
                        new Point(760, 310),
                        new Point(750, 315)
                    },
                    Stroke = Brushes.White
                };
                canvasGraph.Children.Add(rightArr);
                #endregion

                #region Начальные значения
                // График
                Polyline graph = new();
                Polyline graphSort = new();

                graph.Points = new PointCollection();
                graphSort.Points = new PointCollection();

                double edOtrX = 720 / AllData.ArrayA.Length;
                double edOtrY = 0;

                if (AllData.ArrayA.Length % 2 == 1)
                {
                    edOtrY = 620 / AllData.ArrayY.Length;
                }
                else
                {
                    edOtrY = 570 / AllData.ArrayY.Length;
                }
                #endregion

                #region Ось X

                //Сетка X
                for (int i = 0; i < AllData.ArrayA.Length; i++)
                {
                    Line a = InitLine(40 + i * edOtrX, 40 + i * edOtrX, 305, 315);
                    a.Stroke = Brushes.White;
                    canvasGraph.Children.Add(a);
                }

                //Координаты X
                for (int i = 1; i < AllData.ArrayA.Length; i++)
                {
                    Label a = InitLabel(33 + i * edOtrX, 315, 0, 0, $"{i}");
                    canvasGraph.Children.Add(a);
                }
                #endregion

                #region Ось Y

                double yExtreme = 0; // 0 на оси Y

                if (Math.Abs(AllData.ArrayYSort[0]) >= Math.Abs(AllData.ArrayYSort[^1]))
                {
                    yExtreme = AllData.ArrayYSort[0];
                }
                else
                {
                    yExtreme = AllData.ArrayYSort[^1];
                }
                double temp = (yExtreme / (AllData.ArrayYSort.Length / 2)) / AllData.G;   // Рассчет коордитнат

                // Сетка Y
                // Выше 0
                for (int i = 0; i < AllData.ArrayY.Length / 2; i++)
                {
                    //Отрисовка резок
                    Line s = InitLine(35, 45, -edOtrY + 310 - i * edOtrY, -edOtrY + 310 - i * edOtrY);
                    s.Stroke = Brushes.White;
                    canvasGraph.Children.Add(s);

                    //Отрисовка чисел
                    Label kr = InitLabel(-30, s.Y1 - 15, s.X2, s.Y2, $"{Math.Abs(yExtreme - temp * ((AllData.ArrayY.Length / 2) - (i + 1))):f0}");
                    canvasGraph.Children.Add(kr);
                }

                // Ниже 0
                for (int i = 0; i < AllData.ArrayY.Length / 2; i++)
                {
                    //Отрисовка резок
                    Line s = InitLine(35, 45, edOtrY + 310 + i * edOtrY, edOtrY + 310 + i * edOtrY);
                    s.Stroke = Brushes.White;
                    canvasGraph.Children.Add(s);

                    //Отрисовка чисел
                    Label kr = InitLabel(-30, s.Y1 - 15, 0, 0, $"-{Math.Abs(yExtreme - temp * ((AllData.ArrayY.Length / 2) - (i + 1))):f0}");
                    canvasGraph.Children.Add(kr);
                }
                #endregion

                #region График

                double xStart = 40;

                if (AllData.ArrayInterpolation[0] < 0)
                {
                    for (int i = 0; i < AllData.ArrayInterpolation.Length; i++)
                    {
                        double pointX = xStart + (edOtrX * AllData.G) * i;                                  // смещение по X
                        double pointY = 310 - ((AllData.ArrayInterpolation[i] * 285) / yExtreme);           // Y не сортированный
                        graph.Points.Add(new Point(pointX, pointY));
                        double pointYSort = 310 - ((AllData.ArrayYSort[i] * 285) / yExtreme);               // Y  сорт
                        graphSort.Points.Add(new Point(pointX, pointYSort));
                    }
                }
                if (AllData.ArrayInterpolation[0] >= 0)
                {
                    for (int i = 0; i < AllData.ArrayInterpolation.Length; i++)
                    {
                        double pointX = xStart + (edOtrX * AllData.G) * i;                                  // смещение по X
                        double pointY = 310 + ((AllData.ArrayInterpolation[i] * 285) / yExtreme);           // Y не сортированный
                        graph.Points.Add(new Point(pointX, pointY));
                        double pointYSort = 310 + ((AllData.ArrayYSort[i] * 285) / yExtreme);               // Y  сорт
                        graphSort.Points.Add(new Point(pointX, pointYSort));
                    }
                }

                graph.Stroke = Brushes.GreenYellow;  // Y не сортированный
                canvasGraph.Children.Add(graph);
                graphSort.Stroke = Brushes.Red; // Y  сорт
                canvasGraph.Children.Add(graphSort);
                #endregion
            }
            catch
            {
                MessageBox.Show("Выполните заполнение массива Y и отсортируйте его", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}