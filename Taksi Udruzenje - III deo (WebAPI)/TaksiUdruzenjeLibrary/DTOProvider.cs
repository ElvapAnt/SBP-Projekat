using FluentNHibernate.Conventions.AcceptanceCriteria;
using NHibernate;
using NHibernate.Event.Default;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using TaksiUdruzenjeLibrary.Entiteti;

namespace TaksiUdruzenjeLibrary;

public static class DTOProvider
{
    #region Zaposleni
    public static async Task<Result<List<ZaposleniView>, string>> VratiSveZaposleneAsync()
    {
        List<ZaposleniView> zaposleni = new List<ZaposleniView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            zaposleni = (await s.QueryOver<Zaposleni>().ListAsync())
                        .Select(z => new ZaposleniView(z)).ToList();
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o zaposlenima";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return zaposleni;
    }
    #region Vozaci
    public static async Task<Result<List<VozacView>, string>> VratiSveVozaceAsync()
    {
        List<VozacView> vozaci = new List<VozacView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            vozaci = (await s.QueryOver<Vozac>().ListAsync())
                .Select(v => new VozacView(v)).ToList();

        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o vozacima.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return vozaci;
    }
    public static async Task<Result<bool, string>> ObrisiVozacaAsync(string jmbgVozaca)
    {

        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            
            Vozac v = await s.LoadAsync<Vozac>(jmbgVozaca);
            //v.TaxiVozila?.Clear();

            await s.DeleteAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja vozaca.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    public static Result<VozacView,string> VratiVozaca(string jmbg)
    {
        ISession? s = null;
        VozacView v = new VozacView();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            Vozac vozac = s.Load<Vozac>(jmbg);

            v.Jmbg = vozac.Jmbg;
            v.Ime = vozac.Ime;
            v.SrednjeSlovo = vozac.SrednjeSlovo;
            v.Prezime = vozac.Prezime;
            v.BrojDozovole = vozac.BrojDozovole;
            v.Kategorija = vozac.Kategorija;
            //v.Voznje = await DTOManager.VratiVoznjeObavioVozacAsync(jmbg);

        }
        catch (Exception)
        {
            return "Nemoguce vratit vozaca.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return v;
    }
    public static async Task<Result<bool,string>> AzurirajVozacaAsync(VozacView vozac)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            TaksiUdruzenjeLibrary.Entiteti.Vozac v = await s.LoadAsync<Vozac>(vozac.Jmbg);

            v.Ime = vozac.Ime;
            v.Prezime = vozac.Prezime;
            v.SrednjeSlovo = vozac.SrednjeSlovo;
            v.BrojDozovole = v.BrojDozovole;
            v.BrojTelefona = vozac.BrojTelefona;
            v.Adresa = vozac.Adresa;

            await s.SaveOrUpdateAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce izmeniti podatke o vozacu";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> DodajVozacaAsync(VozacView vozac)
    {
        ISession? s = null;

        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            Vozac v = new Vozac();
            v.Jmbg = vozac.Jmbg;
            v.Ime = vozac.Ime;
            v.SrednjeSlovo = vozac.SrednjeSlovo;
            v.Prezime = vozac.Prezime;
            v.Adresa = vozac.Adresa;
            v.BrojDozovole = vozac.BrojDozovole;
            v.BrojTelefona = vozac.BrojTelefona;
            v.Kategorija = vozac.Kategorija;
            await s.SaveOrUpdateAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce sacuvati novog vozaca.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return true;
    }
    #endregion
   
    #region AdministrativnaOsoblja
    public static async Task<Result<List<AdministrativnoOsobljeView>,string>> VratiSveAdmineAsync()
    {
        List<AdministrativnoOsobljeView> admini = new List<AdministrativnoOsobljeView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            admini = (await s.QueryOver<AdministrativnoOsoblje>().ListAsync())
                .Select(a=> new AdministrativnoOsobljeView(a)).ToList();


        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o adminima.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return admini;
    }
    public static async Task<Result<bool,string>> ObrisiAdminaAsync(string jmbgAdmina)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Entiteti.AdministrativnoOsoblje a = await s.LoadAsync<Entiteti.AdministrativnoOsoblje>(jmbgAdmina);
            a.Voznje?.Clear();

            await s.DeleteAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja vozaca.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static Result<AdministrativnoOsobljeView,string> VratiAdmina(string jmbg)
    {
        ISession? s = null;
        AdministrativnoOsobljeView a = new();
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Entiteti.AdministrativnoOsoblje admin = s.Load<Entiteti.AdministrativnoOsoblje>(jmbg);

            a = new AdministrativnoOsobljeView(admin);
            
            //a.Voznje = DTOManager.VratiVoznjePrimioPozivAdmin(jmbg);
        }
        catch (Exception)
        {
            return "Nemoguce vratiti admina.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return a;
    }
    public static async Task<Result<bool,string>> AzurirajAdminaAsync(AdministrativnoOsobljeView admin)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            AdministrativnoOsoblje a = await s.LoadAsync<AdministrativnoOsoblje>(admin.Jmbg);
            a.Ime = admin.Ime;
            a.Prezime = admin.Prezime;
            a.SrednjeSlovo = admin.SrednjeSlovo;
            a.StrucnaSprema = admin.StrucnaSprema;
            a.BrojTelefona = admin.BrojTelefona;
            a.Adresa = admin.Adresa;

            await s.SaveOrUpdateAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce izmeniti podatke o adminu";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> DodajAdminaAsync(AdministrativnoOsobljeView admin)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            AdministrativnoOsoblje a = new AdministrativnoOsoblje();
            a.Jmbg = admin.Jmbg;
            a.Ime = admin.Ime;
            a.SrednjeSlovo = admin.SrednjeSlovo;
            a.Prezime = admin.Prezime;
            a.Adresa = admin.Adresa;
            a.BrojTelefona = admin.BrojTelefona;
            a.StrucnaSprema = admin.StrucnaSprema;

            await s.SaveOrUpdateAsync(a);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce dodati admina";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    #endregion

    #endregion

    #region TaxiVozila
    public static Result<List<TaxiVoziloView>,string> VratiSvaTaxiVozila()
    {
        List<TaxiVoziloView> taxiVozila = new List<TaxiVoziloView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<TaxiVozilo> svaTaxiVozila = from tv in s.Query<TaxiVozilo>()
                                                             select tv;

            foreach (TaxiVozilo tv in svaTaxiVozila)
            {
                taxiVozila.Add(new TaxiVoziloView(tv));
            }
        }
        catch (Exception)
        {
            return "Došlo je do greške prilikom prikupljanja informacija o taxi vozilima";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return taxiVozila;
    }
    public static async Task<Result<bool,string>> ObrisiTaxiVoziloAsync(string regOznaka)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            
            Entiteti.TaxiVozilo tv = await s.LoadAsync<Entiteti.TaxiVozilo>(regOznaka);
            tv.Vozaci?.Clear();

            await s.DeleteAsync(tv);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja taxi vozila.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static Result<TaxiVoziloView,string> VratiTaxiVozilo(string regOznaka)
    {
        ISession? s = null;
        TaxiVoziloView tv = default!;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Entiteti.TaxiVozilo taxiVozilo = s.Load<Entiteti.TaxiVozilo>(regOznaka);

            tv.RegistarskaOznaka = taxiVozilo.RegistarskaOznaka;
            tv.Marka = taxiVozilo.Marka;
            tv.Tip = taxiVozilo.Tip;
            tv.DatumIstekaRegistracije = taxiVozilo.DatumIstekaRegistracije;
            tv.GodinaProizvodnje = taxiVozilo.GodinaProizvodnje;

        }
        catch (Exception)
        {
            return "Nemoguce vratiti taxi vozilo.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return tv;
    }
    public static async Task<Result<bool,string>> AzurirajTaxiVoziloAsync(TaxiVoziloView taxiVozilo)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            TaksiUdruzenjeLibrary.Entiteti.TaxiVozilo tv = await s.LoadAsync<TaxiVozilo>(taxiVozilo.RegistarskaOznaka);
            tv.DatumIstekaRegistracije = taxiVozilo.DatumIstekaRegistracije;
            tv.Marka = taxiVozilo.Marka;
            tv.Tip = taxiVozilo.Tip;
            tv.GodinaProizvodnje = tv.GodinaProizvodnje;
            await s.SaveOrUpdateAsync(tv);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce obrisati taxi vozilo.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> DodajTaxiVoziloAsync(TaxiVoziloView taxi)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Entiteti.TaxiVozilo tv = new TaxiVozilo();

            tv.RegistarskaOznaka = taxi.RegistarskaOznaka;
            tv.Marka = taxi.Marka;
            tv.Tip = taxi.Tip;
            tv.DatumIstekaRegistracije = taxi.DatumIstekaRegistracije;
            tv.GodinaProizvodnje = taxi.GodinaProizvodnje;

            await s.SaveOrUpdateAsync(tv);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce dodati taxi vozilo.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> PoveziTaxiVoziloIVozacaAsync(string jmbgVozaca, string regOznaka)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            var rezultat = VratiDodeljenaVozilaVozaca(jmbgVozaca);

            if (rezultat.IsError)
            {
                return $"Greska prilikom vracanja dodeljeno odnosa : {rezultat.Error}";
            }




            foreach (DodeljenoView dv in rezultat.Data)
            {
                if(dv!=null && dv.DatumDo == null)
                {
                    Dodeljeno d = new Dodeljeno();
                    d = s.Load<Dodeljeno>(dv.Id);
                    d.DatumDo = DateTime.Now;
                    s.SaveOrUpdate(d);
                }
            }

            Dodeljeno novi = new Dodeljeno();
            novi.Vozac = await s.LoadAsync<Vozac>(jmbgVozaca); 
            novi.TaxiVozilo = await s.LoadAsync<TaxiVozilo>(regOznaka); 
            novi.DatumOd = DateTime.Now;
            novi.DatumDo = null;

            await s.SaveOrUpdateAsync(novi); 
            await s.FlushAsync();
        }
        catch(Exception)
        {
            return "Nemoguce povezati taxi vozilo sa vozacem";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    #endregion

    #region Dodeljeno
    public static Result<List<DodeljenoView>,string> VratiDodeljeniOdnos(string jmbgVozaca, string regOznaka)
    {
        List<DodeljenoView> dodeljeno = new List<DodeljenoView>();
        try
        {
            ISession? s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Dodeljeno> sveDodeljeno = from d in s.Query<Dodeljeno>()
                                                  where d.Id != null && d.Vozac != null && d.Vozac.Jmbg == jmbgVozaca
                                                  where d.Id != null && d.TaxiVozilo != null && d.TaxiVozilo.RegistarskaOznaka == regOznaka
                                                  select d;
            foreach (Dodeljeno d in sveDodeljeno)
            {
                dodeljeno.Add(new DodeljenoView(d));
            }

            s.Close();
        }
        catch (Exception )
        {
            return "Nemoguce vratiti dodeljeni odnos taxi vozila i vozaca";
        }
        return dodeljeno;
    }
    public static Result<List<DodeljenoView>,string> VratiDodeljenaVozilaVozaca(string jmbgVozaca)
    {
        List<DodeljenoView> dodeljeno = new List<DodeljenoView>();
        try
        {
            ISession? s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Entiteti.Dodeljeno> svaDodeljena = from d in s.Query<Dodeljeno>()
                                                           where d.Id != null && d.Vozac != null && 
                                                           d.Vozac.Jmbg == jmbgVozaca
                                                           select d;
            foreach (Dodeljeno d in svaDodeljena)
            {
                dodeljeno.Add(new DodeljenoView(d));
            }

            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti dodeljena taxi vozila vozaca sa JMBG-om {jmbgVozaca}";
        }
        return dodeljeno;
    }
    public static Result<List<DodeljenoView>,string> VratiDodeljeneVozaceVozila(string regOznaka)
    {
        List<DodeljenoView> dodeljeno = new List<DodeljenoView>();
        try
        {
            ISession? s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Entiteti.Dodeljeno> svaDodeljena = from d in s.Query<Dodeljeno>()
                                                           where d.Id != null && d.TaxiVozilo != null && 
                                                           d.TaxiVozilo.RegistarskaOznaka == regOznaka
                                                           select d;
            foreach(Dodeljeno d in svaDodeljena)
            {
                dodeljeno.Add(new DodeljenoView(d));
            }

            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti dodeljene vozace taxi vozila sa registracijom - {regOznaka}";
        }
        return dodeljeno;
    }

    //u slucaju da ne radi f-ja probati bez async task
    public static async Task<Result<bool,string>> DodajDodeljenoAsync(DodeljenoView dv, string jmbg, string regOznaka)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            IEnumerable<Dodeljeno> sveDodeljeno = s.Query<Dodeljeno>().ToList();
            
            foreach(Dodeljeno d in sveDodeljeno)
            {
                if(d.TaxiVozilo.RegistarskaOznaka == regOznaka && d.DatumDo == null)
                {
                    d.DatumDo = DateTime.Now;
                    s.SaveOrUpdate(d);
                }
            }
           
            Dodeljeno dodeljeno = new Dodeljeno();
            dodeljeno.TaxiVozilo = await s.LoadAsync<TaxiVozilo>(regOznaka);
            dodeljeno.Vozac = await s.LoadAsync<Vozac>(jmbg);
            dodeljeno.DatumDo = dv.DatumDo;
            dodeljeno.DatumOd = dv.DatumOd;
            
            await s.SaveOrUpdateAsync(dodeljeno);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greska pri dodavanju novog dodeljeno odnosa";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    
    #endregion

    #region SopstvenaVozila
    public static async Task<Result<List<SopstvenoVoziloView>,string>> VratiSopVozilaVozacaAsync(string jmbgVozaca)
    {
        List<SopstvenoVoziloView> sopVozila = new List<SopstvenoVoziloView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            sopVozila = (await s.QueryOver<SopstvenoVozilo>().ListAsync())
                .Where(s => (s.PripadaVozacu != null) && (s.PripadaVozacu.Jmbg == jmbgVozaca))
                .Select(s=>new SopstvenoVoziloView(s)).ToList();

            

        }
        catch (Exception)
        {
            return $"Došlo je do greške prilikom prikupljanja informacija o sopstvenim vozilima vozaca {jmbgVozaca}";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return sopVozila;
    }
    public static async Task<Result<bool,string>> ObrisiSopVoziloAsync(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            SopstvenoVozilo v = await s.LoadAsync<SopstvenoVozilo>(id);

            await s.DeleteAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Greška prilikom brisanja sopstvenog vozila.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static Result<SopstvenoVoziloView,string> VratiSopstvenoVozilo(int id)
    {
        SopstvenoVoziloView sv = new SopstvenoVoziloView();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Entiteti.SopstvenoVozilo sopvozilo = s.Load<Entiteti.SopstvenoVozilo>(id);
            sv.SopVoziloId = sopvozilo.Id;
            sv.TipVozila = sopvozilo.TipVozila;
            sv.Boja = sopvozilo.Boja;
            sv.Marka = sopvozilo.Marka;
            sv.DatumDo = sopvozilo.DatumDo;
            sv.DatumOd = sopvozilo.DatumOd;
        }
        catch (Exception)
        {
            return "Nemoguce vratiti sopstveno vozilo.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return sv;
    }
    public static async Task<Result<bool,string>> AzurirajSopVoziloAsync(SopstvenoVoziloView sopVozilo)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            SopstvenoVozilo sv = s.Load<SopstvenoVozilo>(sopVozilo.SopVoziloId);
            sv.DatumDo = sopVozilo.DatumDo;
            sv.Boja = sopVozilo.Boja;
            sv.TipVozila = sopVozilo.TipVozila;
            sv.Marka = sopVozilo.Marka;
            await s.SaveOrUpdateAsync(sv);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce azurirati sopstveno vozilo.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> DodajSopstvenoVoziloAsync(SopstvenoVoziloView svozilo, string jmbgVozaca)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            SopstvenoVozilo sv = new SopstvenoVozilo();
            sv.TipVozila = svozilo.TipVozila;
            sv.Boja = svozilo.TipVozila;
            sv.Marka = svozilo.Marka;
            sv.DatumOd = svozilo.DatumOd;
            sv.DatumDo = svozilo.DatumDo;
            sv.PripadaVozacu = await s.LoadAsync<Vozac>(jmbgVozaca);

            await s.SaveOrUpdateAsync(sv);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce dodati sopstveno vozilo.";
        }
        return true;
    }
    #endregion

    #region RedovneMusterije
    public static async Task<Result<List<RedovnaMusterijaView>,string>> VratiRedovneMusterijeAsync()
    {
        List<RedovnaMusterijaView> musterije = new List<RedovnaMusterijaView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<RedovnaMusterija> sveMusterije = from m in await s.QueryOver<RedovnaMusterija>().ListAsync()
                                                         select m;
            foreach (RedovnaMusterija m in sveMusterije)
            {
                musterije.Add(new RedovnaMusterijaView(m));
            }
        }
        catch (Exception )
        {
            return "Nemoguce vratiti podatke o svim musterijama.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }

        return musterije;
    }
    public static Result<RedovnaMusterijaView,string> VratiMusteriju(int id)
    {
        RedovnaMusterijaView m = new RedovnaMusterijaView();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            
            RedovnaMusterija musterija = s.Load<Entiteti.RedovnaMusterija>(id);
            var rezultat = VratiBrojeveTelefonaMusterije(id);
            if (rezultat.IsError)
            {
                return $"Greska prilikom prikupljanja brojeva telefona musterije : {rezultat.Error}";
            }


            m.RedMusterijaId = musterija.Id;
            m.Adresa = musterija.Adresa;
            m.BrojKoriscenihVoznji = musterija.BrojKoriscenihVoznji;
            m.BrojeviTelefona = rezultat.Data;

            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti musteriju sa id-jem : {id}";
        }

        return m;
    }
    public static async Task<Result<bool,string>> AzurirajMusterijuAsync(RedovnaMusterijaView musterija)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            RedovnaMusterija m = await s.LoadAsync<RedovnaMusterija>(musterija.RedMusterijaId);
            m.Adresa = musterija.Adresa;
            for(int i = 0; i < m.BrojeviTelefona?.Count;i++)
            {
                if (m.BrojeviTelefona[i].Id == musterija.BrojeviTelefona?[i].BrTelefonaId)
                {
                    m.BrojeviTelefona[i].BrTel = musterija.BrojeviTelefona[i].BrTel;
                    await s.SaveOrUpdateAsync(m.BrojeviTelefona[i]);
                }
            }
            int n = musterija.BrojeviTelefona.Count;
            int x = m.BrojeviTelefona.Count;
            while(n > x)
            {
                BrojTelefona broj = new BrojTelefona()
                {
                    BrTel = musterija.BrojeviTelefona?[n - 1].BrTel,
                    PripadaRedovnojMusteriji = m
                };
                m.BrojeviTelefona?.Add(broj);
                await s.SaveOrUpdateAsync(broj);
                n--;
            }
            
            await s.SaveOrUpdateAsync(m);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce azurirati podatke o musteriji.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static Result<bool,string> AzurirajMusterijuBrojVoznji(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            RedovnaMusterija m = s.Load<RedovnaMusterija>(id);
            m.BrojKoriscenihVoznji++;

            s.SaveOrUpdate(m);
            s.Flush();
            s.Close();

        }
        catch (Exception)
        {
            return $"Greska prilikom azuriranja broja voznji musterije - {id}";
        }
        return true;
    }
    public static async Task<Result<bool,string>> DodajMusterijuAsync(RedovnaMusterijaView musterija)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            RedovnaMusterija m = new RedovnaMusterija();
            m.Adresa = musterija.Adresa;
            m.BrojKoriscenihVoznji = musterija.BrojKoriscenihVoznji;
            await s.SaveOrUpdateAsync(m);
            if (musterija.BrojeviTelefona != null)
            {
                foreach (BrojTelefonaView br in musterija.BrojeviTelefona)
                {
                    BrojTelefona broj = new BrojTelefona()
                    {
                        BrTel = br.BrTel,
                        PripadaRedovnojMusteriji = m
                    };
                    m.BrojeviTelefona?.Add(broj);
                    await s.SaveOrUpdateAsync(broj);
                }
            }
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce dodati musteriju.";
        }
        return true;
    }
    public static Result<List<BrojTelefonaView>,string> VratiBrojeveTelefonaMusterije(int id)
    {
        List<BrojTelefonaView> brtel = new List<BrojTelefonaView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<BrojTelefona> brojevi = from b in s.Query<BrojTelefona>() 
                                                where b.Id != null && b.PripadaRedovnojMusteriji != null && 
                                                b.PripadaRedovnojMusteriji.Id == id 
                                                select b;
            foreach(BrojTelefona b in brojevi)
            {
                brtel.Add(new BrojTelefonaView(b));
            }
            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti brojeve telefona musterije sa id-jem : {id}";
        }
        return brtel;
    }
    public static Result<double,string> VratiPopustMusterije(int musterijaId)
    {
        double Popust = 0;
        ISession? s = null;
        try
        {
            
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            bool isError = false;
            string error = null;
            RedovnaMusterijaView rv = new RedovnaMusterijaView();
            VratiMusteriju(musterijaId).Deconstruct(out isError, out rv, out error);
            if (isError)
            {
                return $"Greska prilikom vracanja podataka o musteriji : {error}";
            }
            int? brVoznji = rv?.BrojKoriscenihVoznji;
            if(brVoznji == null)
            {
                return "Doslo je do greske prilikom vracanja broja koriscenih voznji";
            }

            s.Close();
            
            if (brVoznji >= 5 && brVoznji < 15)
            {
                Popust = 0.15;
            }
            else if(brVoznji>=15 && brVoznji < 25)
            {
                Popust = 0.20;
            }
            else if(brVoznji >= 25)
            {
                Popust = 0.30;
            }
        }
        catch (Exception)
        {
            return $"Greska prilikom vracanja popusta musterije sa id-jem {musterijaId}";
        }
        return Popust;
    }
    #endregion

    #region Voznje
    public static async Task<Result<List<VoznjaView>,string>> VratiSveVoznjeAsync()
    {
        List<VoznjaView> voznje = new List<VoznjaView>();
        ISession? s = null;
        try
        {

            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Entiteti.Voznja> sveVoznje = from v in await s.QueryOver<Voznja>().ListAsync() 
                                                     select v;
            foreach(Entiteti.Voznja v in sveVoznje)
            {
                voznje.Add(new VoznjaView(v));
            }
        }
        catch (Exception)
        {
            return "Nemoguce vratiti podatke o svim voznjama";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return voznje;
    }
    public static Result<List<VoznjaView>,string> VratiVoznjeObavioVozac(string jmbgVozaca)
    {
        List<VoznjaView> voznje = new List<VoznjaView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Voznja> sveVoznjeVozaca = from v in s.Query<Voznja>()
                                                           where v.Id != null && v.PripadaVozacu != null && v.PripadaVozacu.Jmbg == jmbgVozaca
                                                           select v;
            foreach (Entiteti.Voznja v in sveVoznjeVozaca)
            {
                voznje.Add(new VoznjaView(v));
            }

            s.Close();
        }
        catch (Exception e)
        {
            return $"Nemoguce vratiti sve voznja vozaca : {jmbgVozaca}";
        }
        return voznje;
    }
    public static Result<List<VoznjaView>,string> VratiVoznjePrimioPozivAdmin(string jmbgAdmin)
    {
        List<VoznjaView> voznje = new List<VoznjaView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Voznja> sveVoznjeAdmina = from v in s.Query<Voznja>()
                                                           where v.Id!=null && v.PripadaAdministrativnomOsoblju != null && 
                                                           v.PripadaAdministrativnomOsoblju.Jmbg == jmbgAdmin
                                                           select v;
            foreach (Voznja v in sveVoznjeAdmina)
            {
                voznje.Add(new VoznjaView(v));
            }

            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti podatke o svim voznjama admina : {jmbgAdmin}";
        }
        return voznje;
    }
    public static Result<List<VoznjaView>,string> VratiVoznjeRedovneMusterije(int id)
    {
        List<VoznjaView> voznje = new List<VoznjaView>();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            IEnumerable<Entiteti.Voznja> sveVoznjeMusterije = from v in s.Query<Voznja>()
                                                              where v.Id != null && v.PripadaRedovnojMusteriji != null &&
                                                              v.PripadaRedovnojMusteriji.Id == id
                                                              select v;
            foreach (Entiteti.Voznja v in sveVoznjeMusterije)
            {
                voznje.Add(new VoznjaView(v));
            }

            s.Close();
        }
        catch (Exception)
        {
            return $"Nemoguce vratiti podatke o svim voznjama redovne musterije sa id-jem : {id}";
        }
        return voznje;
    }
    public static async Task<Result<bool,string>> DodajVoznjuAsync(VoznjaView voznja, string jmbgV, string jmbgA, int id = 0)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }

            Voznja v = new Voznja();

            v.PocetnaStanica = voznja.PocetnaStanica;
            v.KrajnjaStanica = voznja.KrajnjaStanica;
            v.PocetnoVreme = voznja.PocetnoVreme;
            v.KrajnjeVreme = voznja.KrajnjeVreme;
            v.BrojPoziva = voznja.BrojPoziva;
            v.VremePrimPoziva = voznja.VremePrimPoziva;

            Vozac vozac = await s.LoadAsync<Vozac>(jmbgV);
            AdministrativnoOsoblje admin = await s.LoadAsync<AdministrativnoOsoblje>(jmbgA);
            RedovnaMusterija musterija = await s.LoadAsync<RedovnaMusterija>(id);


            if(id != 0)
            {
                AzurirajMusterijuBrojVoznji(musterija.Id);
                v.PripadaRedovnojMusteriji = musterija;
            }

            v.PripadaVozacu = vozac;
            v.PripadaRedovnojMusteriji = null;
            v.PripadaAdministrativnomOsoblju = admin;

            await s.SaveOrUpdateAsync(v);
            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nemoguce dodati voznju.";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<bool,string>> ObrisiVoznjuAsync(int id)
    {
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            Voznja v = s.Load<Voznja>(id);

            await s.DeleteAsync(v);
            await s.FlushAsync();
        }
        catch (Exception e)
        {
            return $"Nemoguce obrisati voznju sa id-jem : {id}";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return true;
    }
    public static async Task<Result<List<KeyValuePair<string, int>>, string>> KreirajNoveRedovneMusterije()
    {
        List<VoznjaView> sveVoznje = new();
        List<KeyValuePair<string, int>> noveMusterije = new();
        ISession? s = null;
        try
        {
            s = DataLayer.GetSession();
            if (!(s?.IsConnected ?? false))
            {
                return "Nemoguce otvoriti sesiju.";
            }
            var brPozivaCounts = (await s.QueryOver<Voznja>().ListAsync())
                .Where(v => v.PripadaRedovnojMusteriji == null)
                .GroupBy(v => v.BrojPoziva)
                .Select(br => new KeyValuePair<string,int>(br.Key,br.Count()));

            foreach(var kvp in brPozivaCounts)
            {
                string brPoziva = kvp.Key;
                int count = kvp.Value;

                if(count >= 5) 
                {
                    RedovnaMusterija rm = new RedovnaMusterija();
                    rm.BrojKoriscenihVoznji = count;
                    rm.Adresa = "nepoznata";
                    await s.SaveOrUpdateAsync(rm);
                    BrojTelefona br = new BrojTelefona();
                    br.BrTel = brPoziva;
                    br.PripadaRedovnojMusteriji = rm;
                    await s.SaveOrUpdateAsync(br);
                    noveMusterije.Add(kvp);
                }
            }

            await s.FlushAsync();
        }
        catch (Exception)
        {
            return "Nije moguce kreiranje nove musterije";
        }
        finally
        {
            s?.Close();
            s?.Dispose();
        }
        return noveMusterije;
    }
    #endregion
}
