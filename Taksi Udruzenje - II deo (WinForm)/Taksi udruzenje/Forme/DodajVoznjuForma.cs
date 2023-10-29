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
    public partial class DodajVoznjuForma : Form
    {
        VozacBasic vozac = null;
        AdministrativnoOsobljeBasic admin = null;
        public DodajVoznjuForma()
        {
            InitializeComponent();
        }

        public DodajVoznjuForma(VozacBasic vozac, AdministrativnoOsobljeBasic admin)
        {
            InitializeComponent();
            this.vozac = vozac;
            this.admin = admin;
        }

        private void DodajVoznjuForma_Load(object sender, EventArgs e)
        {
            if(vozac != null)
            {
                txtJMBGVozaca.Text = vozac.Jmbg;
                txtJMBGVozaca.Enabled = false;
            }
            if (admin != null)
            {
                txtJMBGAdmina.Text = admin.Jmbg;
                txtJMBGAdmina.Enabled = false;
            }
        }

        private void btnDodajVoznju_Click(object sender, EventArgs e)
        {
            VoznjaBasic voznja = new VoznjaBasic();
            voznja.PocetnaStanica = txtPStanica.Text;
            voznja.KrajnjaStanica = txtKStanica.Text;
            voznja.PocetnoVreme = pVremePicker.Value;
            voznja.KrajnjeVreme = kVremePicker.Value;
            voznja.BrojPoziva = txtBrPoz.Text;
            voznja.VremePrimPoziva = dateTimePicker3.Value;
            voznja.PripadaVozacu = DTOProvider.vratiVozaca(txtJMBGVozaca.Text);
            voznja.PripadaAdministrativnomOsoblju = DTOProvider.vratiAdmina(txtJMBGAdmina.Text);

            if(checkBox1.Checked == false)
            {
                voznja.PripadaRedovnojMusteriji = DTOProvider.vratiMusteriju(Int32.Parse(txtMusterijaID.Text));
            }

            DTOProvider.dodajVoznju(voznja);

            MessageBox.Show("Uspesno ste dodali novu voznju!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) txtMusterijaID.Enabled = false;
            else txtMusterijaID.Enabled = true;
        }
    }
}
