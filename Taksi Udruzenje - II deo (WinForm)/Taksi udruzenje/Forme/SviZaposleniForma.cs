using NHibernate.Mapping;
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
    public partial class SviZaposleniForma : Form
    {
        public SviZaposleniForma()
        {
            InitializeComponent();
        }

        public int brojZaposlenih = 0;

        private void SviZaposleniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;
            this.zaposleni.Items.Clear();
           
            List<ZaposleniView> listaZaposlenih = DTOProvider.vratiSveZaposlene();
         
            
            foreach (ZaposleniView z in listaZaposlenih)
            {
                ListViewItem item = new ListViewItem(new string[] { z.Jmbg, z.Ime, z.SrednjeSlovo.ToString(), z.Prezime, z.Adresa, z.BrojTelefona, z.TipZaposlenog });
                this.zaposleni.Items.Add(item);
                this.brojZaposlenih++;
            }

            txbBrojZaposlenih.Text = this.brojZaposlenih.ToString();
            this.zaposleni.Refresh();
        }

        private void btnAdmini_Click(object sender, EventArgs e)
        {
            AdministrativnoOsobljeForma forma = new AdministrativnoOsobljeForma();
            forma.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVozaci_Click(object sender, EventArgs e)
        {
            VozaciForma forma = new VozaciForma();
            forma.ShowDialog();
        }
    }
}
