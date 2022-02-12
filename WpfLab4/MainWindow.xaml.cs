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

namespace WpfLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDollar=rateDollar*sumDollar;
            rasSum1.Text = Convert.ToString(resDollar);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            rasSum2.Text = Convert.ToString(resEuro);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rate3.Text);
            double sumGrivn = Convert.ToDouble(sum3.Text);
            double resGrivn = rateGrivn * sumGrivn;
            rasSum3.Text = Convert.ToString(resGrivn);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate4.Text);
            double sumDrama = Convert.ToDouble(sum4.Text);
            double resDrama = rateDrama * sumDrama;
            rasSum4.Text = Convert.ToString(resDrama);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double enterD=Convert.ToDouble(enter1.Text);
            rezult1.Text = Convert.ToString(enterD * 0.0254);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double enterF = Convert.ToDouble(enter2.Text);
            rezult2.Text = Convert.ToString(enterF * 0.03048);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double enterM = Convert.ToDouble(enter3.Text);
            rezult3.Text = Convert.ToString(enterM * 1609.344);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double enterV = Convert.ToDouble(enter4.Text);
            rezult4.Text = Convert.ToString(enterV * 1066.80);
        }
    }
}
