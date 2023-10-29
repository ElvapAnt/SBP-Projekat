using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_Udruzenje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdUcitavanjeVoznje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Taksi_Udruzenje.Entiteti.Voznja v = s.Load<Taksi_Udruzenje.Entiteti.Voznja>(3);

                MessageBox.Show(v.KrajnjeVreme.ToShortTimeString());

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDodavanjeVoznje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Voznja v = new Entiteti.Voznja();

                v.PocetnaStanica = "Rajiceva 30";
                v.KrajnjaStanica = "Aleksandra Medvedeva 14";
                v.PocetnoVreme = new DateTime(2023, 05, 10, 9, 10, 0);
                v.KrajnjeVreme = new DateTime(2023, 05, 10, 9, 20, 34);
                v.BrojPoziva = "0656000396";
                v.VremePrimPoziva = new DateTime(2023, 05, 10, 9, 6, 21);
                //prikazuje exception jer fale strani kljucevi za admina i vozaca koji ne smeju da budu null, odnosno ne mozemo da dodamo novu voznju bez njih
                s.Save(v);

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja v = s.Load<Voznja>(6);

                MessageBox.Show(v.PocetnaStanica);
                MessageBox.Show(v.KrajnjaStanica);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RedovnaMusterija r = s.Load<RedovnaMusterija>(4478);

                foreach(Voznja v in r.Voznje)
                {
                    MessageBox.Show(v.PocetnaStanica + " " + v.KrajnjaStanica + " " + v.PocetnoVreme + " " + v.KrajnjeVreme);
                }

                s.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdManyToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozac v1 = s.Load<Vozac>("5618819209125");

                foreach (TaxiVozilo t1 in v1.TaxiVozila)
                {
                    MessageBox.Show(t1.RegistarskaOznaka);
                }


                TaxiVozilo t2 = s.Load<TaxiVozilo>("BG8877TR");

                foreach (Vozac v2 in t2.Vozaci)
                {
                    MessageBox.Show(v2.Ime + " " + v2.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdUcitavanjeMusterije_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RedovnaMusterija m = s.Load<RedovnaMusterija>(3);

                MessageBox.Show(m.Adresa);

                s.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeSopVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SopstvenoVozilo m = s.Load<SopstvenoVozilo>(3);

                MessageBox.Show(m.TipVozila + " " + m.Boja);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeTaxiVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TaxiVozilo m = s.Load<TaxiVozilo>("NI1202RE");

                MessageBox.Show(m.Marka + " " + m.DatumIstekaRegistracije);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeZaposleni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje m = s.Load<AdministrativnoOsoblje>("3331111998235");

                MessageBox.Show(m.Ime + " " + m.Prezime + " " + m.StrucnaSprema);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeDodavanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dodeljeno m = s.Load<Dodeljeno>(1);

                MessageBox.Show(m.DatumOd.ToShortDateString() + " " + m.DatumDo + " " + m.VozacId);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdUcitavanjeBrTel_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                BrojTelefona m = s.Load<BrojTelefona>(1);

                MessageBox.Show(m.BrTel + " " + m.PripadaRedovnojMusteriji);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Voznja m = s.Load<Voznja>(1);

                MessageBox.Show(m.PocetnaStanica + " " + m.KrajnjaStanica);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
