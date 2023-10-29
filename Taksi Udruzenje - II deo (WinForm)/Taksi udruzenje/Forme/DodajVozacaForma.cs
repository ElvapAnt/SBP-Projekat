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
    public partial class DodajVozacaForma : Form
    {
      
        public DodajVozacaForma()
        {
            InitializeComponent();
        }

        private void DodajVozacaForma_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {
            
            VozacBasic vozac = new VozacBasic();
            vozac.Jmbg = txbJMBG.Text;
            vozac.Ime = txbIme.Text;
            vozac.SrednjeSlovo = Char.Parse(txbSrednjeSlovo.Text);
            vozac.Prezime = txbPrezime.Text;
            vozac.BrojDozovole = txbBrDozvole.Text;
            vozac.Adresa = txtAdresa.Text;
            vozac.BrojTelefona = txtBrTel.Text;
            vozac.Kategorija = 'B';

            DTOProvider.dodajVozaca(vozac);

            MessageBox.Show("Uspesno ste dodali novog vozaca!");
        }
    }
}
