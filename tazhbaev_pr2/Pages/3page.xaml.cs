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
    /// Логика взаимодействия для _3page.xaml
    /// </summary>
    public partial class _3page : Window
    {
        public _3page()
        {
            InitializeComponent();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            int N = int.Parse(inputRazmer.Text);
            int[] allArray = new int[N];

            outputUnsortArray.Text = "";
            outputSortArray.Text = "";

            for (int i = 0; i < N; i++)
            {
                allArray[i] = rand.Next(10, 101);

                outputUnsortArray.Text += $"{allArray[i]} ";

                if (allArray[i] % 2 == 0)
                    outputSortArray.Text += $"{allArray[i]} ";
            }

            for (int i = 0; i < N; i++)
                if (allArray[i] % 2 != 0)
                    outputSortArray.Text += $"{allArray[i]} ";

        }
    }
}
