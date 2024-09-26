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
    /// Логика взаимодействия для _5page.xaml
    /// </summary>
    public partial class _5page : Window
    {
        public _5page()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            int M = int.Parse(Mcount.Text);
            int N = int.Parse(Ncount.Text);
            int[,] array = new int[N, M];
            Random random = new Random();
            int min = 10, max = -10;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = random.Next(-10, 11);

                    if (array[i, j] < min)
                        min = array[i, j];

                    if (array[i, j] > max)
                        max = array[i, j];
                }

            minCount.Text = "";
            minCount.Text += Convert.ToString(min);
            maxCount.Text = "";
            maxCount.Text += Convert.ToString(max);

            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    if (array[i, 0] > array[j, 0]) 
                        for (int k = 0; k < M; k++)
                            (array[i, k], array[j, k]) = (array[j, k], array[i, k]);

            ascSorted.Text = "";
            descSorted.Text = "";

            for (int i = 0; i < N; i++, ascSorted.Text += "\n")
                for (int j = 0; j < M; j++)
                    ascSorted.Text += $"{array[i, j]} ";

            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    if (array[i, 0] < array[j, 0])
                        for (int k = 0; k < M; k++)
                            (array[i, k], array[j, k]) = (array[j, k], array[i, k]);

            for (int i = 0; i < N; i++, descSorted.Text += "\n")
                for (int j = 0; j < M; j++)
                    descSorted.Text += $"{array[i, j]} ";
        }
    }
}
