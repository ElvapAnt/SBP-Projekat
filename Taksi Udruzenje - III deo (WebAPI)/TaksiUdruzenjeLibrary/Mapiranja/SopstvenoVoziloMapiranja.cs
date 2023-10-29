using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;
internal class SopstvenoVoziloMapiranja : ClassMap<SopstvenoVozilo>
{
    public SopstvenoVoziloMapiranja()
    {
        Table("SOPSTVENO_VOZILO");

        Id(x => x.Id, "ID_VOZILO").GeneratedBy.TriggerIdentity();

        Map(x => x.TipVozila, "TIPVOZILA");
        Map(x => x.Boja, "BOJA");
        Map(x => x.Marka, "MARKA");
        Map(x => x.DatumOd, "DATUMOD");
        Map(x => x.DatumDo, "DATUMDO");

        References(x => x.PripadaVozacu, "JMBG_VOZACA").LazyLoad();
    }
}
