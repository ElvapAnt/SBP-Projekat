using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;

internal class VoznjaMapiranja : ClassMap<TaksiUdruzenjeLibrary.Entiteti.Voznja>
{
    public VoznjaMapiranja()
    {
        //Mapiranje tabele
        Table("VOZNJA");

        //Mapiranje primarnog kljuca
        Id(x => x.Id, "ID_VOZNJA").GeneratedBy.TriggerIdentity(); 

        //Mapiranje svojstava
        Map(x => x.PocetnaStanica, "PSTANICA");
        Map(x => x.KrajnjaStanica, "KSTANICA");
        Map(x => x.PocetnoVreme, "PVREME");
        Map(x => x.KrajnjeVreme, "KVREME");
        Map(x => x.BrojPoziva, "BROJPOZIVA");
        Map(x => x.VremePrimPoziva, "VREMEPRIMPOZIVA");

        References(x => x.PripadaRedovnojMusteriji, "ID_MUSTERIJA").LazyLoad(); //Mapiranje veze ManyToOne Voznja-RedovnaMusterija
        References(x => x.PripadaVozacu, "JMBG_V").LazyLoad(); //Mapiranje veze ManyToOne Voznja-Vozac
        References(x => x.PripadaAdministrativnomOsoblju, "JMBG_A").LazyLoad(); //Mapiranje veze ManyToOne Voznja-AdministrativnoOsoblje
    }
}
