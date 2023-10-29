using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class SopstvenoVozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string TipVozila { get; set; }
        public virtual string Boja { get; set; }
        public virtual string Marka { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; } //? jer je nullable tj DatumDo moze biti null

        public virtual Vozac PripadaVozacu { get; set; } //Ovde je OneToMany veza sa VOZAC

        public SopstvenoVozilo() 
        { 

        }
    }
}
