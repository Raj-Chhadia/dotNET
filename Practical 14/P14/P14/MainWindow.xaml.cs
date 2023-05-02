using System;
using System.Windows;


namespace P14
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
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double result = num1 + num2;
            txt3.Text = result.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double result = num1 - num2;
            txt3.Text = result.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double result = num1 * num2;
            txt3.Text = result.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double result = num1 / num2;
            txt3.Text = result.ToString();
        }

    }
}
