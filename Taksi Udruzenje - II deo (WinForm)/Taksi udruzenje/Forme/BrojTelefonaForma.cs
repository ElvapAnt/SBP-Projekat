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
    public partial class BrojTelefonaForma : Form
    {
        public BrojTelefonaForma()
        {
            InitializeComponent();
        }
        public int idMusterije = -1;
        public BrojTelefonaForma(int id)
        {
            idMusterije = id;
            InitializeComponent();
        }
        private void BrojTelefonaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima(idMusterije);
            groupBox1.Text = "Brojevi telefona -" + " Id Musterije : " + idMusterije.ToString();
        }
        public void popuniPodacima(int id)
        {
            this.telefoni.Items.Clear();
            List<BrojTelefonaBasic> sviBrojevi = DTOProvider.vratiBrojeveTelefonaMusterije(id);
            foreach (BrojTelefonaBasic broj in sviBrojevi)
            {
                ListViewItem item = new ListViewItem(new string[] { broj.BrTel });
                this.telefoni.Items.Add(item);
            }
            this.telefoni.Refresh();
        }
    }
}
