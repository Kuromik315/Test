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

namespace Практика_7_Задания
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

        private void Zad1_Click(object sender, RoutedEventArgs e)
        {
            Zad1 zd1 = new Zad1();
            zd1.Show();
        }

        private void Zad2_Click(object sender, RoutedEventArgs e)
        {
            Zad2 zd2 = new Zad2();
            zd2.Show();
        }

        private void Zad3_Click(object sender, RoutedEventArgs e)
        {
            Zad3 zd3 = new Zad3();
            zd3.Show();
        }

        private void Zad4_Click(object sender, RoutedEventArgs e)
        {
            Zad4 zd4 = new Zad4();
            zd4.Show();
        }

        private void Zad5_Click(object sender, RoutedEventArgs e)
        {
            Zad5 zd5 = new Zad5();
            zd5.Show();
        }
    }
}
