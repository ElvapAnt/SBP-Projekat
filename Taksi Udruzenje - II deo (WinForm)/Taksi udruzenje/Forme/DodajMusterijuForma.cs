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
    public partial class DodajMusterijuForma : Form
    {
        public DodajMusterijuForma()
        {
            InitializeComponent();
        }

        private void DodajMusterijuForma_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            RedovnaMusterijaBasic rm = new RedovnaMusterijaBasic();
            rm.Adresa = txtAdresa.Text;
            string brTel = txtBrTel.Text;
            rm.BrojKoriscenihVoznji = Int32.Parse(txbBrVoz.Text);
            
            
            DTOProvider.dodajMusteriju(rm,brTel);

            MessageBox.Show("Uspesno ste dodali novog musteriju!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
