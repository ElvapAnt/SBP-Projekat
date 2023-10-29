using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class Vozac : Zaposleni
    {
        public virtual char Kategorija { get; set; }
        public virtual string BrojDozovole { get; set; }

        public virtual IList<Voznja> Voznje { get; set; } //veza OneToMany sa Voznjom

        public virtual IList<SopstvenoVozilo> SopstvenaVozila { get; set; } //veza OneToMany sa SopstvenimVozilima GRESKA ILI NIJE VIDECEMO

        public virtual IList<TaxiVozilo> TaxiVozila { get; set; } //veza ManyToMany sa Vozacem

        public Vozac() {
            this.TipZaposleni = "Vozac";
            Voznje = new List<Voznja>();
            SopstvenaVozila = new List<SopstvenoVozilo>();
            TaxiVozila = new List<TaxiVozilo>();
        }
    }
}
