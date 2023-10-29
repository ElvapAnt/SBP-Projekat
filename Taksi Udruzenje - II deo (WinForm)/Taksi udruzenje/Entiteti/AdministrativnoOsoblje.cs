using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class AdministrativnoOsoblje : Zaposleni
    {
        public virtual string StrucnaSprema { get; set; }

        public virtual IList<Voznja> Voznje { get; set; } //veza OneToMany sa Voznjom

        public AdministrativnoOsoblje()
        {
            this.TipZaposleni = "Admin";
            Voznje = new List<Voznja>();
        }
    }
}
