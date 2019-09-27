//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BloodBank
{
    using System;
    using System.Collections.Generic;
    public enum BloodType
    {
        Ominus = 0,
        Oplus = 1,
        Aminus = 2,
        Aplus = 3,
        Bminus = 4,
        Bplus = 5,
        ABminus = 6,
        ABplus = 7,
    }
    public partial class Donor
    {
        public int id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Nullable<int> Godine { get; set; }
        public Nullable<bool> Pol { get; set; }
        public Nullable<int> KrvnaGrupa { get; set; }

        public Donor()
        {

        }

        public Donor(string Name, string LastName, int Age, bool IsMale, BloodType Blood)
        {
            this.Ime = Name;
            this.Prezime = LastName;
            this.Godine = Age;
            this.Pol = IsMale;
            this.KrvnaGrupa = (int)Blood;
            this.id = id + 1;
        }
        public override string ToString()
        {
            string pol;
            if (Pol == true)
                pol = "Musko";
            pol = "Zensko";
            return $"********************\n{this.Ime}-{this.Prezime}\n********************\n{this.Godine}-{pol}\n********************\nKrvna Grupa:{this.KrvnaGrupa}";
        }
    }
}
