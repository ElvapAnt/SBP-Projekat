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
    public partial class AzurirajDodeljenoForma : Form
    {
        DodeljenoBasic d;
        public AzurirajDodeljenoForma()
        {
            InitializeComponent();
        }
        public AzurirajDodeljenoForma(DodeljenoBasic dodeljeno)
        {
            InitializeComponent();
            d = dodeljeno;
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            txbJMBGVozaca.Text = d.Vozac.Jmbg;
            txbRegOznaka.Text = d.TaxiVozilo.RegistarskaOznaka;
            datumDoPick.Value = d.DatumDo.Value;
            datumOdPick.Value = d.DatumDo.Value;
        }
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            d.DatumOd = datumOdPick.Value;
            d.DatumDo = datumDoPick.Value;

            d.TaxiVozilo = new TaxiVoziloBasic();
            d.Vozac = new VozacBasic();

            d.TaxiVozilo.RegistarskaOznaka = txbRegOznaka.Text;
            d.Vozac.Jmbg = txbJMBGVozaca.Text;


            if (chkDatumDo.Checked == false)
            {
                d.DatumDo = datumDoPick.Value;
            }

            DTOProvider.azurirajDodeljeno(d);

            MessageBox.Show("Uspesno ste azurirali dodeljeno odnos!");
        }
    }
}
