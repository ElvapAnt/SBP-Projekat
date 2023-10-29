using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class Dodeljeno
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime? DatumDo { get; set; }
        public virtual TaxiVozilo TaxiVoziloId { get; set; }
        public virtual Vozac VozacId { get; set; }

    }
}
