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

namespace Progress_Bars
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double[] wallets = new double[2]
            {
                30000000, //tenge [0]
                10, //Bitcoin [1]
            };

            double tengeToBit_Course = 3664693;

            double itemPrice = 20000000;
        }

        private void TengeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            itemBar.Value = tengeSlider.Value + bitSlider.Value;

            double allValues = tengeSlider.Value + bitSlider.Value;

            if (allValues > 100)
            {
                tengeSlider.Value = tengeSlider.Value - (allValues - 100);
            }
        }

        private void BitSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            itemBar.Value = tengeSlider.Value + bitSlider.Value;

            double allValues = tengeSlider.Value + bitSlider.Value;

            if (allValues > 100)
            {
                bitSlider.Value = bitSlider.Value - (allValues - 100);
            }
        }
    }
}
