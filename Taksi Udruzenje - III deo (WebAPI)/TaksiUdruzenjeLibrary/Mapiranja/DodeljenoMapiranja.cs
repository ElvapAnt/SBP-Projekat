using FluentNHibernate.Conventions.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;

internal class DodeljenoMapiranja : ClassMap<Dodeljeno>
{
    public DodeljenoMapiranja()
    {
        Table("DODELJENO");

        Id(x => x.Id, "ID_DODELJENO").GeneratedBy.TriggerIdentity();

        Map(x => x.DatumOd, "DATUMOD");
        Map(x => x.DatumDo, "DATUMDO");

        References(x => x.Vozac, "JMBG_VOZACA").LazyLoad();
        References(x => x.TaxiVozilo, "REGOZNAKA").LazyLoad();

    }
}
