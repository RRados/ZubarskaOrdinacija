using System;
using System.Windows.Forms;
using ZubarskaOrdinacija.Model;

namespace ZubarskaOrdinacija
{
    public partial class DodavanjeNovog : Form
    {
        private OsnovnaForma frmOsnovna;
        private PodaciBaza podaci;
        private Osoba osoba;




        public DodavanjeNovog(OsnovnaForma frmOsnovna)
        {
            InitializeComponent();

            osoba = new Osoba();
            podaci = new PodaciBaza();

            this.frmOsnovna = frmOsnovna;

            UcitavanjePodatakaCombo();

            CiscenjeKontrola();
        }





        // AKO JE FORMA this.text IME LEKARA ILI PACIJENTA, POZIVA SE ODGOVARAJUCA METODA ZA UNOS
        private void btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            if (this.Text == "Novi pacijent")
            {
                UnosPacijent();
            }

            if (this.Text == "Novi lekar")
            {
                UnosLekara();
            }
        }





        //nakon unosa kontrole se prazne
        private void btn_Otkazi_Click(object sender, EventArgs e)
        {
            CiscenjeKontrola();

            this.Close();
        }






        #region POMOCNE METODE

        // pri podizanju forme, combo za izbor grada se puni
        public void UcitavanjePodatakaCombo()
        {
            combo_grad.DataSource = podaci.UcitajPodatke("SELECT DISTINCT NazivGrada FROM Gradovi");
            combo_grad.DisplayMember = "NazivGrada";
        }





        // na uspesan unos Lekara, kontrole se ciste,  forma ostaje aktivna, gridView se azurira
        public void UnosLekara()
        {
            PodaciBaza podaci = new PodaciBaza();

            if (!(txtBx_ime.Text == string.Empty && txtBx_prezime.Text == string.Empty && txtBx_email.Text == string.Empty && combo_grad.SelectedIndex == 0 && maskedTextBox_telefon.Text == string.Empty))
            {
                osoba.Ime = txtBx_ime.Text;
                osoba.Prezime = txtBx_prezime.Text;
                osoba.Email = txtBx_email.Text;
                osoba.Telefon = Convert.ToString(maskedTextBox_telefon.Text);
                osoba.Grad = Convert.ToInt32(combo_grad.SelectedIndex);

                podaci.UnosPodatka($"INSERT INTO Lekari VALUES ('{osoba.Ime}','{osoba.Prezime}','{osoba.Email}','{osoba.Telefon}','{osoba.Grad}')");
            }

            CiscenjeKontrola();
        }





        // na uspesan unos pacijenta, kontrole se ciste,  forma ostaje aktivna, gridView se azurira
        public void UnosPacijent()
        {
            PodaciBaza podaci = new PodaciBaza();

            if (!(txtBx_ime.Text == string.Empty && txtBx_prezime.Text == string.Empty && txtBx_email.Text == string.Empty && combo_grad.SelectedIndex == 0 && maskedTextBox_telefon.Text == string.Empty))
            {
                osoba.Ime = txtBx_ime.Text;
                osoba.Prezime = txtBx_prezime.Text;
                osoba.Email = txtBx_email.Text;
                osoba.Telefon = Convert.ToString(maskedTextBox_telefon.Text);
                osoba.Grad = Convert.ToInt32(combo_grad.SelectedIndex);

                podaci.UnosPodatka($"INSERT INTO Pacijenti VALUES ('{osoba.Ime}','{osoba.Prezime}','{osoba.Email}','{osoba.Telefon}','{osoba.Grad}')");
            }

            CiscenjeKontrola();
        }





        // nakon unosa kontrole se prazne
        public void CiscenjeKontrola()
        {
            txtBx_ime.Clear();
            txtBx_prezime.Clear();
            combo_grad.Text = null;
            txtBx_email.Clear();
            maskedTextBox_telefon.Clear();
        }

        #endregion


    }
}
