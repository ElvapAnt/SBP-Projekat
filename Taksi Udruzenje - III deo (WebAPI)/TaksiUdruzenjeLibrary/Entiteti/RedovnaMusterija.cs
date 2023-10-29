using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;

internal class RedovnaMusterija
{
    internal protected virtual int Id { get; set; }
    internal protected virtual string? Adresa { get; set; }
    internal protected virtual int? BrojKoriscenihVoznji { get; set; }
    internal protected virtual IList<Voznja>? Voznje { get; set; } 
    internal protected virtual IList<BrojTelefona>? BrojeviTelefona { get; set; } 

    internal RedovnaMusterija() 
    {
        Voznje = new List<Voznja>();
        BrojeviTelefona = new List<BrojTelefona>();
    }

}