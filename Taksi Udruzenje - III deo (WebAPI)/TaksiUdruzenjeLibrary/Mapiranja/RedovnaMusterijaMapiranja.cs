using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.Mapiranja;

internal class RedovnaMusterijaMapiranja : ClassMap<TaksiUdruzenjeLibrary.Entiteti.RedovnaMusterija>
{
    public RedovnaMusterijaMapiranja() 
    { 
        Table("REDOVNA_MUSTERIJA");

        Id(x => x.Id, "ID_MUSTERIJA").GeneratedBy.TriggerIdentity();

        Map(x => x.Adresa, "ADRESA");
        Map(x => x.BrojKoriscenihVoznji, "BROJKORISCENIHVOZNJI");

        HasMany(x => x.Voznje).KeyColumn("ID_MUSTERIJA").Cascade.All().Inverse(); //Najbolje ovako gde je Inverse kod 1 strane, sto znaci da N strana vodi racuna o FK  //mapiranje veze OneToMany RedovnaMusterija-Voznja
        HasMany(x => x.BrojeviTelefona).KeyColumn("ID_MUSTERIJA").Cascade.All().Inverse();
    }
    
}
