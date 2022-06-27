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
        private Osoba osoba;
        private Zakazivanje zakazivanje;

        public Zakazivanje_pregleda()
        {
            InitializeComponent();
            podaciBaza = new PodaciBaza();
            osoba = new Osoba();
            zakazivanje = new Zakazivanje();

            Ucitaj_Combo();
        }
        DateTime date = new DateTime();

        public void Ucitaj_Combo()
        {
            combo_Lekar.DataSource = podaciBaza.UcitajPodatke("SELECT Ime FROM Lekari");
            combo_Lekar.DisplayMember = "Ime";
            combo_Lekar.Text = null;

            combo_Pacijent.DataSource = podaciBaza.UcitajPodatke("SELECT Ime FROM Pacijenti");
            combo_Pacijent.DisplayMember = "Ime";
            combo_Pacijent.Text = null;
        }


        private void Btn_Sacuvaj_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToDateTime(dateTimePicker.Text).ToString()).ToString();

            //DateTime date = dateTimePicker.Value.Date;
            UnosZakazivanje($"INSERT INTO Zakazivanje VALUES ( '{combo_Pacijent.SelectedIndex}', '{combo_Lekar.SelectedIndex}', '{dateTimePicker.Value.Date.ToString("yyyyMMdd")}', '{txtBx_RazlogDolaska.Text}')");
        }

        public void UnosZakazivanje(string upit)
        {
            SqlConnection connection = new SqlConnection(CnnString.cnn);
            try
            {
                using (SqlCommand command = new SqlCommand(upit, connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.Text;

                    //command.Parameters.AddWithValue("@idPacijent", combo_Pacijent.SelectedValue);
                    //command.Parameters.AddWithValue("@idLekar", combo_Lekar.SelectedValue);
                    //command.Parameters.AddWithValue("@razlogDolaska", txtBx_RazlogDolaska.Text);
                    //command.Parameters.AddWithValue("@datum", SqlDbType.Date).Value = dateTimePicker.Value.Date;

                    command.ExecuteNonQuery();

                    MessageBox.Show("Podaci uspesno uneti!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Btn_Otkazi_Click(object sender, EventArgs e)
        {
            txtBx_RazlogDolaska.Clear();
            combo_Pacijent.Text = null;
            combo_Lekar.Text = null;
            dateTimePicker.ResetText();
        }


    }
}
