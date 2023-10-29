using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taksi_Udruzenje.Entiteti;
using Taksi_Udruzenje;

namespace Taksi_udruzenje.Forme
{
    public partial class AzurirajVozacaForma : Form
    {
        VozacBasic vozac;
        public AzurirajVozacaForma()
        {
            InitializeComponent();
        }
        public AzurirajVozacaForma(VozacBasic vozac)
        {
            InitializeComponent();
            this.vozac = vozac;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbIme.Text = vozac.Ime;
            txbJMBG.Text = vozac.Jmbg;
            txbJMBG.Enabled = false;
            txbPrezime.Text = vozac.Prezime;
            txbSrednjeSlovo.Text = vozac.SrednjeSlovo.ToString();
            txbBrDozvole.Text = vozac.BrojDozovole;
            txtAdresa.Text = vozac.Adresa;
            txtBrTel.Text = vozac.BrojTelefona;
        }  
           
        private void btnAzurirajVozaca_Click(object sender, EventArgs e)
        {
            vozac.Ime = txbIme.Text;
            vozac.SrednjeSlovo = Char.Parse(txbSrednjeSlovo.Text);
            vozac.Prezime = txbPrezime.Text;
            vozac.BrojDozovole = txbBrDozvole.Text;
            vozac.Adresa = txtAdresa.Text;
            vozac.BrojTelefona = txtBrTel.Text;
            
            DTOProvider.azurirajVozaca(vozac);
            MessageBox.Show("Uspesno ste izmenili podatke o vozacu!");
            this.Close();
        }
    }
}
