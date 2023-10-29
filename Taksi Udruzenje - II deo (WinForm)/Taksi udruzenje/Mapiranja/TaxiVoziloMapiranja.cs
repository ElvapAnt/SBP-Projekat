using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje.Mapiranja
{
    class TaxiVoziloMapiranja : ClassMap<TaxiVozilo>
    {
        public TaxiVoziloMapiranja()
        {
            Table("TAXI_VOZILO");

            Id(x => x.RegistarskaOznaka, "REGOZNAKA").GeneratedBy.Assigned();

            Map(x => x.Marka, "MARKA");
            Map(x => x.Tip, "TIP");
            Map(x => x.DatumIstekaRegistracije, "DATUMISTEKAREG");
            Map(x => x.GodinaProizvodnje, "GODINAPROIZVODNJE");

            //Nedostaje mapiranje za ManyToMany sa Vozacem
            HasManyToMany(x => x.Vozaci)
                .Table("DODELJENO")
                .ParentKeyColumn("REGOZNAKA")
                .ChildKeyColumn("JMBG_VOZACA")
                .Cascade.All();

        }
    }
}
