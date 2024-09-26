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
using tazhbaev_pr2.Pages;

namespace tazhbaev_pr2
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

        private void FirstExampleButton_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = new _1page(); 
            myWindow.Show(); 
        }

        private void secondExampleButton_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = new _2page();
            myWindow.Show();
        }

        private void thirdExampleButton_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = new _3page();
            myWindow.Show();
        }

        private void fourthExampleButton_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = new _4page();
            myWindow.Show();
        }

        private void fivethExampleButton_Click(object sender, RoutedEventArgs e)
        {
            var myWindow = new _5page();
            myWindow.Show();
        }
    }
}
