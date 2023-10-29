using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;
internal class Dodeljeno
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual DateTime? DatumOd { get; set; }
    internal protected virtual DateTime? DatumDo { get; set; }
    internal protected virtual TaxiVozilo? TaxiVozilo { get; set; }
    internal protected virtual Vozac? Vozac { get; set; }

}
