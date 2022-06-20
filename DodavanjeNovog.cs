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
        Form1 form;
        PodaciBaza podaci;
        Osoba osoba;
        public string upit;


        public DodavanjeNovog()
        {
            InitializeComponent();
            osoba = new Osoba();
            podaci = new PodaciBaza();
        }

        private void DodavanjeNovog_Load(object sender, EventArgs e)
        {
            combo_grad.DataSource = podaci.UcitajPodatke("SELECT DISTINCT NazivGrada FROM Gradovi");
            combo_grad.DisplayMember = "NazivGrada";
            upit = $"INSERT into {podaci.tabela} (Ime, Prezime, Email, Telefon, FK_Grad) values({osoba.Ime}, {osoba.Prezime}, {osoba.Email}, {osoba.Telefon}, {combo_grad.SelectedIndex})".ToString();
        }


        public void UnosPodataka(string upit)
        {
            podaci = new PodaciBaza();
            this.upit = upit;

            osoba.Ime = txtBx_ime.Text;
            osoba.Prezime = txtBx_prezime.Text;
            osoba.Email = txtBx_email.Text;
            osoba.Grad = combo_grad.SelectedIndex.ToString();
            osoba.Telefon = int.Parse(maskedTextBox_telefon.Text); // problem konverzije maskedBoxa


            try
            {
                podaci.UnosPodatka(upit);

                MessageBox.Show("Podaci uspesno uneti");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }


        private void btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            UnosPodataka(upit);
        }


        private void btn_Otkazi_Click(object sender, EventArgs e)
        {
            txtBx_ime.Clear();
            txtBx_prezime.Clear();
            combo_grad.ResetText();
            txtBx_email.Clear();
            maskedTextBox_telefon.Clear();
        }
    }
}
