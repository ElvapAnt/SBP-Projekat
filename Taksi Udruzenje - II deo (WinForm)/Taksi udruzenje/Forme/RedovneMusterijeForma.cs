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
    public partial class RedovneMusterijeForma : Form
    {
        public RedovneMusterijeForma()
        {
            InitializeComponent();
        }
        private void RedovneMusterijeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.musterije.Items.Clear();
            List<RedovnaMusterijaView> sveMusterije = DTOProvider.vratiSveRedovneMusterije();
            foreach (RedovnaMusterijaView rm in sveMusterije)
            {
                ListViewItem item = new ListViewItem(new string[] { rm.RedMusterijaId.ToString(),rm.Adresa,rm.BrojKoriscenihVoznji.ToString()});
                this.musterije.Items.Add(item);
            }
            this.musterije.Refresh();
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            DodajMusterijuForma forma = new DodajMusterijuForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnPopust_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju ciji popust zelite da izracunate!");
                return;
            }
            int id = Int32.Parse(this.musterije.SelectedItems[0].SubItems[0].Text);
            MessageBox.Show($"Musterija sa id-jem {id} je ostvarila popust od {DTOProvider.vratiPopustMusterije(id) * 100}%!");
        }

        private void btnAzurirajMusteriju_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju koju zelite da azurirate!");
                return;
            }
            int id = Int32.Parse(this.musterije.SelectedItems[0].SubItems[0].Text);
            RedovnaMusterijaBasic musterija = DTOProvider.vratiMusteriju(id);
            AzurirajMusterijuForma forma = new AzurirajMusterijuForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnBrojeviTelefona_Click(object sender, EventArgs e)
        {
            if (musterije.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite musteriju cije brojeve telefona zelite da pregledate!");
                return;
            }
            int id = Int32.Parse(this.musterije.SelectedItems[0].SubItems[0].Text);
            BrojTelefonaForma forma = new BrojTelefonaForma(id);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
