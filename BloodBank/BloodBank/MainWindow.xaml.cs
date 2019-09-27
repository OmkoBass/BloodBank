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

namespace BloodBank
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DonoriEntities5 ctx = new DonoriEntities5();

            var x = ctx.Donors.ToList();

            Data.ItemsSource = x;
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            Find f = new Find();
            f.ShowDialog();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            DonoriEntities5 ctx = new DonoriEntities5();

            var x = ctx.Donors.ToList();

            Data.ItemsSource = null;
            Data.ItemsSource = x;
        }
    }
}
