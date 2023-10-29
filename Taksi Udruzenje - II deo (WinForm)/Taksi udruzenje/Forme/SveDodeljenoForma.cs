using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taksi_Udruzenje;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_udruzenje.Forme
{
    public partial class SveDodeljenoForma : Form
    {
        public SveDodeljenoForma()
        {
            InitializeComponent();
        }
        private void SveDodeljenoForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacimaVozac(string jmbg)
        {
            this.dodeljeno.Items.Clear();
            List<DodeljenoBasic> sveDodeljeno = DTOProvider.vratiSvaDodeljenaSaVozacem(jmbg);
            foreach (DodeljenoBasic d in sveDodeljeno)
            {
                ListViewItem item = new ListViewItem(new string[] { d.Id.ToString(),d.TaxiVozilo.RegistarskaOznaka,
                                                                    d.Vozac.Jmbg, d.DatumOd.ToShortDateString(), d.DatumDo.ToString()});
                this.dodeljeno.Items.Add(item);
            }
            this.dodeljeno.Refresh();
        }

        public void popuniPodacimaTaxi(string regOznaka)
        {
            this.dodeljeno.Items.Clear();
            List<DodeljenoBasic> sveDodeljeno = DTOProvider.vratiSvaDodeljenaSaTaxijem(regOznaka);
            foreach (DodeljenoBasic d in sveDodeljeno)
            {
                ListViewItem item = new ListViewItem(new string[] { d.Id.ToString(),d.TaxiVozilo.RegistarskaOznaka,
                                                                    d.Vozac.Jmbg, d.DatumOd.ToShortDateString(), d.DatumDo.ToString()});
                this.dodeljeno.Items.Add(item);
            }
            this.dodeljeno.Refresh();
        }

        public void popuniPodacima()
        {
            this.dodeljeno.Items.Clear();
            List<DodeljenoBasic> sveDodeljeno = DTOProvider.vratiSvaDodeljena();
            foreach (DodeljenoBasic d in sveDodeljeno)
            {
                ListViewItem item = new ListViewItem(new string[] { d.Id.ToString(),d.TaxiVozilo.RegistarskaOznaka, 
                                                                    d.Vozac.Jmbg, d.DatumOd.ToShortDateString(), d.DatumDo.ToString()});
                this.dodeljeno.Items.Add(item);
            }
            this.dodeljeno.Refresh();
        }

        private void btnDodajDodeljeno_Click(object sender, EventArgs e)
        {
            DodeljenoForma forma = new DodeljenoForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnPrikaziDodeljenoVozac_Click(object sender, EventArgs e)
        {
            if(txtJmbgVozaca.Text == "")
            {
                MessageBox.Show("Molimo Vas unesite JMBG vozaca!");
            }
            string jmbg = txtJmbgVozaca.Text;
            popuniPodacimaTaxi(jmbg);
        }

        private void btnPrikaziDodeljenoTaxi_Click(object sender, EventArgs e)
        {
            if (txtRegOznaka.Text == "")
            {
                MessageBox.Show("Molimo Vas unesite Reg. oznaku taxi vozila!");
                return;
            }
            string regOznaka = txtRegOznaka.Text;
            popuniPodacimaTaxi(regOznaka);
        }

        private void btnPrikaziTrenutniVozac_Click(object sender, EventArgs e)
        {
            if (txtRegOznaka.Text == "")
            {
                MessageBox.Show("Molimo Vas unesite Reg. oznaku taxi vozila!");
                return;
            }
            TaxiVoziloBasic taxi = DTOProvider.vratiTaxiVozilo(txtRegOznaka.Text);
            DodeljenoBasic db = DTOProvider.vratiTrenutnogVozacaVozila(taxi);
            MessageBox.Show($"Trenutni vozac je : {db.Vozac.ToString()}, JMBG : {db.Vozac.Jmbg}");
        }

        private void btnPrikaziTrenutnoVozilo_Click(object sender, EventArgs e)
        {
            if (txtRegOznaka.Text == "")
            {
                MessageBox.Show("Molimo Vas unesite JMBG vozaca!");
                return;
            }
            VozacBasic vozac = DTOProvider.vratiVozaca(txtJmbgVozaca.Text);
            DodeljenoBasic db = DTOProvider.vratiTrenutnoDodeljenoVoziloVozaca(vozac);
            MessageBox.Show($"Trenutno vozilo vozaca {vozac.ToString()} ima registraciju : {db.TaxiVozilo.RegistarskaOznaka}");
        }

        private void btnAzurirajDodeljeno_Click(object sender, EventArgs e)
        {
            if (dodeljeno.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite odnos koji zelite da azurirate!");
                return;
            }
            int id = Int32.Parse(dodeljeno.SelectedItems[0].SubItems[0].Text);
            DodeljenoBasic d = DTOProvider.vratiDodeljeno(id);
            AzurirajDodeljenoForma forma = new AzurirajDodeljenoForma(d);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
