using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;
internal class Vozac : Zaposleni
{
    internal protected virtual char? Kategorija { get; set; }
    internal protected virtual string? BrojDozovole { get; set; }
    internal protected virtual IList<Voznja>? Voznje { get; set; } 
    internal protected virtual IList<SopstvenoVozilo>? SopstvenaVozila { get; set; } 
    internal protected virtual IList<TaxiVozilo>? TaxiVozila { get; set; } 
    internal Vozac()
    {
        this.TipZaposleni = "Vozac";
        Voznje = new List<Voznja>();
        SopstvenaVozila = new List<SopstvenoVozilo>();
        TaxiVozila = new List<TaxiVozilo>();
    }
}
