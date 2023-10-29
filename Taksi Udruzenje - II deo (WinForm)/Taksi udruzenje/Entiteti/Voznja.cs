using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class Voznja
    {
        public virtual int Id { get; protected set; }
        public virtual string PocetnaStanica { get; set; }
        public virtual string KrajnjaStanica { get; set; }
        public virtual DateTime PocetnoVreme { get; set; }
        public virtual DateTime KrajnjeVreme { get; set; }
        public virtual string BrojPoziva { get; set; }
        public virtual DateTime VremePrimPoziva { get; set; }

        public virtual RedovnaMusterija PripadaRedovnojMusteriji { get; set; }
        public virtual Vozac PripadaVozacu { get; set; }
        public virtual AdministrativnoOsoblje PripadaAdministrativnomOsoblju { get; set; }
        public Voznja()
        {

        }
    }
}
