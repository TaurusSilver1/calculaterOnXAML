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
using System.IO;

namespace calculateOnXaml
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock textBlock = new TextBlock();
        }

        double a, b;
        char c;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBlock textBlock = new TextBlock();
            textBox1.Text += "1";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '+';
            textBox1.Text = "";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "4";

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "5";

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "6";

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "8";

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "9";

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "0";

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ",";

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            a = 0;
            b = 0;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (c)
            {
                case '+':
                    textBox1.Text = Convert.ToString(a + b);
                    break;

                case '-':
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '-';
            textBox1.Text = "";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '*';
            textBox1.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '/';
            textBox1.Text = "";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (c == '*')
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(a*b/100 );
            }
            else if(c == '+')
            {
                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(a + (a * (b/100)));
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(System.Math.Pow(a, 2));
        }

        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        
    }
}
