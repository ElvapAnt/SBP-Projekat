using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            //mapiranje podklasa
            DiscriminateSubClassesOnColumn("TIPZAPOSLENI");

            Id(x => x.Jmbg, "JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime, "LIME");
            Map(x => x.SrednjeSlovo, "SSLOVO");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.BrojTelefona, "BROJTELEFONA");
            //Map(x => x.TipZaposleni, "TIPZAPOSLENI");

            //HasMany(x => x.Voznje).KeyColumn("JMBG_V").Cascade.All().Inverse(); //prebaceno u VozacMapiranja
            //HasMany(x => x.Voznje).KeyColumn("JMBG_A").Cascade.All().Inverse(); //prebaceno u AdminMapiranja
            //HasMany(x => x.SopstvenaVozila).KeyColumn("ID_VOZILO").Cascade.All().Inverse(); //prebaceno u VozacMapiranja
        }
    }
}
