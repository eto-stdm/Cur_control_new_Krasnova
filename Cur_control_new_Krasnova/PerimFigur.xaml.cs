using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cur_control_new_Krasnova
{
    /// <summary>
    /// Логика взаимодействия для PerimFigur.xaml
    /// </summary>
    public partial class PerimFigur : Page
    {
        /// <summary>
        /// Конструктор страницы
        /// </summary>
        public PerimFigur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сброс заполненных значений и очищение результата
        /// </summary>
        private void Clearing()
        {
            AnswerTB.Text = "Периметр = ";

            FirstSideTB.Clear();
            SecondSideTB.Clear();
            ThirdSideTB.Clear();
            RadiusTB.Clear();
        }

        /// <summary>
        /// Обработка выбора кнопки "Прямоугольник"
        /// </summary>
        private void RectRB_Checked(object sender, RoutedEventArgs e)
        {
            FirstSideTB.Visibility = Visibility.Visible;
            FirstSideText.Visibility = Visibility.Visible;
            SecondSideTB.Visibility = Visibility.Visible;
            SecondSideText.Visibility = Visibility.Visible;

            ThirdSideTB.Visibility = Visibility.Collapsed;
            ThirdSideText.Visibility = Visibility.Collapsed;
            RadiusTB.Visibility = Visibility.Collapsed;
            RadiusText.Visibility = Visibility.Collapsed;

            Clearing();
        }

        /// <summary>
        /// Обработка выбора кнопки "Круг"
        /// </summary>
        private void CircleRB_Checked(object sender, RoutedEventArgs e)
        {
            FirstSideTB.Visibility = Visibility.Collapsed;
            FirstSideText.Visibility = Visibility.Collapsed;
            SecondSideTB.Visibility = Visibility.Collapsed;
            SecondSideText.Visibility = Visibility.Collapsed;
            ThirdSideTB.Visibility = Visibility.Collapsed;
            ThirdSideText.Visibility = Visibility.Collapsed;

            RadiusTB.Visibility = Visibility.Visible;
            RadiusText.Visibility = Visibility.Visible;

            Clearing();
        }

        /// <summary>
        /// Обработка выбора кнопки "Треугольник"
        /// </summary>
        private void TriangRB_Checked(object sender, RoutedEventArgs e)
        {
            FirstSideTB.Visibility = Visibility.Visible;
            FirstSideText.Visibility = Visibility.Visible;
            SecondSideTB.Visibility = Visibility.Visible;
            SecondSideText.Visibility = Visibility.Visible;
            ThirdSideTB.Visibility = Visibility.Visible;
            ThirdSideText.Visibility = Visibility.Visible;

            RadiusTB.Visibility = Visibility.Collapsed;
            RadiusText.Visibility = Visibility.Collapsed;

            Clearing();
        }

        /// <summary>
        /// Обработка входящих значений и вычисление периметра прямоугольника
        /// </summary>
        /// <param name="x">Первая сторона прямоугольника</param>
        /// <param name="y">Вторая сторона прямоугольника</param>
        /// <returns>Успешность операции</returns>
        public bool CalculateRect(string x, string y)
        {

            if (x != "" && y != "")
            {
                if (x.Contains(".")) { x = x.Replace(".", ","); }
                if (y.Contains(".")) { y = y.Replace(".", ","); }

                bool xparce = double.TryParse(x, out var numx);
                bool yparce = double.TryParse(y, out var numy);

                if (xparce && yparce)
                {
                    if (numx > 0 && numy > 0)
                    {                    
                        double answer = 2 * (numx + numy);
                        AnswerTB.Text = "Периметр = " + answer;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Введено отрицательное число!"); return false;
                    }
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x, y!"); return false; }
        }

        /// <summary>
        /// Обработка входящих значений и вычисление периметра круга
        /// </summary>
        /// <param name="x">Радиус круга</param>
        /// <returns>Успешность операции</returns>
        public bool CalculateCircle(string x)
        {

            if (x != "")
            {
                if (x.Contains(".")) { x = x.Replace(".", ","); }

                bool xparce = double.TryParse(x, out var numx);

                if (xparce)
                {
                    if (numx > 0) {
                        double answer = 2 * Math.PI * numx;
                        AnswerTB.Text = "Периметр = " + answer;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Введено отрицательное число!"); return false;
                    }
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x!"); return false; }
        }

        /// <summary>
        /// Обработка входящих значений и вычисление периметра треугольника
        /// </summary>
        /// <param name="x">Первая сторона треугольника</param>
        /// <param name="y">Вторая сторона треугольника</param>
        /// <param name="z">Третья сторона треугольника</param>
        /// <returns>Успешность операции</returns>
        public bool CalculateTriang(string x, string y, string z)
        {

            if (x != "" && y != "" && z != "")
            {
                if (x.Contains(".")) { x = x.Replace(".", ","); }
                if (y.Contains(".")) { y = y.Replace(".", ","); }
                if (z.Contains(".")) { z = z.Replace(".", ","); }

                bool xparce = double.TryParse(x, out var numx);
                bool yparce = double.TryParse(y, out var numy);
                bool zparce = double.TryParse(y, out var numz);

                if (xparce && yparce && zparce)
                {
                    if (numx > 0 && numy > 0 && numz > 0)
                    {
                        double answer = numx + numy + numz;
                        AnswerTB.Text = "Периметр = " + answer;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Введено отрицательное число!"); return false;
                    }
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x, y, z!"); return false; }
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Вычислить"
        /// </summary>
        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RectRB.IsChecked == true)
            {
                CalculateRect(FirstSideTB.Text, SecondSideTB.Text);
            }

            if (CircleRB.IsChecked == true)
            {
                CalculateCircle(RadiusTB.Text);
            }

            if (TriangRB.IsChecked == true)
            {
                CalculateTriang(FirstSideTB.Text, SecondSideTB.Text, ThirdSideTB.Text);
            }
        }
    }
}
