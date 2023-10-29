using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;
internal class AdministrativnoOsobljeMapiranje : SubclassMap<AdministrativnoOsoblje>
{
    public AdministrativnoOsobljeMapiranje() 
    {
        DiscriminatorValue("Admin");

        Map(x => x.StrucnaSprema, "STRUCNASPREMA");

        HasMany(x => x.Voznje).KeyColumn("JMBG_A").Cascade.All().Inverse(); //veza OneToMany sa Voznjom
    }
}
