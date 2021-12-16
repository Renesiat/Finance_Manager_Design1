using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Finance_Manager_Design
{
    /// <summary>
    /// Логика взаимодействия для Select_Sort.xaml
    /// </summary>
    public partial class Select_Sort : Window
    {
        private Calendar calendar;
        public Select_Sort()
        {
            InitializeComponent();
        }

        private void b_day_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void b_week_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void b_month_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void b_year_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void b_all_time_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();
        }

        private void b_range_Click(object sender, RoutedEventArgs e)
        {
            calendar = new Calendar();
            calendar.ShowDialog();

        }
    }
}
