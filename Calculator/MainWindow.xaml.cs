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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string output;
        private int firstDigit;
        private int secondDigit;
        private int currentDigit = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            output += "1";
            updateUI();
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            output += "2";
            updateUI();
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            output += "3";
            updateUI();
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            output += "4";
            updateUI();
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            output += "5";
            updateUI();
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            output += "6";
            updateUI();
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            output += "7";
            updateUI();
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            output += "8";
            updateUI();
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            output += "9";
            updateUI();
        }
        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            output += "0";
            updateUI();
        }
        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            output += "+";
            updateUI();
        }

        public void updateUI()
        {
            outputBlock.Text = output;
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
