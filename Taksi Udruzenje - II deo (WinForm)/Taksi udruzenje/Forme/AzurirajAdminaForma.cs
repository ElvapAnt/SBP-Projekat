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
    public partial class AzurirajAdminaForma : Form
    {
        AdministrativnoOsobljeBasic admin;
        public AzurirajAdminaForma()
        {
            InitializeComponent();
        }
        public AzurirajAdminaForma(AdministrativnoOsobljeBasic admin)
        {
            InitializeComponent();
            this.admin = admin;
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            txbIme.Text = admin.Ime;
            txbJMBG.Text = admin.Jmbg;
            txbJMBG.Enabled = false;
            txbPrezime.Text = admin.Prezime;
            txbSrednjeSlovo.Text = admin.SrednjeSlovo.ToString();
            txbStrucnaSprema.Text = admin.StrucnaSprema;
            txtAdresa.Text = admin.Adresa;
            txtBrTel.Text = admin.BrojTelefona;
        }  
           
        private void btnAzurirajAdmina_Click(object sender, EventArgs e)
        {
            admin.Ime = txbIme.Text;
            admin.SrednjeSlovo = Char.Parse(txbSrednjeSlovo.Text);
            admin.Prezime = txbPrezime.Text;
            admin.StrucnaSprema = txbStrucnaSprema.Text;
            admin.Adresa = txtAdresa.Text;
            admin.BrojTelefona = txtBrTel.Text;
            //radnik.Sef = false;
            
            DTOProvider.azurirajAdmina(admin);
            MessageBox.Show("Uspesno ste izmenili podatke o administrativnom osoblju!");
            this.Close();
        }
    }
}
