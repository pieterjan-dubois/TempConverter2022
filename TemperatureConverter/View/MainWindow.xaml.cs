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

namespace View
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

        private void convertToCelsius(object sender, RoutedEventArgs e)
        {
            String fahr = textBoxF.Text;
            double fahrInt = double.Parse(fahr);
            double celsiusAfterConv = (fahrInt - 32) / 1.8;
            string celsiusString = celsiusAfterConv.ToString(); 
            textBoxF.Text = celsiusString; 
           // MessageBox.Show(this, fahr, "Clicked!");
            
        }

        private void convertToFahrenheit(object sender, RoutedEventArgs e)
        {
            String celsius = textBoxC.Text;
            double celsInt = double.Parse(celsius);
            double fahrAfterConv = (celsInt * 1.8) + 32;
            string fahrString = fahrAfterConv.ToString();
            textBoxC.Text = fahrString;
        }
    }
}
