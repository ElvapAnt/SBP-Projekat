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
    public partial class VozaciForma : Form
    {

        public VozaciForma()
        {
            InitializeComponent();
        }

        private void VozaciForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.vozaci.Items.Clear();
            List<VozacView> vozaci = DTOProvider.vratiSveVozace();

            foreach (VozacView v in vozaci)
            {
                ListViewItem item = new ListViewItem(new string[] { v.Jmbg, v.Ime, v.SrednjeSlovo.ToString(), v.Prezime, v.Adresa, v.BrojTelefona, v.BrojDozovole, v.Kategorija.ToString()});
                this.vozaci.Items.Add(item);
            }

            this.vozaci.Refresh();
        }

        private void btnDodajNovogVozaca_Click(object sender, EventArgs e)
        {
            DodajVozacaForma forma = new DodajVozacaForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca koga zelite da obrisete!");
                return;
            }

            string jmbgVozaca = vozaci.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog vozaca?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOProvider.obrisiVozaca(jmbgVozaca);
                MessageBox.Show("Brisanje vozaca je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnAzurirajVozaca_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca kog zelite da izmenite!");
                return;
            }
            string jmbgVozaca = vozaci.SelectedItems[0].SubItems[0].Text;
            VozacBasic v = DTOProvider.vratiVozaca(jmbgVozaca);
            AzurirajVozacaForma forma = new AzurirajVozacaForma(v);
            forma.ShowDialog();
            popuniPodacima();

        }

        private void btnPrikaziSopVozila_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca cija vozila zelite da pregledate!");
                return;
            }
            string jmbgVozaca = vozaci.SelectedItems[0].SubItems[0].Text;
            VozacBasic v = DTOProvider.vratiVozaca(jmbgVozaca);
            SopstvenaVozilaForma forma = new SopstvenaVozilaForma(v);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SopstvenaVozilaForma forma = new SopstvenaVozilaForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnVoznjeObavioVozac_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca cije voznje zelite da pregledate!");
                return;
            }
            string jmbgVozaca = vozaci.SelectedItems[0].SubItems[0].Text;
            VozacBasic v = DTOProvider.vratiVozaca(jmbgVozaca);
            SveVoznjeForma forma = new SveVoznjeForma(v);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnDodeliVozacuVozilo_Click(object sender, EventArgs e)
        {
            if (vozaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozaca kome zelite vozilo da dodelite!");
                return;
            }
            string jmbg = vozaci.SelectedItems[0].SubItems[0].Text;
            VozacBasic v = DTOProvider.vratiVozaca(jmbg);
            DodeljenoForma forma = new DodeljenoForma(v);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
