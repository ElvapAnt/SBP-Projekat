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
    public partial class AzurirajTaxiForma : Form
    {
        TaxiVoziloBasic taxi;
        public AzurirajTaxiForma()
        {
            InitializeComponent();
        }
        public AzurirajTaxiForma(TaxiVoziloBasic taxi)
        {
            InitializeComponent();
            this.taxi = taxi;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbTip.Text = taxi.Tip;
            txtRegOznaka.Text = taxi.RegistarskaOznaka;
            txtRegOznaka.Enabled = false;
            txtGodProizv.Text = taxi.GodinaProizvodnje.ToString();
            datumIstekaReg.Value = taxi.DatumIstekaRegistracije;
        }  
           
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            taxi.Tip = txbTip.Text;
            taxi.Marka = txbMarka.Text;
            taxi.GodinaProizvodnje = Int32.Parse(txtGodProizv.Text);
            taxi.DatumIstekaRegistracije = datumIstekaReg.Value;
            
            DTOProvider.azurirajTaxiVozilo(taxi);
            MessageBox.Show("Uspesno ste izmenili podatke o taxi vozilu!");
            this.Close();
        }

        private void txbBrDozvole_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
