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
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
