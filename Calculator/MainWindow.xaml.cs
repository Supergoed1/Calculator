using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double value;
        String operation;
        bool isOperationPerformed;
        bool isCalCompleted;

        public MainWindow()
        {
            InitializeComponent();
            outputBlock.Text = "0";
            prevAction.Content = "";
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if (isCalCompleted)
            {
                clearAllButton_Click(sender, e);
                isCalCompleted = false;
            }
            if (outputBlock.Text == "0")
                outputBlock.Text = "";
            Button btn = (Button)sender;
            outputBlock.Text += btn.Content;
        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(isCalCompleted)
            {
                isCalCompleted = false;
                Double.TryParse(outputBlock.Text, out value);
                outputBlock.Text = "0";
                if (btn.Content.ToString().Equals("%")) prevAction.Content = value + "% of ";
                else
                    prevAction.Content = value + " " + btn.Content.ToString().Replace('X', '*');
                isOperationPerformed = true;
                operation = btn.Content.ToString();
                return;
            }
            if (isOperationPerformed)
                equalsButton_Click(sender, e);
            if(Double.TryParse(outputBlock.Text, out value)) {
                isCalCompleted = false;
                outputBlock.Text = "0";
                if (btn.Content.ToString().Equals("%")) prevAction.Content = value + "% of "; else
                    prevAction.Content = value + " " +btn.Content.ToString().Replace('X','*');
                isOperationPerformed = true;
                operation = btn.Content.ToString();
                return;
            }
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            Double currentValue = Double.Parse(outputBlock.Text);
            switch(operation)
            {
                case "+":
                    outputBlock.Text = (value + currentValue).ToString();
                    break;
                case "-":
                    outputBlock.Text = (value - currentValue).ToString();
                    break;
                case "X":
                    outputBlock.Text = (value * currentValue).ToString();
                    break;
                case "/":
                    outputBlock.Text = (value / currentValue).ToString();
                    break;
                case "%":
                    outputBlock.Text = ((value / 100) * currentValue).ToString();
                    break;
            }
            if(operation.Equals("%"))
            {
                prevAction.Content = value + "% of " + currentValue + " = " + outputBlock.Text;
                return;
            }
            prevAction.Content = value + " " + operation.Replace('X','*') + " " + currentValue + " = " + outputBlock.Text;
            isCalCompleted = true;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            outputBlock.Text = "0";
        }

        private void clearAllButton_Click(object sender, RoutedEventArgs e)
        {
            outputBlock.Text = "0";
            prevAction.Content = "";
            isOperationPerformed = false;
            operation = "";
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            if(!outputBlock.Text.Contains("."))
            {
                outputBlock.Text += ".";
            }
        }

        private void switchButton_Click(object sender, RoutedEventArgs e)
        {
            if(!outputBlock.Text.Contains("-"))
            {
                outputBlock.Text = String.Format("{0}" + outputBlock.Text, "-");
                return;
            }
            outputBlock.Text = outputBlock.Text.Replace("-", "");
        }
    }
}
