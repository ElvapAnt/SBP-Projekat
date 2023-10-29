using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje
{
    #region Zaposleni

    public class ZaposleniView
    {
        public string Jmbg;
        public string Ime;
        public char SrednjeSlovo;
        public string Prezime;
        public string Adresa;
        public string BrojTelefona;
        public string TipZaposlenog;

        public ZaposleniView()
        {

        }
        public ZaposleniView(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, string tip)
        {
            this.Jmbg = jmbg;
            this.Ime = ime;
            this.SrednjeSlovo = srednjeSlovo;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.BrojTelefona = brtel;
            this.TipZaposlenog = tip;
        }
    }

    public class ZaposleniBasic
    {
        public string Jmbg;
        public string Ime;
        public char SrednjeSlovo;
        public string Prezime;
        public string Adresa;
        public string BrojTelefona;
        public string TipZaposlenog;

        public ZaposleniBasic()
        {
            
        }
        public ZaposleniBasic(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, string tip)
        {
            this.Jmbg = jmbg;
            this.Ime = ime;
            this.SrednjeSlovo = srednjeSlovo;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.BrojTelefona = brtel;
            this.TipZaposlenog = tip;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }

    public class AdministrativnoOsobljeView : ZaposleniView
    {
        public string StrucnaSprema;
        public AdministrativnoOsobljeView()
        {

        }
        public AdministrativnoOsobljeView(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, string strucnaSprema) 
            : base(jmbg, ime, srednjeSlovo, prezime, adresa, brtel,"Admin")
        {
            this.StrucnaSprema = strucnaSprema;
        }
    }

    public class AdministrativnoOsobljeBasic : ZaposleniBasic
    {
        public string StrucnaSprema;
        public IList<VoznjaBasic> Voznje;
        public AdministrativnoOsobljeBasic()
        {
            Voznje = new List<VoznjaBasic>();
        }
        public AdministrativnoOsobljeBasic(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, string strucnaSprema)
            : base(jmbg, ime, srednjeSlovo, prezime, adresa, brtel,"Admin")
        {
            this.StrucnaSprema = strucnaSprema;
        }
    }

    public class VozacView : ZaposleniView
    {
        public char Kategorija;
        public string BrojDozovole;
        public VozacView()
        {

        }
        public VozacView(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, char kategorija, string brdoz)
            : base(jmbg, ime, srednjeSlovo, prezime, adresa, brtel,"Vozac")
        {
            this.Kategorija = kategorija;
            this.BrojDozovole = brdoz;
        }
    }

    public class VozacBasic : ZaposleniBasic
    {
        public char Kategorija;
        public string BrojDozovole;

        public IList<VoznjaBasic> Voznje; //veza OneToMany sa Voznjom

        public IList<SopstvenoVoziloBasic> SopstvenaVozila; //veza OneToMany sa SopstvenimVozilima GRESKA ILI NIJE VIDECEMO

        public IList<TaxiVoziloBasic> TaxiVozila; //veza ManyToMany sa Vozacem

        public VozacBasic()
        {

            Voznje = new List<VoznjaBasic>();
            SopstvenaVozila = new List<SopstvenoVoziloBasic>();
            TaxiVozila = new List<TaxiVoziloBasic>();
        }

        public VozacBasic(string jmbg, string ime, char srednjeSlovo, string prezime, string adresa, string brtel, char kategorija, string brdoz)
            : base(jmbg, ime, srednjeSlovo, prezime, adresa, brtel,"Vozac")
        {
            this.Kategorija = kategorija;
            this.BrojDozovole = brdoz;
        }
    }
    #endregion

    #region RedovnaMusterija
    public class RedovnaMusterijaBasic
    {
        public int RedMusterijaId;
        public string Adresa;
        public int BrojKoriscenihVoznji;

        public IList<VoznjaBasic> Voznje; //veza OneToMany sa Voznjom

        public IList<BrojTelefonaBasic> BrojeviTelefona; //veza OneToMany sa tabelom (visevrednosnim atributom) BrojTelefona
         
        public RedovnaMusterijaBasic()
        {
            Voznje = new List<VoznjaBasic>();
            BrojeviTelefona = new List<BrojTelefonaBasic>();
        }
        public RedovnaMusterijaBasic(int redMusterijaId, string adresa, int brKoriscenihVoznji)
        {
            this.RedMusterijaId = redMusterijaId;
            this.Adresa = adresa;
            this.BrojKoriscenihVoznji = brKoriscenihVoznji;
        }

    }
    public class RedovnaMusterijaView
    {
        public int RedMusterijaId;
        public string Adresa;
        public int BrojKoriscenihVoznji;
        public RedovnaMusterijaView()
        {

        }
        public RedovnaMusterijaView(int redMusterijaId, string adresa, int brKoriscenihVoznji)
        {
            this.RedMusterijaId = redMusterijaId;
            this.Adresa = adresa;
            this.BrojKoriscenihVoznji = brKoriscenihVoznji;
        }

    }

    public class BrojTelefonaBasic
    {
        public int BrTelefonaId;
        public string BrTel;
        public RedovnaMusterijaBasic PripadaRedovnojMusteriji;
        public BrojTelefonaBasic()
        {

        }
        public BrojTelefonaBasic(int brTelefonaId, string brTel)
        {
            this.BrTelefonaId = brTelefonaId;
            this.BrTel = brTel;
        }
    }

    #endregion

    #region TaxiVozilo
    public class TaxiVoziloBasic
    {
        public string RegistarskaOznaka;
        public string Marka;
        public string Tip;
        public DateTime DatumIstekaRegistracije;
        public int GodinaProizvodnje;
        public IList<VozacBasic> Vozaci; //veza ManyToMany sa TaxiVozilima

        public TaxiVoziloBasic()
        {
            Vozaci = new List<VozacBasic>();
        }

        public TaxiVoziloBasic(string regOznaka, string marka, string tip, DateTime datumIsteka, int godProiz)
        {
            this.RegistarskaOznaka = regOznaka;
            this.Marka = marka;
            this.Tip = tip;
            this.DatumIstekaRegistracije = datumIsteka;
            this.GodinaProizvodnje = godProiz;
        }
    }
    public class TaxiVoziloView
    {
        public string RegistarskaOznaka;
        public string Marka;
        public string Tip;
        public DateTime DatumIstekaRegistracije;
        public int GodinaProizvodnje;
        public TaxiVoziloView()
        {
                
        }
        public TaxiVoziloView(string regOznaka, string marka, string tip, DateTime datumIsteka, int godProiz)
        {
            this.RegistarskaOznaka = regOznaka;
            this.Marka = marka;
            this.Tip = tip;
            this.DatumIstekaRegistracije = datumIsteka;
            this.GodinaProizvodnje = godProiz;
        }
    }
    #endregion

    #region SopstvenoVozilo
    public class SopstvenoVoziloBasic
    {
        public int SopVoziloId;
        public string TipVozila;
        public string Boja;
        public string Marka;
        public string ImeIPrezimeVozaca;
        public DateTime DatumOd;
        public DateTime? DatumDo; //? jer je nullable tj DatumDo moze biti null
        public VozacBasic PripadaVozacu; //Ovde je OneToMany veza sa VOZAC
        public SopstvenoVoziloBasic()
        {

        }
        public SopstvenoVoziloBasic(int sopVoziloId, string imeIPrezimeVozaca, string tipVozila, string boja, string marka, DateTime datumOd, DateTime? datumDo)
        {
            this.SopVoziloId = sopVoziloId;
            this.ImeIPrezimeVozaca = imeIPrezimeVozaca;
            this.TipVozila = tipVozila;
            this.Boja = boja;
            this.Marka = marka;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
        }

    }
    public class SopstvenoVoziloView
    {
        public int SopVoziloId;
        public string TipVozila;
        public string Boja;
        public string Marka;
        public DateTime DatumOd;
        public DateTime? DatumDo;

        public SopstvenoVoziloView()
        {

        }
        public SopstvenoVoziloView(int sopVoziloId, string tipVozila, string boja, string marka, DateTime datumOd, DateTime? datumDo)
        {
            this.SopVoziloId = sopVoziloId;
            this.TipVozila = tipVozila;
            this.Boja = boja;
            this.Marka = marka;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
        }
    }
    #endregion

    #region Voznja
    public class VoznjaBasic
    {
        public int VoznjaId;
        public string PocetnaStanica;
        public string KrajnjaStanica;
        public DateTime PocetnoVreme;
        public DateTime KrajnjeVreme;
        public string BrojPoziva;
        public DateTime VremePrimPoziva;

        public RedovnaMusterijaBasic PripadaRedovnojMusteriji;
        public VozacBasic PripadaVozacu;
        public AdministrativnoOsobljeBasic PripadaAdministrativnomOsoblju;
        public VoznjaBasic()
        {

        }
        public VoznjaBasic(int voznjaId, string pstanica, string kstanica, DateTime pvreme, DateTime kvreme, string brpoz, DateTime vremeprimpoz)
        {
            this.VoznjaId = voznjaId;
            this.PocetnaStanica = pstanica;
            this.KrajnjaStanica = kstanica;
            this.PocetnoVreme = pvreme;
            this.KrajnjeVreme = kvreme;
            this.BrojPoziva = brpoz;
            this.VremePrimPoziva = vremeprimpoz;
        }
    }
    public class VoznjaView
    {
        public int VoznjaId;
        public string PocetnaStanica;
        public string KrajnjaStanica;
        public DateTime PocetnoVreme;
        public DateTime KrajnjeVreme;
        public string BrojPoziva;
        public DateTime VremePrimPoziva;
        public VoznjaView()
        {

        }
        public VoznjaView(int voznjaId, string pstanica, string kstanica, DateTime pvreme, DateTime kvreme, string brpoz, DateTime vremeprimpoz)
        {
            this.VoznjaId = voznjaId;
            this.PocetnaStanica = pstanica;
            this.KrajnjaStanica = kstanica;
            this.PocetnoVreme = pvreme;
            this.KrajnjeVreme = kvreme;
            this.BrojPoziva = brpoz;
            this.VremePrimPoziva = vremeprimpoz;
        }
    }
    #endregion

    #region Dodeljeno
    public class DodeljenoBasic
    {
        public int Id;
        public DateTime DatumOd;
        public DateTime? DatumDo;
        public TaxiVoziloBasic TaxiVozilo;
        public VozacBasic Vozac;
        public DodeljenoBasic()
        {

        }
        public DodeljenoBasic(int id, DateTime datumOd, DateTime? datumDo, TaxiVoziloBasic taxiVozilo, VozacBasic vozac)
        {
            this.Id = id;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.TaxiVozilo = taxiVozilo;
            this.Vozac = vozac;
        }

    }
    public class DodeljenoView
    {
        public int Id;
        public DateTime DatumOd;
        public DateTime? DatumDo;
        public TaxiVoziloView TaxiVozilo;
        public VozacView Vozac;
        public DodeljenoView()
        {

        }
        public DodeljenoView(int id, DateTime datumOd, DateTime? datumDo, TaxiVoziloView taxiVozilo, VozacView vozac)
        {
            this.Id = id;
            this.DatumOd = datumOd;
            this.DatumDo = datumDo;
            this.TaxiVozilo = taxiVozilo;
            this.Vozac = vozac;
        }

    }
    #endregion

}
