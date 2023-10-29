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
    public partial class DodajTaxiVoziloForma : Form
    {
        public DodajTaxiVoziloForma()
        {
            InitializeComponent();
        }

        private void DodajTaxiVoziloForma_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            TaxiVoziloBasic taxiVozilo = new TaxiVoziloBasic();
            taxiVozilo.RegistarskaOznaka = txtRegOznaka.Text;
            taxiVozilo.Marka = txbMarka.Text;
            taxiVozilo.Tip = txbTip.Text;
            taxiVozilo.DatumIstekaRegistracije = datumIstekaReg.Value;
            taxiVozilo.GodinaProizvodnje = Int32.Parse(txtGodProizv.Text);
            
            DTOProvider.dodajTaxiVozilo(taxiVozilo);

            MessageBox.Show("Uspesno ste dodali novo taxi vozilo!");
        }
    }
}
