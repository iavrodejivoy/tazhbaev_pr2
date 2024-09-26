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
using System.Windows.Shapes;

namespace tazhbaev_pr2.Pages
{
    /// <summary>
    /// Логика взаимодействия для _1page.xaml
    /// </summary>
    public partial class _1page : Window
    {
        public _1page()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(inputChislo.Text);

            int summa = 0, proizv = 1;
            int chislo;

            while (number > 0)
            {
                chislo = number % 10;
                summa += chislo;
                proizv *= chislo;
                number /= 10;
            }

            outputSumm.Text = $"Сумма цифр {summa}";
            outputProizvedenie.Text = $"Произведение цифр {proizv}";
        }
    }
}
