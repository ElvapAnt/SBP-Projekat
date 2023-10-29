using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class RedovnaMusterija
    {
        public virtual int Id { get; protected set; }
        public virtual string Adresa { get; set; }
        public virtual int BrojKoriscenihVoznji { get; set; }
        //public virtual float Popust { get; set; } //izvedeni atribut, nema ga u bazi
        
        public virtual IList<Voznja> Voznje { get; set; } //veza OneToMany sa Voznjom
        public virtual IList<BrojTelefona> BrojeviTelefona { get; set; } //veza OneToMany sa tabelom (visevrednosnim atributom) BrojTelefona

        public RedovnaMusterija() 
        {
            Voznje = new List<Voznja>();
            BrojeviTelefona = new List<BrojTelefona>();
        }

    }
}
