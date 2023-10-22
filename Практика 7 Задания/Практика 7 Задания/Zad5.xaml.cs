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
using static System.Net.Mime.MediaTypeNames;

namespace Практика_7_Задания
{
    /// <summary>
    /// Логика взаимодействия для Zad5.xaml
    /// </summary>
    public partial class Zad5 : Window
    {
        public Zad5()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri("\\Back\\Les.jpg", UriKind.Relative));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri("\\Back\\Cats.jpg", UriKind.Relative));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri("\\Back\\sky.jpeg", UriKind.Relative));
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Image.Source = new BitmapImage(new Uri("\\Back\\roza.jpg", UriKind.Relative));
        }
    }
}
