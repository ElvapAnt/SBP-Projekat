using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;
internal class Voznja
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual string? PocetnaStanica { get; set; }
    internal protected virtual string? KrajnjaStanica { get; set; }
    internal protected virtual DateTime? PocetnoVreme { get; set; }
    internal protected virtual DateTime? KrajnjeVreme { get; set; }
    internal protected virtual string? BrojPoziva { get; set; }
    internal protected virtual DateTime? VremePrimPoziva { get; set; }

    internal protected virtual RedovnaMusterija? PripadaRedovnojMusteriji { get; set; }
    internal protected virtual Vozac? PripadaVozacu { get; set; }
    internal protected virtual AdministrativnoOsoblje? PripadaAdministrativnomOsoblju { get; set; }
    internal protected Voznja()
    {

    }
}
