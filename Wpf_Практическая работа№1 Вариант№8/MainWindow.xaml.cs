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

namespace Wpf_Практическая_работа_1_Вариант_8
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

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Button2.IsEnabled = false;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = false;
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Button3.IsEnabled = false;
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button4.IsEnabled = false;
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Button5.IsEnabled = false;
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Button6.IsEnabled = false;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Button1.IsEnabled = true;
            Button2.IsEnabled = true;
            Button3.IsEnabled = true;
            Button4.IsEnabled = true;
            Button5.IsEnabled = true;
            Button6.IsEnabled = true;
        }
    }
}
