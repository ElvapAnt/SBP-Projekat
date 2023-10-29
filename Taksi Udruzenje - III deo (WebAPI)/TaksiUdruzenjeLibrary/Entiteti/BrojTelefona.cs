using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiUdruzenjeLibrary.Entiteti;

internal class BrojTelefona
{
    internal protected virtual int Id { get; protected set; }
    internal protected virtual string? BrTel { get; set; }
    internal protected virtual RedovnaMusterija? PripadaRedovnojMusteriji { get; set; }

}

