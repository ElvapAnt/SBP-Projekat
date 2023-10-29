using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;
internal class ZaposleniMapiranja : ClassMap<Zaposleni>
{ 
    public ZaposleniMapiranja()
    {
        Table("ZAPOSLENI");

        DiscriminateSubClassesOnColumn("TIPZAPOSLENI");

        Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

        Map(x => x.Ime, "LIME");
        Map(x => x.SrednjeSlovo, "SSLOVO");
        Map(x => x.Prezime, "PREZIME");
        Map(x => x.Adresa, "ADRESA");
        Map(x => x.BrojTelefona, "BROJTELEFONA");
    }
}
