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
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            KrvneGrupe.ItemsSource = Enum.GetValues(typeof(BloodType));
        }

        private void Unesi_Click(object sender, RoutedEventArgs e)
        {
            if (checkAge(Godine.Text) == true && checkBloodType() == true)
            {
                Donor d = new Donor(Ime.Text, Prezime.Text, int.Parse(Godine.Text), Pol.IsEnabled, (BloodType)KrvneGrupe.SelectedItem);
                DonoriEntities5 ctx = new DonoriEntities5();
                ctx.Donors.Add(d);
                ctx.SaveChanges();
                MessageBox.Show("Uspesno!");
                this.Close();
            }
            else { MessageBox.Show("Los unos"); }
        }

        public bool checkAge(string Age)
        {
            if (int.TryParse(Age, out int age))
            {
                if (age < 80 && age > 18)
                    return true;
                return false;
            }
            return false;
        }

        public bool checkBloodType()
        {
            if (KrvneGrupe.SelectedItem is null)
                return false;
            return true;
        }
    }
}
