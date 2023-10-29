using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public abstract class Zaposleni //abstract je jer ne moze da postoji samo zaposleni, ili je vozac ili administrator
    {
        public virtual string Jmbg { get; set; } //ovda nema protected za set jer se rucno unosi jmbg
        public virtual string Ime { get; set; }
        public virtual char SrednjeSlovo { get; set; } 
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string TipZaposleni { get; set; }

        //public virtual IList<Voznja> Voznje { get; set; } //veza OneToMany sa Voznjom - prebaceno u podklasu
        //public virtual IList<SopstvenoVozilo> SopstvenaVozila { get; set; } //veza OneToMany sa SopstvenimVozilima - prebaceno u podklasu

        public Zaposleni() 
        {
            //Voznje = new List<Voznja>();
            //SopstvenaVozila = new List<SopstvenoVozilo>();
        }
    }
}
