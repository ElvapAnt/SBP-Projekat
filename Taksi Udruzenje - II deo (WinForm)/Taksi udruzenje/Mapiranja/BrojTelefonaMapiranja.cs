using FluentNHibernate.Mapping;
using FluentNHibernate.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje.Mapiranja
{
    class BrojTelefonaMapiranja : ClassMap<BrojTelefona>
    {
        public BrojTelefonaMapiranja() 
        {
            Table("BROJ_TELEFONA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrTel, "BRTEL");

            References(x => x.PripadaRedovnojMusteriji, "ID_MUSTERIJA").LazyLoad();
        }
    }
}
