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
    public partial class Zakazivanje_pregleda : Form
    {
        private PodaciBaza podaciBaza;
        private OsnovnaForma frmOsnovna;
        private Zakazivanje zakazivanje;


        public Zakazivanje_pregleda(OsnovnaForma frmOsnovna)
        {
            InitializeComponent();
            this.frmOsnovna = frmOsnovna;
            podaciBaza = new PodaciBaza();
            zakazivanje = new Zakazivanje();
            Ucitaj_Combo();
        }


        // PRI PODIZANJU FORME POPUNJAVA SE COMBO ZA PACIJENTA I LEKARA
        public void Ucitaj_Combo()
        {
            combo_Lekar.DataSource = podaciBaza.UcitajPodatke("SELECT Ime FROM Lekari");
            combo_Lekar.DisplayMember = "Ime";
            combo_Lekar.Text = null;

            combo_Pacijent.DataSource = podaciBaza.UcitajPodatke("SELECT Ime FROM Pacijenti");
            combo_Pacijent.DisplayMember = "Ime";
            combo_Pacijent.Text = null;
        }



        // UNOS ZAKAZANOG PREGLEDA, LEKAR, PACIJENT, DATUM I OPIS
        private void Btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            if (combo_Pacijent.Text != null && combo_Lekar.Text != null && dateTimePicker.Value != null && txtBx_RazlogDolaska.Text != string.Empty)
            {
                podaciBaza.UnosPodatka($"INSERT INTO Zakazivanje VALUES ( '{combo_Pacijent.SelectedIndex}', '{combo_Lekar.SelectedIndex}', '{dateTimePicker.Value.Date.ToString("yyyyMMdd")}', '{txtBx_RazlogDolaska.Text}')");
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // ucitavanje (reload) tabele za sva zakazivanja prilikom unosa novog!
            frmOsnovna.Sva_Zakazivanja();

            ResetKontrola();
        }



        // RESETOVANJE KONTROLA NA KLIK
        private void Btn_Otkazi_Click(object sender, EventArgs e)
        {
            ResetKontrola();
        }




        // POMOCNA METODA ZA RESETOVANJE KONTROLA
        public void ResetKontrola()
        {
            txtBx_RazlogDolaska.Clear();
            combo_Pacijent.Text = null;
            combo_Lekar.Text = null;
            dateTimePicker.ResetText();
        }

    }
}
