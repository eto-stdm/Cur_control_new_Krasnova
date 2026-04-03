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
        public PerimFigur()
        {
            InitializeComponent();
        }

        private void Clearing()
        {
            AnswerTB.Text = "Периметр = ";

            FirstSideTB.Clear();
            SecondSideTB.Clear();
            ThirdSideTB.Clear();
            RadiusTB.Clear();
        }

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
                    double answer = 2 * (numx + numy);
                    AnswerTB.Text = "Периметр = " + answer;
                    return true;
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x, y!"); return false; }
        }

        public bool CalculateCircle(string x)
        {

            if (x != "")
            {
                if (x.Contains(".")) { x = x.Replace(".", ","); }

                bool xparce = double.TryParse(x, out var numx);

                if (xparce)
                {
                    double answer = 2 * Math.PI * numx;
                    AnswerTB.Text = "Периметр = " + answer;
                    return true;
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x!"); return false; }
        }

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
                    double answer = numx + numy + numz;
                    AnswerTB.Text = "Периметр = " + answer;
                    return true;
                }
                else { MessageBox.Show("Введено не число!"); return false; }
            }
            else { MessageBox.Show("Заполните x, y, z!"); return false; }
        }

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
