using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;

internal class AdministrativnoOsoblje : Zaposleni
{
    internal protected virtual string? StrucnaSprema { get; set; }
    internal protected virtual IList<Voznja>? Voznje { get; set; } 
    internal AdministrativnoOsoblje()
    {
        this.TipZaposleni = "Admin";
        Voznje = new List<Voznja>();
    }
}

