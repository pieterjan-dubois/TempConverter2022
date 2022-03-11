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

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            var celsiusString = celsiusTextBox.Text;
            var celsius = double.Parse(celsiusString);
            double celsiusToKevin = celsius + 273.15;
            double celsiusToFahrenheit = (celsius * 1.8) +32;
            var kevinString = celsiusToKevin.ToString();
            var fahrString = celsiusToFahrenheit.ToString();
            fahrenheitTextBox.Text = fahrString;
            kelvinTextBox.Text = kevinString;
        }
        private void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            var fahrenheitString = fahrenheitTextBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            double fahrenheitToCelsius = (fahrenheit - 32) / 1.8;
            double fahrenheitToKelvin = (fahrenheit - 32) / 1.8 + 273.15;
            var celsiusString = fahrenheitToCelsius.ToString();
            var kelvinString = fahrenheitToKelvin.ToString();
            celsiusTextBox.Text = celsiusString;
            kelvinTextBox.Text =kelvinString;
        }   

        private void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            var kelvinString = kelvinTextBox.Text;
            var kelvin = double.Parse(kelvinString);
            double kelvinToCelsius = kelvin - 273.15;
            double kelvinToFahrenheit = kelvin * 1.8 - 459.67;
            var celsiusString = kelvinToCelsius.ToString();
            var fahrString = kelvinToFahrenheit.ToString();
            fahrenheitTextBox.Text = fahrString;

            celsiusTextBox.Text = celsiusString;


        }
    }
}
