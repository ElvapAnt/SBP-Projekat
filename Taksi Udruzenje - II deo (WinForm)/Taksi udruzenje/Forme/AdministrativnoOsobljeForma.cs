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
    public partial class AdministrativnoOsobljeForma : Form
    {

        public AdministrativnoOsobljeForma()
        {
            InitializeComponent();
        }

        private void AdminOsobljeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.admini.Items.Clear();
            List<AdministrativnoOsobljeView> admini = DTOProvider.vratiSveAdmine();

            foreach (AdministrativnoOsobljeView a in admini)
            {
                ListViewItem item = new ListViewItem(new string[] { a.Jmbg, a.Ime, a.SrednjeSlovo.ToString(), a.Prezime, a.Adresa, a.BrojTelefona, a.StrucnaSprema });
                this.admini.Items.Add(item);
            }

            this.admini.Refresh();
        }

        private void btnDodajNovogAdmina_Click(object sender, EventArgs e)
        {
            DodajAdminaForma forma = new DodajAdminaForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiAdmina_Click(object sender, EventArgs e)
        {
            if (admini.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            string jmbgAdmina = admini.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranog admina?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOProvider.obrisiAdmina(jmbgAdmina);
                MessageBox.Show("Brisanje administrativnog osoblja je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnAzurirajAdmina_Click(object sender, EventArgs e)
        {
            if (admini.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite administrativno osoblje koje zelite da izmenite!");
                return;
            }
            string jmbgAdmina = admini.SelectedItems[0].SubItems[0].Text;
            AdministrativnoOsobljeBasic a = DTOProvider.vratiAdmina(jmbgAdmina);
            AzurirajAdminaForma forma = new AzurirajAdminaForma(a);
            forma.ShowDialog();
            popuniPodacima();

        }

        private void btnVratiVoznjaAdmina_Click(object sender, EventArgs e)
        {
            if (admini.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite administrativno osoblje cije voznje zelite da pregledate!");
                return;
            }
            string jmbgAdmina = admini.SelectedItems[0].SubItems[0].Text;
            AdministrativnoOsobljeBasic a = DTOProvider.vratiAdmina(jmbgAdmina);
            SveVoznjeForma forma = new SveVoznjeForma(a);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
