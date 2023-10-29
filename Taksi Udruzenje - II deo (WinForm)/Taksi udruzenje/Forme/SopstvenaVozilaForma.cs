using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taksi_Udruzenje;
using Taksi_Udruzenje.Entiteti;

namespace Taksi_udruzenje.Forme
{
    public partial class SopstvenaVozilaForma : Form
    {
        VozacBasic vozac = null;
        List<SopstvenoVoziloBasic> vozilaBasic;
        List<SopstvenoVoziloView> vozilaView;
        public SopstvenaVozilaForma()
        {
            InitializeComponent();
        }
        public SopstvenaVozilaForma(VozacBasic vozac)
        {
            InitializeComponent();
            this.vozac = vozac;
        }

        private void VozaciForma_Load(object sender, EventArgs e)
        {
            if (vozac != null)
            {
                this.groupBox1.Text += "-" + vozac.ToString();
            }
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.sopVozila.Items.Clear();
            if(vozac == null)
            {
                vozilaView = DTOProvider.vratiSvaSopVozila();
                foreach (SopstvenoVoziloView sv in vozilaView)
                {
                    ListViewItem item = new ListViewItem(new string[] { sv.SopVoziloId.ToString(), sv.TipVozila, sv.Boja, sv.Marka, sv.DatumOd.ToString(), sv.DatumDo.ToString() });
                    this.sopVozila.Items.Add(item);
                }
            }
            else
            {
                vozilaBasic = DTOProvider.vratiSvaSopVozilaVozaca(vozac);
                foreach (SopstvenoVoziloBasic sv in vozilaBasic)
                {
                    ListViewItem item = new ListViewItem(new string[] { sv.SopVoziloId.ToString(), sv.TipVozila, sv.Boja, sv.Marka, sv.DatumOd.ToString(), sv.DatumDo.ToString() });
                    this.sopVozila.Items.Add(item);
                }
            }
            this.sopVozila.Refresh();
        }

        private void btnDodajSopVozilo_Click(object sender, EventArgs e)
        {
            DodajSopVoziloForma forma;
            if (this.vozac != null)
            {
                forma = new DodajSopVoziloForma(vozac);
            }
            else
            {
                forma = new DodajSopVoziloForma();
            }
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (sopVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sopstveno vozilo koje zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(sopVozila.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrano sopstveno vozilo?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOProvider.obrisiSopVozilo(id);
                MessageBox.Show("Brisanje sopstvenog vozila je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnAzurirajVozilo_Click(object sender, EventArgs e)
        {
            if (sopVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sopstveno vozilo koje zelite da izmenite!");
                return;
            }
            int id = Int32.Parse(sopVozila.SelectedItems[0].SubItems[0].Text);
            SopstvenoVoziloBasic sv = DTOProvider.vratiSopstvenoVozilo(id);
            AzurirajSopVoziloForma forma = new AzurirajSopVoziloForma(sv);
            forma.ShowDialog();
            popuniPodacima();

        }
    }
}
