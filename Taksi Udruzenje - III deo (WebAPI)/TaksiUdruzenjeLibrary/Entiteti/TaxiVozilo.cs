using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;

internal class TaxiVozilo
{
    internal protected virtual string RegistarskaOznaka { get; set; }
    internal protected virtual string? Marka { get; set; }
    internal protected virtual string? Tip { get; set;}
    internal protected virtual DateTime? DatumIstekaRegistracije { get; set;}
    internal protected virtual int? GodinaProizvodnje { get; set; }

    internal protected virtual IList<Vozac>? Vozaci { get; set; } //veza ManyToMany sa TaxiVozilima

    internal TaxiVozilo()
    {
        Vozaci = new List<Vozac>();
    }
}

