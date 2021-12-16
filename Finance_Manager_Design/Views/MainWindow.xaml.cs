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
using Finance_Manager_Design.Models;

using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace Finance_Manager_Design
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Parce();
            data_picker.SelectedDate = DateTime.Today;
        }

        private void data_picker_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Select_Sort select_Sort = new Select_Sort();
            select_Sort.ShowDialog();
        }

        private void b_add_Click(object sender, RoutedEventArgs e)
        {
            Add_Purse add_Purse = new Add_Purse();
            add_Purse.ShowDialog();
        }

        private void b_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_add_k_Click(object sender, RoutedEventArgs e)
        {
            Add_Category add_Category = new Add_Category();
            add_Category.ShowDialog();
        }

        private void b_delete_k_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Add_Money add_Money = new Add_Money();
            add_Money.ShowDialog();
        }
    }
}
