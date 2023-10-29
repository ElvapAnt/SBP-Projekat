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
    public partial class DodajAdminaForma : Form
    {
      
        public DodajAdminaForma()
        {
            InitializeComponent();
        }

        private void DodajAdminaForma_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajAdmina_Click(object sender, EventArgs e)
        {
            
            //Dodavanje Radnika
            AdministrativnoOsobljeBasic admin = new AdministrativnoOsobljeBasic();
            admin.Jmbg = txbJMBG.Text;
            admin.Ime = txbIme.Text;
            admin.SrednjeSlovo = Char.Parse(txbSrednjeSlovo.Text);
            admin.Prezime = txbPrezime.Text;
            admin.StrucnaSprema = txbStrucnaSprema.Text;
            admin.Adresa = txtAdresa.Text;
            admin.BrojTelefona = txtBrTel.Text;

            DTOProvider.dodajAdmina(admin);

            MessageBox.Show("Uspesno ste dodali novo administrativno osoblje!");
        }
    }
}
