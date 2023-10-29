using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taksi_Udruzenje;

namespace Taksi_udruzenje.Forme
{
    public partial class SveVoznjeForma : Form
    {
        AdministrativnoOsobljeBasic admin = null;
        VozacBasic vozac = null;
        List<VoznjaBasic> sveVoznje;


        public int brojVoznji;

        public SveVoznjeForma()
        {
            InitializeComponent();
        }

        public SveVoznjeForma(AdministrativnoOsobljeBasic admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        public SveVoznjeForma(VozacBasic vozac)
        {
            this.vozac = vozac;
            InitializeComponent();
        }

        private void SveVoznjeForma_Load(object sender, EventArgs e)
        {
            if(admin != null)
            {
                popuniPodacimaSaAdminom();
                groupBox1.Text += " - primio poziv " + admin.ToString();
            }
            else if(vozac != null)
            {
                popuniPodacimaSaVozacem();
                groupBox1.Text += " - obavio " + vozac.ToString();
            }
            else
            {
                popuniPodacima();
            }
        }

        public void popuniPodacimaSaVozacem()
        {
            this.brojVoznji = 0;
            this.voznje.Items.Clear();
            sveVoznje = DTOProvider.vratiVoznjeObavioVozac(vozac.Jmbg);

            foreach (VoznjaBasic v in sveVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoznjaId.ToString(), v.PocetnaStanica, v.KrajnjaStanica,
                    v.PocetnoVreme.ToShortDateString(), v.KrajnjeVreme.ToShortDateString(), v.BrojPoziva, v.VremePrimPoziva.ToShortTimeString()});
                this.voznje.Items.Add(item);
                this.brojVoznji++;
            }
            txtUkupanBrVoznji.Text = this.brojVoznji.ToString();
            this.voznje.Refresh();
        }

        public void popuniPodacimaSaAdminom()
        {
            this.brojVoznji = 0;
            this.voznje.Items.Clear();
            sveVoznje = DTOProvider.vratiVoznjePrimioPozivAdmin(admin.Jmbg);

            foreach (VoznjaBasic v in sveVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoznjaId.ToString(), v.PocetnaStanica, v.KrajnjaStanica,
                    v.PocetnoVreme.ToShortTimeString(), v.KrajnjeVreme.ToShortTimeString(), v.BrojPoziva, v.VremePrimPoziva.ToShortTimeString()});
                this.voznje.Items.Add(item);
                this.brojVoznji++;
            }

            txtUkupanBrVoznji.Text = this.brojVoznji.ToString();
            this.voznje.Refresh();
        }

        public void popuniPodacima()
        {
            this.brojVoznji = 0;
            this.voznje.Items.Clear();
            List<VoznjaView> sveVoznje = DTOProvider.vratiSveVoznje();

            foreach (VoznjaView v in sveVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoznjaId.ToString(), v.PocetnaStanica, v.KrajnjaStanica, 
                    v.PocetnoVreme.ToShortTimeString(), v.KrajnjeVreme.ToShortTimeString(), v.BrojPoziva, v.VremePrimPoziva.ToShortTimeString()});
                this.voznje.Items.Add(item);
                this.brojVoznji++;
            }
            txtUkupanBrVoznji.Text = this.brojVoznji.ToString();
            this.voznje.Refresh();
        }
        public void popuniPodacimaOdDo(DateTime datumOd, DateTime datumDo)
        {
            this.brojVoznji = 0;
            this.voznje.Items.Clear();
            List<VoznjaView> sveVoznje = DTOProvider.vratiSveVoznjeOdDo(datumOd,datumDo);

            foreach (VoznjaView v in sveVoznje)
            {
                ListViewItem item = new ListViewItem(new string[] { v.VoznjaId.ToString(), v.PocetnaStanica, v.KrajnjaStanica,
                    v.PocetnoVreme.ToShortTimeString(), v.KrajnjeVreme.ToShortTimeString(), v.BrojPoziva, v.VremePrimPoziva.ToShortTimeString()});
                this.voznje.Items.Add(item);
                this.brojVoznji++;
            }
            txtUkupanBrVoznji.Text = this.brojVoznji.ToString();
            this.voznje.Refresh();
        }

        private void btnDodajVoznju_Click(object sender, EventArgs e)
        {
            DodajVoznjuForma forma = new DodajVoznjuForma(vozac,admin);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiVoznju_Click(object sender, EventArgs e)
        {
            if (voznje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite voznju koju zelite da obrisete iz baze podataka!");
                return;
            }

            int id = Int32.Parse(this.voznje.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu voznju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOProvider.obrisiVoznju(id);
                MessageBox.Show("Brisanje voznje je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void voznje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrikaziVoznjeOdDo_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Voznje od " + dateOd.Value.ToShortDateString() + " do " + dateDo.Value.ToShortDateString();
            popuniPodacimaOdDo(dateOd.Value, dateDo.Value);
        }
    }
}
