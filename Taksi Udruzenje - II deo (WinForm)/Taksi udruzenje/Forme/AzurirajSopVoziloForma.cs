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
    public partial class AzurirajSopVoziloForma : Form
    {
        SopstvenoVoziloBasic sopVozilo;
        public AzurirajSopVoziloForma()
        {
            InitializeComponent();
        }
        public AzurirajSopVoziloForma(SopstvenoVoziloBasic sopVozilo)
        {
            InitializeComponent();
            this.sopVozilo = sopVozilo;
            sopVozilo.PripadaVozacu = new VozacBasic();
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbTip.Text = sopVozilo.TipVozila;
            txbJMBGVozaca.Text = sopVozilo.PripadaVozacu.Jmbg;
            txbJMBGVozaca.Enabled = false;
            txbBoja.Text = sopVozilo.Boja;
            if(sopVozilo.DatumDo != null)
            {
                dateDatumDo.Value = sopVozilo.DatumDo.Value;
            }
        }  
           
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            sopVozilo.TipVozila = txbTip.Text;
            sopVozilo.Marka = txbMarka.Text;
            sopVozilo.Boja = txbBoja.Text;
            sopVozilo.DatumDo = dateDatumDo.Value;
            
            DTOProvider.azurirajSopVozilo(sopVozilo);
            MessageBox.Show("Uspesno ste izmenili podatke o sopstvenom vozilu!");
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
