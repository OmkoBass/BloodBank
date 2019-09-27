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

namespace BloodBank
{
    public partial class Find : Window
    {
        public Find()
        {
            InitializeComponent();
            KrvneGrupe.ItemsSource = Enum.GetValues(typeof(BloodType));
        }

        private void KrvneGrupe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DonoriEntities5 ctx = new DonoriEntities5();

            var x = ctx.Donors.ToList();

            var Query = from Donor in x
                        where Donor.KrvnaGrupa == (int)KrvneGrupe.SelectedItem
                        select Donor;

            Data.ItemsSource = Query;
        }
    }
}
