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
    public partial class DodajSopVoziloForma : Form
    {
        VozacBasic vozac = null;
        public DodajSopVoziloForma(VozacBasic vozac)
        {
            this.vozac = vozac;
            InitializeComponent();
        }
        public DodajSopVoziloForma()
        {
            InitializeComponent();
        }

        private void DodajSopVoziloForma_Load(object sender, EventArgs e)
        {
            if(this.vozac != null)
            {
                txbJMBGVozaca.Text = vozac.Jmbg;
                txbJMBGVozaca.Enabled = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SopstvenoVoziloBasic sopVozilo = new SopstvenoVoziloBasic();
            if (this.vozac == null)
            {
                sopVozilo.PripadaVozacu = new VozacBasic();
                sopVozilo.PripadaVozacu.Jmbg = txbJMBGVozaca.Text;
            }

            sopVozilo.PripadaVozacu = vozac;
            sopVozilo.PripadaVozacu.Jmbg = txbJMBGVozaca.Text;
            sopVozilo.TipVozila = txbTip.Text;
            sopVozilo.Marka = txbMarka.Text;
            sopVozilo.Boja = txbBoja.Text;
            sopVozilo.DatumOd = dateDatumOd.Value;
            
            if (chbDatumDo.Checked == false)
            {
                sopVozilo.DatumDo = dateDatumDo.Value;
            }
      
            DTOProvider.dodajSopstvenoVozilo(sopVozilo);

            MessageBox.Show("Uspesno ste dodali novo sopstveno vozilo!");
        }
    }
}
