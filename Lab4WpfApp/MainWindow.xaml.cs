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

namespace Lab4WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateDol.Text);
            double sumDollar = Convert.ToDouble(sumDol.Text);
            double resDollar = rateDollar * sumDollar;
            resSumDol.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateGrivn = Convert.ToDouble(rateGr.Text);
            double sumGrivn = Convert.ToDouble(sumGr.Text);
            double resGrivn = rateGrivn * sumGrivn;
            resSumGr.Text = resGrivn.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateEu.Text);
            double sumEuro = Convert.ToDouble(sumEu.Text);
            double resEuro = rateEuro * sumEuro;
            resSumEu.Text = resEuro.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateDr.Text);
            double sumDram = Convert.ToDouble(sumDr.Text);
            double resDram = rateDram * sumDram;
            resSumDr.Text = resDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double sumDu = Convert.ToDouble(sumD.Text);
            double resDu = 0.025 * sumDu;
            resSumD.Text = resDu.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double sumFu = Convert.ToDouble(sumF.Text);
            double resFu = 0.3 * sumFu;
            resSumF.Text = resFu.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double sumMi = Convert.ToDouble(sumM.Text);
            double resMi = 1609.34 * sumMi;
            resSumM.Text = resMi.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double sumVe = Convert.ToDouble(sumV.Text);
            double resVe = 1066.8 * sumVe;
            resSumV.Text = resVe.ToString();
        }
    }
}
