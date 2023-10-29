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
    public partial class DodeljenoForma : Form
    {
        TaxiVoziloBasic taxi = null;
        VozacBasic vozac = null;
        public DodeljenoForma()
        {
            InitializeComponent();
          
        }
        public DodeljenoForma(VozacBasic vozac)
        {
            InitializeComponent();
            this.vozac = vozac;
            txbJMBGVozaca.Text = vozac.Jmbg;
           
        }
        public DodeljenoForma(TaxiVoziloBasic taxi)
        {
            InitializeComponent();
            this.taxi = taxi;
            txbRegOznaka.Text = taxi.RegistarskaOznaka;
            
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            DodeljenoBasic d = new DodeljenoBasic();
            d.TaxiVozilo = new TaxiVoziloBasic();
            d.Vozac = new VozacBasic();

            d.TaxiVozilo.RegistarskaOznaka = txbRegOznaka.Text;
            d.Vozac.Jmbg = txbJMBGVozaca.Text;


            d.DatumOd = datumOdPick.Value;
            if (chkDatumDo.Checked == false)
            {
                d.DatumDo = datumDoPick.Value;
            }
            else
            {
                d.DatumDo = null;
            }

            DTOProvider.sacuvajDodeljeno(d);

            MessageBox.Show("Uspesno sto dodelili taxi vozilo vozacu!");
        }
    }
}
