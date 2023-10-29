using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;

internal class SopstvenoVozilo
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual string? TipVozila { get; set; }
    internal protected virtual string? Boja { get; set; }
    internal protected virtual string? Marka { get; set; }
    internal protected virtual DateTime? DatumOd { get; set; }
    internal protected virtual DateTime? DatumDo { get; set; }

    internal protected virtual Vozac? PripadaVozacu { get; set; } 

    internal SopstvenoVozilo() 
    { 

    }
}
