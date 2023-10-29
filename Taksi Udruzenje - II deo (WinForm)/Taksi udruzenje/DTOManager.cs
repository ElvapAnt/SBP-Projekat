using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje
{
    public class DTOProvider
    {
        #region Zaposleni
        public static List<ZaposleniView> vratiSveZaposlene()
        {
            List<ZaposleniView> zaposleni = new List<ZaposleniView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Taksi_Udruzenje.Entiteti.Zaposleni> sviZaposleni = from z in s.Query<Taksi_Udruzenje.Entiteti.Zaposleni>()
                                                                               select z;
                foreach(Taksi_Udruzenje.Entiteti.Zaposleni z in sviZaposleni)
                {
                    zaposleni.Add(new ZaposleniView(z.Jmbg, z.Ime, z.SrednjeSlovo, z.Prezime, z.Adresa, z.BrojTelefona, z.TipZaposleni));
                }

                s.Close();
            }
            catch (Exception e)
            {
                //handle exception
            }

            return zaposleni;
        }

        #region Vozaci
        public static List<VozacView> vratiSveVozace()
        {
            List<VozacView> vozaci = new List<VozacView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vozac> sviVozaci = s.Query<Vozac>().ToList();

                foreach(Vozac v in sviVozaci)
                {
                    vozaci.Add(new VozacView(v.Jmbg, v.Ime, v.SrednjeSlovo, v.Prezime,
                                            v.Adresa, v.BrojTelefona, v.Kategorija, v.BrojDozovole));
                }

                s.Close();

            }
            catch (Exception ex)
            {
            }
            return vozaci;
        }
        public static void obrisiVozaca(string jmbgVozaca)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Vozac v = s.Load<Entiteti.Vozac>(jmbgVozaca);

                v.TaxiVozila.Clear();

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                //handle exception
            }
        }
        public static VozacBasic vratiVozaca(string jmbg)
        {
            VozacBasic v = new VozacBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Vozac vozac = s.Load<Entiteti.Vozac>(jmbg);

                v.Jmbg = vozac.Jmbg;
                v.Ime = vozac.Ime;
                v.SrednjeSlovo = vozac.SrednjeSlovo;
                v.Prezime = vozac.Prezime;
                v.BrojDozovole = vozac.BrojDozovole;
                v.Kategorija = vozac.Kategorija;
                v.Voznje = DTOProvider.vratiVoznjeObavioVozac(jmbg);

                s.Close();
            }
            catch (Exception ex)
            {
                //handle
            }

            return v;
        }
        public static void azurirajVozaca(VozacBasic vozac)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.Vozac v = s.Load<Vozac>(vozac.Jmbg);

                v.Ime = vozac.Ime;
                v.Prezime = vozac.Prezime;
                v.SrednjeSlovo = vozac.SrednjeSlovo;
                v.BrojDozovole = v.BrojDozovole;
                v.BrojTelefona = vozac.BrojTelefona;
                v.Adresa = vozac.Adresa;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void dodajVozaca(VozacBasic vozac)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Vozac v = new Vozac();
                v.Jmbg = vozac.Jmbg;
                v.Ime = vozac.Ime;
                v.SrednjeSlovo = vozac.SrednjeSlovo;
                v.Prezime = vozac.Prezime;
                v.Adresa = vozac.Adresa;
                v.BrojDozovole = vozac.BrojDozovole;
                v.BrojTelefona = vozac.BrojTelefona;
                v.Kategorija = vozac.Kategorija;
                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        #endregion

        #region AdministrativnaOsoblja
        public static List<AdministrativnoOsobljeView> vratiSveAdmine()
        {
            List<AdministrativnoOsobljeView> admini = new List<AdministrativnoOsobljeView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<AdministrativnoOsoblje> sviAdmini = s.Query<AdministrativnoOsoblje>().ToList();

                foreach (AdministrativnoOsoblje a in sviAdmini)
                {
                    admini.Add(new AdministrativnoOsobljeView(a.Jmbg, a.Ime, a.SrednjeSlovo, a.Prezime,
                                            a.Adresa, a.BrojTelefona, a.StrucnaSprema));
                }

                s.Close();

            }
            catch (Exception ex)
            {
            }
            return admini;
        }
        public static void obrisiAdmina(string jmbgAdmina)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.AdministrativnoOsoblje a = s.Load<Entiteti.AdministrativnoOsoblje>(jmbgAdmina);

                a.Voznje.Clear();

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                //handle exception
            }
        }
        public static AdministrativnoOsobljeBasic vratiAdmina(string jmbg)
        {
            AdministrativnoOsobljeBasic ab = new AdministrativnoOsobljeBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.AdministrativnoOsoblje admin = s.Load<Entiteti.AdministrativnoOsoblje>(jmbg);

                ab = new AdministrativnoOsobljeBasic(admin.Jmbg, admin.Ime, admin.SrednjeSlovo, admin.Prezime,
                                                    admin.Adresa, admin.BrojTelefona, admin.StrucnaSprema);
                
                ab.Voznje = DTOProvider.vratiVoznjePrimioPozivAdmin(jmbg);
                
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }

            return ab;
        }
        public static void azurirajAdmina(AdministrativnoOsobljeBasic admin)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.AdministrativnoOsoblje a = s.Load<AdministrativnoOsoblje>(admin.Jmbg);
                a.Ime = admin.Ime;
                a.Prezime = admin.Prezime;
                a.StrucnaSprema = admin.StrucnaSprema;
                a.BrojTelefona = admin.BrojTelefona;
                a.Adresa = admin.Adresa;

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void dodajAdmina(AdministrativnoOsobljeBasic admin)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                AdministrativnoOsoblje a = new AdministrativnoOsoblje();
                a.Jmbg = admin.Jmbg;
                a.Ime = admin.Ime;
                a.SrednjeSlovo = admin.SrednjeSlovo;
                a.Prezime = admin.Prezime;
                a.BrojTelefona = admin.BrojTelefona;
                a.StrucnaSprema = admin.StrucnaSprema;

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }

        #endregion

        #endregion

        #region TaxiVozila
        public static List<TaxiVoziloView> vratiSvaTaxiVozila()
        {
            List<TaxiVoziloView> taxiVozila = new List<TaxiVoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.TaxiVozilo> svaTaxiVozila = from tv in s.Query<Entiteti.TaxiVozilo>() 
                                                                 select tv;

                foreach(Entiteti.TaxiVozilo tv in svaTaxiVozila)
                {
                    taxiVozila.Add(new TaxiVoziloView(tv.RegistarskaOznaka, tv.Marka, tv.Tip, 
                                                      tv.DatumIstekaRegistracije, tv.GodinaProizvodnje));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }

            return taxiVozila;
        }
        public static void obrisiTaxiVozilo(string regOznaka)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.TaxiVozilo tv = s.Load<Entiteti.TaxiVozilo>(regOznaka);

                tv.Vozaci.Clear();

                s.Delete(tv);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                //handle exception
            }
        }
        public static TaxiVoziloBasic vratiTaxiVozilo(string regOznaka)
        {
            TaxiVoziloBasic tv = new TaxiVoziloBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.TaxiVozilo taxiVozilo = s.Load<Entiteti.TaxiVozilo>(regOznaka);

                tv.RegistarskaOznaka = taxiVozilo.RegistarskaOznaka;
                tv.Marka = taxiVozilo.Marka;
                tv.Tip = taxiVozilo.Tip;
                tv.DatumIstekaRegistracije = taxiVozilo.DatumIstekaRegistracije;
                tv.GodinaProizvodnje = taxiVozilo.GodinaProizvodnje;
                
           
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }

            return tv;
        }
        public static void azurirajTaxiVozilo(TaxiVoziloBasic taxiVozilo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.TaxiVozilo tv = s.Load<TaxiVozilo>(taxiVozilo.RegistarskaOznaka);
                tv.DatumIstekaRegistracije = taxiVozilo.DatumIstekaRegistracije;
                tv.Marka = taxiVozilo.Marka;
                tv.Tip = taxiVozilo.Marka;
                tv.GodinaProizvodnje = tv.GodinaProizvodnje;
                s.SaveOrUpdate(tv);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void dodajTaxiVozilo(TaxiVoziloBasic taxi)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.TaxiVozilo tv = new TaxiVozilo();

                tv.RegistarskaOznaka = taxi.RegistarskaOznaka;
                tv.Marka = taxi.Marka;
                tv.Tip = taxi.Tip;
                tv.DatumIstekaRegistracije = taxi.DatumIstekaRegistracije;
                tv.GodinaProizvodnje = taxi.GodinaProizvodnje;

                s.SaveOrUpdate(tv);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }

        #endregion

        #region Dodeljeno
        public static List<DodeljenoBasic> vratiSvaDodeljena()
        {
            List<DodeljenoBasic> dodeljeno = new List<DodeljenoBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Taksi_Udruzenje.Entiteti.Dodeljeno> sveDodeljeno = s.Query<Dodeljeno>().ToList();
                foreach (Taksi_Udruzenje.Entiteti.Dodeljeno d in sveDodeljeno)
                {
                    TaxiVoziloBasic taxi = vratiTaxiVozilo(d.TaxiVoziloId.RegistarskaOznaka);
                    VozacBasic vozac = vratiVozaca(d.VozacId.Jmbg);
                    dodeljeno.Add(new DodeljenoBasic(d.Id, d.DatumOd, d.DatumDo, taxi, vozac));
                }

                s.Close();
            }
            catch (Exception e)
            {
                //handle exception
            }

            return dodeljeno;
        }
        public static List<DodeljenoBasic> vratiSvaDodeljenaSaVozacem(string jmbgVozaca)
        {
            List<DodeljenoBasic> dodeljeno = new List<DodeljenoBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Dodeljeno> svaDodeljena = from d in s.Query<Dodeljeno>()
                                                               where d.VozacId.Jmbg == jmbgVozaca
                                                               select d;

                foreach (Dodeljeno d in svaDodeljena)
                {
                    TaxiVoziloBasic taxi = DTOProvider.vratiTaxiVozilo(d.TaxiVoziloId.RegistarskaOznaka);
                    VozacBasic vozac = DTOProvider.vratiVozaca(d.VozacId.Jmbg);
                    dodeljeno.Add(new DodeljenoBasic(d.Id, d.DatumOd, d.DatumDo, taxi, vozac));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return dodeljeno;
        }
        public static List<DodeljenoBasic> vratiSvaDodeljenaSaTaxijem(string regOznaka)
        {
            List<DodeljenoBasic> dodeljeno = new List<DodeljenoBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Dodeljeno> svaDodeljena = from d in s.Query<Dodeljeno>()
                                                               where d.TaxiVoziloId.RegistarskaOznaka == regOznaka
                                                               select d;

                foreach(Dodeljeno d in svaDodeljena)
                {
                    TaxiVoziloBasic taxi = DTOProvider.vratiTaxiVozilo(d.TaxiVoziloId.RegistarskaOznaka);
                    VozacBasic vozac = DTOProvider.vratiVozaca(d.VozacId.Jmbg);
                    dodeljeno.Add(new DodeljenoBasic(d.Id, d.DatumOd, d.DatumDo, taxi, vozac));
                }

                s.Close();
            }
            catch (Exception e)
            { 
            }
            return dodeljeno;
        }
        public static DodeljenoBasic vratiTrenutnoDodeljenoVoziloVozaca(VozacBasic vozac)
        {
            DodeljenoBasic dv = new DodeljenoBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Dodeljeno dodeljeno = (Dodeljeno)
                                               from d in s.Query<Dodeljeno>()
                                               where d.VozacId.Jmbg == vozac.Jmbg
                                               where d.DatumDo == null
                                               select d;

                TaxiVoziloBasic tv = DTOProvider.vratiTaxiVozilo(dodeljeno.TaxiVoziloId.RegistarskaOznaka);
              
                dv = new DodeljenoBasic(dodeljeno.Id, dodeljeno.DatumOd, dodeljeno.DatumDo, tv, vozac);

                s.Close();
            }
            catch (Exception e)
            {
            }

            return dv;
        }
        public static DodeljenoBasic vratiTrenutnogVozacaVozila(TaxiVoziloBasic taxi)
        {
            DodeljenoBasic dv = new DodeljenoBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Dodeljeno dodeljeno = (Dodeljeno)
                                               from d in s.Query<Dodeljeno>()
                                               where d.TaxiVoziloId.RegistarskaOznaka == taxi.RegistarskaOznaka
                                               where d.DatumDo == null
                                               select d;


                VozacBasic v = DTOProvider.vratiVozaca(dodeljeno.VozacId.Jmbg);
                
                dv = new DodeljenoBasic(dodeljeno.Id, dodeljeno.DatumOd, dodeljeno.DatumDo, taxi, v);

                s.Close();
            }
            catch (Exception e)
            {
            }
            return dv;
        }
        public static void sacuvajDodeljeno(DodeljenoBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Taksi_Udruzenje.Entiteti.Dodeljeno> sveDodeljeno = s.Query<Dodeljeno>().ToList();
                
                foreach(Dodeljeno dod in sveDodeljeno )
                {
                    if(d.TaxiVozilo.RegistarskaOznaka == dod.TaxiVoziloId.RegistarskaOznaka
                        && dod.DatumDo != null)
                    {
                        MessageBox.Show("Taxi vozilo je vec dodeljeno!");
                        return;
                    }
                }

                Entiteti.Dodeljeno dodeljeno = new Entiteti.Dodeljeno();

                dodeljeno.TaxiVoziloId = s.Load<TaxiVozilo>(d.TaxiVozilo.RegistarskaOznaka);
                dodeljeno.VozacId = s.Load<Vozac>(d.Vozac.Jmbg);
                dodeljeno.DatumDo = d.DatumDo;
                dodeljeno.DatumOd = d.DatumOd;

                s.SaveOrUpdate(dodeljeno);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
            }
        }
        public static void azurirajDodeljeno(DodeljenoBasic d)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.Dodeljeno dodeljeno = s.Load<Dodeljeno>(d.Id);
                dodeljeno.TaxiVoziloId = s.Load<TaxiVozilo>(d.TaxiVozilo.RegistarskaOznaka);
                dodeljeno.VozacId = s.Load<Vozac>(d.Vozac.Jmbg);
                dodeljeno.DatumDo = d.DatumDo.Value;

                s.SaveOrUpdate(dodeljeno);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static DodeljenoBasic vratiDodeljeno(int id)
        {
            DodeljenoBasic d = new DodeljenoBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Dodeljeno dodeljeno = s.Load<Entiteti.Dodeljeno>(id);

                d.TaxiVozilo = vratiTaxiVozilo(dodeljeno.TaxiVoziloId.RegistarskaOznaka);
                d.Vozac = vratiVozaca(dodeljeno.VozacId.Jmbg);
                d.DatumOd = dodeljeno.DatumOd;
                d.DatumDo = dodeljeno.DatumDo;

                s.Close();
            }
            catch (Exception ex)
            {
                //handle
            }

            return d;
        }
        #endregion

        #region SopstvenaVozila
        public static List<SopstvenoVoziloBasic> vratiSvaSopVozilaVozaca(VozacBasic vozac)
        {
            List<SopstvenoVoziloBasic> sopVozila = new List<SopstvenoVoziloBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SopstvenoVozilo> svaSopVozila = from v in s.Query<Entiteti.SopstvenoVozilo>()
                                                            where v.PripadaVozacu.Jmbg == vozac.Jmbg
                                                            select v;

                foreach (SopstvenoVozilo sv in svaSopVozila)
                {
                    sopVozila.Add(new SopstvenoVoziloBasic(sv.Id, vozac.ToString(), sv.TipVozila, sv.Boja, 
                                                          sv.Marka, sv.DatumOd, sv.DatumDo));
                }

                s.Close();

            }
            catch (Exception ex)
            {
            }
            return sopVozila;
        }
        public static List<SopstvenoVoziloView> vratiSvaSopVozila()
        {
            List<SopstvenoVoziloView> sopVozila = new List<SopstvenoVoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SopstvenoVozilo> svaSopVozila = from v in s.Query<Entiteti.SopstvenoVozilo>()
                                                            select v;

                foreach (SopstvenoVozilo sv in svaSopVozila)
                {
                    sopVozila.Add(new SopstvenoVoziloView(sv.Id, sv.TipVozila, sv.Boja,
                                                          sv.Marka, sv.DatumOd, sv.DatumDo));
                }

                s.Close();

            }
            catch (Exception ex)
            {
            }
            return sopVozila;
        }
        public static void obrisiSopVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.SopstvenoVozilo v = s.Load<Entiteti.SopstvenoVozilo>(id);

                s.Delete(v);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                //handle exception
            }
        }
        public static SopstvenoVoziloBasic vratiSopstvenoVozilo(int id)
        {
            SopstvenoVoziloBasic sv = new SopstvenoVoziloBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.SopstvenoVozilo sopvozilo = s.Load<Entiteti.SopstvenoVozilo>(id);
                sv.SopVoziloId = sopvozilo.Id;
                sv.TipVozila = sopvozilo.TipVozila;
                sv.Boja = sopvozilo.Boja;
                sv.Marka = sopvozilo.Marka;
                sv.DatumDo = sopvozilo.DatumDo;
                sv.DatumOd = sopvozilo.DatumOd;

                s.Close();
            }
            catch (Exception ex)
            {
                //handle
            }

            return sv;
        }
        public static void azurirajSopVozilo(SopstvenoVoziloBasic sopVozilo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.SopstvenoVozilo sv = s.Load<SopstvenoVozilo>(sopVozilo.SopVoziloId);
                sv.DatumDo = sopVozilo.DatumDo;
                sv.Boja = sopVozilo.Boja;
                sv.TipVozila = sopVozilo.TipVozila;
                sv.Marka = sopVozilo.Marka;
                s.SaveOrUpdate(sv);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void dodajSopstvenoVozilo(SopstvenoVoziloBasic svozilo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SopstvenoVozilo sv = new SopstvenoVozilo();
                sv.TipVozila = svozilo.TipVozila;
                sv.Boja = svozilo.TipVozila;
                sv.Marka = svozilo.Marka;
                sv.DatumOd = svozilo.DatumOd;
                sv.DatumDo = svozilo.DatumDo;
                sv.PripadaVozacu = s.Load<Vozac>(svozilo.PripadaVozacu.Jmbg);

                s.SaveOrUpdate(sv);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        #endregion

        #region RedovneMusterije
        public static List<RedovnaMusterijaView> vratiSveRedovneMusterije()
        {
            List<RedovnaMusterijaView> musterije = new List<RedovnaMusterijaView>();
            
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Taksi_Udruzenje.Entiteti.RedovnaMusterija> sveMusterije = from m in s.Query<Taksi_Udruzenje.Entiteti.RedovnaMusterija>()
                                                                                      select m;
                foreach (Taksi_Udruzenje.Entiteti.RedovnaMusterija m in sveMusterije)
                {
                    musterije.Add(new RedovnaMusterijaView(m.Id,m.Adresa,m.BrojKoriscenihVoznji));
                }

                s.Close();
            }
            catch (Exception e)
            {
                //handle exception
            }

            return musterije;
        }
        public static RedovnaMusterijaBasic vratiMusteriju(int id)
        {
            RedovnaMusterijaBasic m = new RedovnaMusterijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.RedovnaMusterija musterija = s.Load<Entiteti.RedovnaMusterija>(id);

                m.RedMusterijaId = musterija.Id;
                m.Adresa = musterija.Adresa;
                m.BrojKoriscenihVoznji = musterija.BrojKoriscenihVoznji;
                m.BrojeviTelefona = DTOProvider.vratiBrojeveTelefonaMusterije(id);

                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }

            return m;
        }
        public static void azurirajMusteriju(RedovnaMusterijaBasic musterija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.RedovnaMusterija m = s.Load<RedovnaMusterija>(musterija.RedMusterijaId);
                m.Adresa = musterija.Adresa;
                m.BrojKoriscenihVoznji = musterija.BrojKoriscenihVoznji;

                s.SaveOrUpdate(m);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void azurirajMusterijuBrojVoznji(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.RedovnaMusterija m = s.Load<RedovnaMusterija>(id);
                m.BrojKoriscenihVoznji++;

                s.SaveOrUpdate(m);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static void dodajMusteriju(RedovnaMusterijaBasic musterija, string brojTelefona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RedovnaMusterija m = new RedovnaMusterija();
                m.Adresa = musterija.Adresa;
                m.BrojKoriscenihVoznji = musterija.BrojKoriscenihVoznji;

                BrojTelefona br = new BrojTelefona();
                br.BrTel = brojTelefona;
             
                br.PripadaRedovnojMusteriji = m;
                m.BrojeviTelefona.Add(br);

                s.SaveOrUpdate(m);

                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                //handle
            }
        }
        public static List<BrojTelefonaBasic> vratiBrojeveTelefonaMusterije(int id)
        {
            List<BrojTelefonaBasic> brtel = new List<BrojTelefonaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<BrojTelefona> brojevi = from b in s.Query<BrojTelefona>() 
                                                    where b.PripadaRedovnojMusteriji.Id == id 
                                                    select b;
                foreach(BrojTelefona b in brojevi)
                {
                    brtel.Add(new BrojTelefonaBasic(b.Id, b.BrTel));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return brtel;
        }
        public static double vratiPopustMusterije(int musterijaId)
        {
            double Popust = 0;
            try
            {
                ISession s = DataLayer.GetSession();
                RedovnaMusterijaBasic musterija = vratiMusteriju(musterijaId);
                int brVoznji = musterija.BrojKoriscenihVoznji;
                s.Close();
                
                if (brVoznji >= 5 && brVoznji < 20)
                {
                    Popust = 0.15;
                }
                else if(brVoznji>=20 && brVoznji < 35)
                {
                    Popust = 0.20;
                }
                else if(brVoznji >= 35)
                {
                    Popust = 0.30;
                }
            }
            catch (Exception e)
            {
            }

            return Popust;
        }
        #endregion

        #region Voznje
        public static List<VoznjaView> vratiSveVoznje()
        {
            List<VoznjaView> voznje = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznje = from v in s.Query<Voznja>() 
                                                         select v;
                foreach(Entiteti.Voznja v in sveVoznje)
                {
                    voznje.Add(new VoznjaView(v.Id, v.PocetnaStanica, v.KrajnjaStanica, v.PocetnoVreme,
                                              v.KrajnjeVreme, v.BrojPoziva, v.VremePrimPoziva));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return voznje;
        }
        public static List<VoznjaBasic> vratiVoznjeObavioVozac(string jmbgVozaca)
        {
            List<VoznjaBasic> voznje = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznjeVozaca = from v in s.Query<Voznja>()
                                                         where v.PripadaVozacu.Jmbg == jmbgVozaca
                                                         select v;
                foreach (Entiteti.Voznja v in sveVoznjeVozaca)
                {
                    voznje.Add(new VoznjaBasic(v.Id, v.PocetnaStanica, v.KrajnjaStanica, v.PocetnoVreme,
                                              v.KrajnjeVreme, v.BrojPoziva, v.VremePrimPoziva));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return voznje;
        }
        public static List<VoznjaBasic> vratiVoznjePrimioPozivAdmin(string jmbgAdmin)
        {
            List<VoznjaBasic> voznje = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznjeAdmina = from v in s.Query<Voznja>()
                                                               where v.PripadaAdministrativnomOsoblju.Jmbg == jmbgAdmin
                                                               select v;
                foreach (Entiteti.Voznja v in sveVoznjeAdmina)
                {
                    voznje.Add(new VoznjaBasic(v.Id, v.PocetnaStanica, v.KrajnjaStanica, v.PocetnoVreme,
                                              v.KrajnjeVreme, v.BrojPoziva, v.VremePrimPoziva));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return voznje;
        }
        public static List<VoznjaBasic> vratiVoznjeRedovneMusterije(int id)
        {
            List<VoznjaBasic> voznje = new List<VoznjaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznjeMusterije = from v in s.Query<Voznja>()
                                                               where v.PripadaRedovnojMusteriji.Id == id
                                                               select v;
                foreach (Entiteti.Voznja v in sveVoznjeMusterije)
                {
                    voznje.Add(new VoznjaBasic(v.Id, v.PocetnaStanica, v.KrajnjaStanica, v.PocetnoVreme,
                                              v.KrajnjeVreme, v.BrojPoziva, v.VremePrimPoziva));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return voznje;
        }
        public static void dodajVoznju(VoznjaBasic voznja)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Voznja v = new Voznja();

                v.PocetnaStanica = voznja.PocetnaStanica;
                v.KrajnjaStanica = voznja.KrajnjaStanica;
                v.PocetnoVreme = voznja.PocetnoVreme;
                v.KrajnjeVreme = voznja.KrajnjeVreme;
                v.BrojPoziva = voznja.BrojPoziva;
                v.VremePrimPoziva = voznja.VremePrimPoziva;

                Entiteti.Vozac vozac = s.Load<Vozac>(voznja.PripadaVozacu.Jmbg);
                Entiteti.AdministrativnoOsoblje admin = s.Load<AdministrativnoOsoblje>(voznja.PripadaAdministrativnomOsoblju.Jmbg);
                Entiteti.RedovnaMusterija musterija = s.Load<RedovnaMusterija>(voznja.PripadaRedovnojMusteriji.RedMusterijaId);

                if(musterija != null)
                {
                    DTOProvider.azurirajMusterijuBrojVoznji(musterija.Id);
                }

                v.PripadaVozacu = vozac;
                v.PripadaRedovnojMusteriji = musterija;
                v.PripadaAdministrativnomOsoblju = admin;

                s.SaveOrUpdate(v);

                s.Flush();

                s.Close();
            }
            catch (Exception e)
            {
            }
        }
        public static void obrisiVoznju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Voznja v = s.Load<Voznja>(id);

                s.Delete(v);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {

            }
        }
        public static List<VoznjaView> vratiSveVoznjeOdDo(DateTime odDatuma, DateTime doDatuma)
        {
            List<VoznjaView> voznjeOdDo = new List<VoznjaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Entiteti.Voznja> sveVoznjeOdDo = from v in s.Query<Voznja>()
                                                             where v.PocetnoVreme >= odDatuma && v.KrajnjeVreme <= doDatuma
                                                             select v;
                foreach(Voznja v in sveVoznjeOdDo)
                {
                    voznjeOdDo.Add(new VoznjaView(v.Id, v.PocetnaStanica, v.KrajnjaStanica, v.PocetnoVreme, 
                                                  v.KrajnjeVreme, v.BrojPoziva, v.VremePrimPoziva));
                }

                s.Close();
            }
            catch (Exception e)
            {
            }
            return voznjeOdDo;
        } 
        #endregion
    }
}
