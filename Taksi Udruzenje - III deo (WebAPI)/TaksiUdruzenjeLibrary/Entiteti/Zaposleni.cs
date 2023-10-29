using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;
internal abstract class Zaposleni 
{
    internal protected virtual string Jmbg { get; set; } 
    internal protected virtual string? Ime { get; set; }
    internal protected virtual char? SrednjeSlovo { get; set; } 
    internal protected virtual string? Prezime { get; set; }
    internal protected virtual string? Adresa { get; set; }
    internal protected virtual string? BrojTelefona { get; set; }
    internal protected virtual string? TipZaposleni { get; set; }
    internal Zaposleni() 
    {
        
    }
}
