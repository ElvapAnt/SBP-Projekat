using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;

internal class VozacMapiranja : SubclassMap<Vozac>
{
    public VozacMapiranja() 
    {
        DiscriminatorValue("Vozac");

        Map(x => x.Kategorija, "KATEGORIJA");
        Map(x => x.BrojDozovole, "BRVDOZVOLE");

        HasMany(x => x.Voznje).KeyColumn("JMBG_V").Cascade.All().Inverse(); //Veza OneToMany sa Voznjom
        HasMany(x => x.SopstvenaVozila).KeyColumn("JMBG_VOZACA").Cascade.All().Inverse(); //Veza OneToMany sa SopstvenimVozilima
    
        HasManyToMany(x => x.TaxiVozila)
            .Table("DODELJENO")
            .ParentKeyColumn("JMBG_VOZACA")
            .ChildKeyColumn("REGOZNAKA")
            .Cascade.All()
            .Inverse(); //TaxiVozila vode racuna o vezi. Tj TaxiVozila ce sama po potrebi cuvati svoje Vozace
    } 
}
