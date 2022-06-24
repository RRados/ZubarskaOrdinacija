using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZubarskaOrdinacija.Model;

namespace ZubarskaOrdinacija
{
    public partial class DodavanjeNovog : Form
    {
        PodaciBaza podaci;
        Osoba osoba;
        public string upit;

        public DodavanjeNovog()
        {
            InitializeComponent();
            osoba = new Osoba();
            podaci = new PodaciBaza();

            UcitavanjePodatakaCombo();
            CiscenjeKontrola();
        }


        public void UcitavanjePodatakaCombo()
        {
            combo_grad.DataSource = podaci.UcitajPodatke("SELECT DISTINCT NazivGrada FROM Gradovi");
            combo_grad.DisplayMember = "NazivGrada";
        }


        private void btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            UnosPacijenta();
        }


        // unos PACIJENT-a ... ne valja, izmeni upit da prihvati lekara i/ili pacijenta
        public void UnosPacijenta()
        {
            PodaciBaza podaci = new PodaciBaza();

            if (!(txtBx_ime.Text == string.Empty && txtBx_prezime.Text == string.Empty && txtBx_email.Text == string.Empty && combo_grad.SelectedIndex == 0 && maskedTextBox_telefon.Text == string.Empty))
            {
                osoba.Ime = txtBx_ime.Text;
                osoba.Prezime = txtBx_prezime.Text;
                osoba.Email = txtBx_email.Text;
                osoba.Telefon = Convert.ToString(maskedTextBox_telefon.Text);
                osoba.Grad = Convert.ToInt32(combo_grad.SelectedIndex);

                podaci.UnosPodatka($"INSERT INTO Lekari (Ime, Prezime, Email, Telefon, FK_Grad) values ( '{osoba.Ime}', '{osoba.Prezime}', '{osoba.Email}', '{osoba.Telefon}', '{osoba.Grad}' )");

            }
            // na uspesan unos, kontrole se ciste, forma ostaje aktivna...
            CiscenjeKontrola();
        }




        private void btn_Otkazi_Click(object sender, EventArgs e)
        {
            CiscenjeKontrola();
        }

        public void CiscenjeKontrola()
        {
            txtBx_ime.Clear();
            txtBx_prezime.Clear();
            combo_grad.ResetText();
            txtBx_email.Clear();
            maskedTextBox_telefon.Clear();
        }
    }
}
