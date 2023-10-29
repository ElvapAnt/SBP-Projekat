using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taksi_udruzenje.Forme;

namespace Taksi_Udruzenje
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            SviZaposleniForma forma = new SviZaposleniForma();
            forma.ShowDialog();
        }

        private void btnVoznje_Click(object sender, EventArgs e)
        {
            SveVoznjeForma forma = new SveVoznjeForma();
            forma.ShowDialog();
        }

        private void btnTaxiVozila_Click(object sender, EventArgs e)
        {
            TaxiVozilaForma forma = new TaxiVozilaForma();
            forma.ShowDialog();
        }

        private void btnDodeljeno_Click(object sender, EventArgs e)
        {
            SveDodeljenoForma forma = new SveDodeljenoForma();
            forma.ShowDialog();
        }

        private void btnRedMusterije_Click(object sender, EventArgs e)
        {
            RedovneMusterijeForma forma = new RedovneMusterijeForma();
            forma.ShowDialog();
        }
    }
}
