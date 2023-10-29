using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary.DTOs;

public class ZaposleniView
{
    public string Jmbg { get; set; }
    public string? Ime { get; set; }
    public char? SrednjeSlovo { get; set; }
    public string? Prezime { get; set; }
    public string? Adresa { get; set; }
    public string? BrojTelefona { get; set; }
    //public virtual string? TipZaposleni { get; set; } 

    public ZaposleniView()
    {

    }
    internal ZaposleniView(Zaposleni? z)
    {
        if (z != null)
        {
            Jmbg = z.Jmbg;
            Ime = z.Ime;
            SrednjeSlovo = z.SrednjeSlovo;
            Prezime = z.Prezime;
            Adresa = z.Adresa;
            BrojTelefona = z.BrojTelefona;
            //TipZaposleni = z.TipZaposleni;
        }
    }
}
public class AdministrativnoOsobljeView : ZaposleniView
{
    public string? StrucnaSprema{ get; set; }
    //public IList<VoznjaView>? Voznje{ get; set; }
    
    public AdministrativnoOsobljeView()
    {
        //Voznje = new List<VoznjaView>();
    }
   internal AdministrativnoOsobljeView(AdministrativnoOsoblje? a) : base(a)
    {
        if (a != null)
        {
            StrucnaSprema = a.StrucnaSprema;
        }
    }

}
public class VozacView : ZaposleniView
{
    public char? Kategorija { get; set; }
    public string? BrojDozovole { get; set; }
    /*public IList<VoznjaView>? Voznje { get; set; }
    public IList<SopstvenoVoziloView>? SopstvenaVozila  { get; set; }
    public IList<TaxiVoziloView>? TaxiVozila { get; set; }*/
    public VozacView()
    {
        /*Voznje = new List<VoznjaView>();
        SopstvenaVozila = new List<SopstvenoVoziloView>();
        TaxiVozila = new List<TaxiVoziloView>();*/
    }
    internal VozacView(Vozac? v) : base(v)
    {
        if (v != null)
        {
            Kategorija = v.Kategorija;
            BrojDozovole = v.BrojDozovole;
        }
    }
}
public class RedovnaMusterijaView
{
    public int RedMusterijaId { get; set; }
    public string? Adresa { get; set; }
    public int? BrojKoriscenihVoznji { get; set; }
    /*public IList<VoznjaView>? Voznje { get; set; }*/
    public IList<BrojTelefonaView>? BrojeviTelefona { get; set; }

    public RedovnaMusterijaView()
    {
        //Voznje = new List<VoznjaView>();
        BrojeviTelefona = new List<BrojTelefonaView>();
    }
    internal RedovnaMusterijaView(RedovnaMusterija? rm)
    {
        if (rm != null)
        {
            RedMusterijaId = rm.Id;
            Adresa = rm.Adresa;
            BrojKoriscenihVoznji = rm.BrojKoriscenihVoznji;
            BrojeviTelefona = rm.BrojeviTelefona?.ToList().Select(br=> new BrojTelefonaView(br)).ToList();
        }
    }

}
public class BrojTelefonaView
{
    public int BrTelefonaId { get; set; }
    public string? BrTel { get; set; }
    //public RedovnaMusterijaView? PripadaRedovnojMusteriji { get; set; }
    public BrojTelefonaView()
    {

    }
    internal BrojTelefonaView(BrojTelefona? br)
    {
        if (br != null)
        {
            BrTelefonaId = br.Id;
            BrTel = br.BrTel;
            //PripadaRedovnojMusteriji = new RedovnaMusterijaView(br.PripadaRedovnojMusteriji);
        }
    }
}
public class TaxiVoziloView
{
    public string RegistarskaOznaka { get; set; }
    public string? Marka { get; set; }
    public string? Tip { get; set; }
    public DateTime? DatumIstekaRegistracije { get; set; }
    public int? GodinaProizvodnje { get; set; }
    //public IList<VozacView>? Vozaci { get; set; } 
    public TaxiVoziloView()
    {
        //Vozaci = new List<VozacView>();
    }
    internal TaxiVoziloView(TaxiVozilo? tv)
    {
        if(tv != null)
        {
            RegistarskaOznaka = tv.RegistarskaOznaka;
            Marka = tv.Marka;
            Tip = tv.Tip;
            DatumIstekaRegistracije = tv.DatumIstekaRegistracije;
            GodinaProizvodnje = tv.GodinaProizvodnje;
        }
    }
}
public class SopstvenoVoziloView
{
    public int SopVoziloId { get; set; }
    public string? TipVozila { get; set; }
    public string? Boja { get; set; }
    public string? Marka { get; set; }
    public DateTime? DatumOd { get; set; }
    public DateTime? DatumDo { get; set; } 
    //public VozacView? PripadaVozacu { get; set; } 
    public SopstvenoVoziloView()
    {

    }
    internal SopstvenoVoziloView(SopstvenoVozilo? sv)
    {
        if (sv != null)
        {
            SopVoziloId = sv.Id;
            TipVozila = sv.TipVozila;
            Boja = sv.Boja;
            Marka = sv.Marka;
            DatumOd = sv.DatumOd;
            DatumDo = sv.DatumDo;
            //PripadaVozacu = new VozacView(sv.PripadaVozacu);
        }
    }
}
public class VoznjaView
{
    public int VoznjaId { get; set; }
    public string? PocetnaStanica { get; set; }
    public string? KrajnjaStanica { get; set; }
    public DateTime? PocetnoVreme { get; set; }
    public DateTime? KrajnjeVreme { get; set; }
    public string? BrojPoziva { get; set; }
    public DateTime? VremePrimPoziva { get; set; }

    public RedovnaMusterijaView? PripadaRedovnojMusteriji { get; set; }
    public VozacView? PripadaVozacu { get; set; }
    public AdministrativnoOsobljeView? PripadaAdministrativnomOsoblju { get; set; }
    public VoznjaView()
    {

    }
    internal VoznjaView(Voznja? v)
    {
        if(v!= null)
        {
            VoznjaId = v.Id;
            PocetnaStanica = v.PocetnaStanica;
            KrajnjaStanica = v.KrajnjaStanica;
            PocetnoVreme = v.PocetnoVreme;
            KrajnjeVreme = v.KrajnjeVreme;
            BrojPoziva = v.BrojPoziva;
            VremePrimPoziva = v.VremePrimPoziva;
            PripadaRedovnojMusteriji = new RedovnaMusterijaView(v.PripadaRedovnojMusteriji);
            PripadaVozacu = new VozacView(v.PripadaVozacu);
            PripadaAdministrativnomOsoblju = new AdministrativnoOsobljeView(v.PripadaAdministrativnomOsoblju);
        }
    }
}
public class DodeljenoView
{
    public int Id { get; set; }
    public DateTime? DatumOd { get; set; }
    public DateTime? DatumDo { get; set; }
    public TaxiVoziloView? TaxiVozilo { get; set; }
    public VozacView? Vozac { get; set; }
    public DodeljenoView()
    {

    }
    internal DodeljenoView(Dodeljeno? d)
    {
        if (d != null)
        {
            Id = d.Id;
            DatumOd = d.DatumOd;
            DatumDo = d.DatumDo;
            TaxiVozilo = new TaxiVoziloView(d.TaxiVozilo);
            Vozac = new VozacView(d.Vozac);
        }
    }
    

}
