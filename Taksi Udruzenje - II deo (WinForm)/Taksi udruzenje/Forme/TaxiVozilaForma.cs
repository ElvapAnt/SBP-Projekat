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
    public partial class TaxiVozilaForma : Form
    {
        public TaxiVozilaForma()
        {
            InitializeComponent();
        }

        private void TaxiVozilaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.taxiVozila.Items.Clear();
            List<TaxiVoziloView> sviTaxi = DTOProvider.vratiSvaTaxiVozila();
            foreach (TaxiVoziloView tv in sviTaxi)
            {
                ListViewItem item = new ListViewItem(new string[] { tv.RegistarskaOznaka, tv.Tip,tv.Marka,tv.DatumIstekaRegistracije.ToShortDateString(),tv.GodinaProizvodnje.ToString()});
                this.taxiVozila.Items.Add(item);
            }
            this.taxiVozila.Refresh();
        }

        private void btnDodajSopVozilo_Click(object sender, EventArgs e)
        {
            DodajTaxiVoziloForma forma = new DodajTaxiVoziloForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (taxiVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite taxi vozilo koje zelite da obrisete!");
                return;
            }

            string regoznaka = taxiVozila.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabrano sopstveno vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOProvider.obrisiTaxiVozilo(regoznaka);
                MessageBox.Show("Brisanje taxi vozila je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            if (taxiVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite taxi vozilo koje zelite da izmenite!");
                return;
            }
            string regOznaka = taxiVozila.SelectedItems[0].SubItems[0].Text;
            TaxiVoziloBasic tv = DTOProvider.vratiTaxiVozilo(regOznaka);
            AzurirajTaxiForma forma = new AzurirajTaxiForma(tv);
            forma.ShowDialog();
            popuniPodacima();

        }

        private void btnDodeliTaxiVozilo_Click(object sender, EventArgs e)
        {
            if (taxiVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite taxi vozilo koje zelite da dodelite!");
                return;
            }
            string regOznaka = taxiVozila.SelectedItems[0].SubItems[0].Text;
            TaxiVoziloBasic tv = DTOProvider.vratiTaxiVozilo(regOznaka);
            DodeljenoForma forma = new DodeljenoForma(tv);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
