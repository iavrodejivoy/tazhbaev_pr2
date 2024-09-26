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
    /// Логика взаимодействия для _4page.xaml
    /// </summary>
    public partial class _4page : Window
    {
        public _4page()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int N = int.Parse(inputRazmernost.Text);
            int[] allArray = new int[N];

            createdArray.Text = "";
            createdSortedArray.Text = "";

            for (int i = 0; i < N; i++)
            {
                allArray[i] = rand.Next(10, 100);

                createdArray.Text += $"{allArray[i]} ";
            }

            for (int i = 1, j = N - 2; i < j; i++, j--)
                (allArray[i], allArray[j]) = (allArray[j], allArray[i]);

            for (int i = 0; i < N; i++)
                createdSortedArray.Text += $"{allArray[i]} ";
        }
    }
}
