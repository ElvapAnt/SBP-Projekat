using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class TaxiVozilo
    {
        public virtual string RegistarskaOznaka { get; set; }
        public virtual string Marka { get; set; }
        public virtual string Tip { get; set;}
        public virtual DateTime DatumIstekaRegistracije { get; set;}
        public virtual int GodinaProizvodnje { get; set; }

        public virtual IList<Vozac> Vozaci { get; set; } //veza ManyToMany sa TaxiVozilima

        public TaxiVozilo()
        {
            Vozaci = new List<Vozac>();
        }
    }
}
