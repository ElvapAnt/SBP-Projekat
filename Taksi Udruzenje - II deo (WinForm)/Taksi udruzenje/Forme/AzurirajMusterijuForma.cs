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
    public partial class AzurirajMusterijuForma : Form
    {
        RedovnaMusterijaBasic musterija;
        public AzurirajMusterijuForma()
        {
            InitializeComponent();
        }
        public AzurirajMusterijuForma(RedovnaMusterijaBasic musterija)
        {
            InitializeComponent();
            this.musterija = musterija;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbBrVoz.Text = musterija.BrojKoriscenihVoznji.ToString();
            txtAdresa.Text = musterija.Adresa;
            txtIdMusterije.Text = musterija.RedMusterijaId.ToString();
            txtIdMusterije.Enabled = false;
        }  
           
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            musterija.BrojKoriscenihVoznji = Int32.Parse(txbBrVoz.Text);
            musterija.Adresa = txtAdresa.Text;
            
            DTOProvider.azurirajMusteriju(musterija);
            MessageBox.Show("Uspesno ste izmenili podatke o musteriji !");
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
