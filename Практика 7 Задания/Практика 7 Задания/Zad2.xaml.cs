using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для Zad2.xaml
    /// </summary>
    public partial class Zad2 : Window
    {
        public Zad2()
        {
            InitializeComponent();
        }

        private void menuItemAdd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавить");
        }

        private void menuItemDel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
        }

        private void menuItemMove_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Переслать");
        }

        private void Message_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show(menuItem.Header.ToString());
        }

        private void menuItemNone_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string text = menuItem.Header.ToString();
            switch (text)
            {
                case "Пусто":
                    sl.TickPlacement = TickPlacement.None;
                    break;
                case "Сверху-слева":
                    sl.TickPlacement = TickPlacement.TopLeft;
                    break;
                case "Снизу-справа":
                    sl.TickPlacement = TickPlacement.BottomRight;
                    break;
                case "С обеих сторон":
                    sl.TickPlacement = TickPlacement.Both;
                    break;
            }
            foreach (MenuItem item1 in sl.ContextMenu.Items)
            {
                string name = Convert.ToString(item1.Header);
                if (name == text)
                    item1.IsChecked = true;
                else
                    item1.IsChecked = false;
            }
            foreach (MenuItem item2 in menuItemTrackBar.Items)
            {
                string name = Convert.ToString(item2.Header);
                if (name == text)
                    item2.IsChecked = true;
                else
                    item2.IsChecked = false;
            }
        }

        private void PozVertical_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mn = (MenuItem)sender;
            string Orin = mn.Header.ToString();
            switch (Orin)
            {
                case "Горизонтальная":
                    sl.Orientation = Orientation.Horizontal;
                    sl.Height = 30;
                    sl.Width = 200;
                    break;
                case "Вертикальная":
                    sl.Orientation = Orientation.Vertical;
                    sl.Height = 100;
                    sl.Width = 30;
                    break;
            }
            foreach (MenuItem item1 in OrientM.Items)
            {
                string name = Convert.ToString(item1.Header);
                if (name == Orin)
                    item1.IsChecked = true;
                else
                    item1.IsChecked = false;
            }
            foreach (MenuItem item2 in OrientC.Items)
            {
                string name = Convert.ToString(item2.Header);
                if (name == Orin)
                    item2.IsChecked = true;
                else
                    item2.IsChecked = false;
            }
        }
    }
}