using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
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

        private void num1(object sender, RoutedEventArgs e)
        {
            input.Text += "1";
        }

        private void num2(object sender, RoutedEventArgs e)
        {
            input.Text += "2";
        }

        private void num3(object sender, RoutedEventArgs e)
        {
            input.Text += "3";
        }

        private void delenie(object sender, RoutedEventArgs e)
        {
            input.Text += "/";
        }

        private void Ac(object sender, RoutedEventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }

        private void num4(object sender, RoutedEventArgs e)
        {
            input.Text += "4";
        }

        private void num5(object sender, RoutedEventArgs e)
        {
            input.Text += "5";
        }

        private void num6(object sender, RoutedEventArgs e)
        {
            input.Text += "6";
        }

        private void umnoj(object sender, RoutedEventArgs e)
        {
            input.Text += "*";
        }

        private void C(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text.Substring(0, input.Text.Length - 1);
        }

        private void num7(object sender, RoutedEventArgs e)
        {
            input.Text += "7";
        }

        private void num8(object sender, RoutedEventArgs e)
        {
            input.Text+="8";
        }

        private void num9(object sender, RoutedEventArgs e)
        {
            input.Text+="9";
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            input.Text+="+";
        }

        private void rovno(object sender, RoutedEventArgs e)
        {
            string expression = input.Text;
            DataTable dt= new DataTable();
            var res = dt.Compute(expression, "");
            output.Text = res.ToString();
        }

        private void num0(object sender, RoutedEventArgs e)
        {
            input.Text+="0";
        }

        private void zapya(object sender, RoutedEventArgs e)
        {
            input.Text+=",";
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            input.Text+="-";
        }
    }
}
