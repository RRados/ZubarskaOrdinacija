using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZubarskaOrdinacija.Model;

namespace ZubarskaOrdinacija
{
    public partial class OsnovnaForma : Form
    {
        private PodaciBaza podaciBaza;
        private DodavanjeNovog frm_novi;
        private Zakazivanje_pregleda zakazivanje;

        public OsnovnaForma()
        {
            InitializeComponent();

            podaciBaza = new PodaciBaza();
            zakazivanje = new Zakazivanje_pregleda(this);

            UcitajPacijenteZaDanas();
        }



        // // IZMENA TEXTA(Imena) FORME I POSTAVLJANJE NOVE IKONE
        private void Dodavanje_Novog_Pacijenta_MenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog(this);

            frm_novi.Text = "Novi pacijent";
            frm_novi.Icon = new Icon("../../Ikone/person.ico");

            frm_novi.Show();
        }




        // IZMENA TEXTA(Imena) FORME I POSTAVLJANJE NOVE IKONE
        private void Dodavanje_Novog_Lekara_MenuItem_Click(object sender, EventArgs e)
        {
            frm_novi = new DodavanjeNovog(this);

            frm_novi.Text = "Novi lekar";
            frm_novi.Icon = new Icon("../../Ikone/doctor.ico");

            frm_novi.Show();
        }




        // context menu item 'osvezi' ucitava glavnu formu iznova
        private void Osvezi_TsMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_InfoGrid.Text == "Spisak svih lekara")
                SpisakSvihLekara();

            if (lbl_InfoGrid.Text == "Spisak svih pacijenata")
                SpisakSvihPacijenata();

            if (lbl_InfoGrid.Text == "Zakazivanja za danas")
                UcitajPacijenteZaDanas();

            if (lbl_InfoGrid.Text == "Svi pregledi")
                Svi_Pregledi();

            if (lbl_InfoGrid.Text == "Sva zakazivanja")
                Sva_Zakazivanja();
        }





        // context menu item 'obrisi', desnim klikom na 'obrisi' brise izabranu vrednost iz dataGridView-a i ponovo se ucitavaju podaci iz baze
        private void Obrisi_TsMenuItem_Click(object sender, EventArgs e)
        {
            PodaciBaza podaciBaza = new PodaciBaza();

            int idPacijtenta = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            string upitObrisi = $"DELETE FROM Pacijenti WHERE IDPacijent='{idPacijtenta}'";

            podaciBaza.Obrisi(upitObrisi);

            SpisakSvihPacijenata();
        }




        // dva event-a spojena u jednom: objektom 'sender' se hvata vrednost klik-a (vraca Lekar ili Pacijent), prikaz svih PACIJENTA I LEKARA su registrovani na ovu metodu
        private void Osobe_TsMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Lekari")
            {
                lbl_InfoGrid.Text = "Spisak svih lekara";
                SpisakSvihLekara();

            }


            if (sender.ToString() == "Pacijenti")
            {
                lbl_InfoGrid.Text = "Spisak svih pacijenata";

                SpisakSvihPacijenata();
            }

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }





        // SVI PREGLEDI UNAZAD I ZAKAZANI
        private void SviPregledi_TsMenuItem_Click(object sender, EventArgs e)
        {
            Svi_Pregledi();
        }




        // SVA ZAKAZIVANJA UNAZAD I UNAPRED
        private void PrikazSvihZakazivanja_TsMenuItem_Click(object sender, EventArgs e)
        {
            Sva_Zakazivanja();
        }




        private void Zakazivanje_Novog_Pregleda_TsMenuItem_Click(object sender, EventArgs e)
        {
            Zakazivanje_pregleda zakazivanje = new Zakazivanje_pregleda(this);
            zakazivanje.Show();
        }




        // pretraga  pacijenata... 
        private void Btn_pretraga_Click(object sender, EventArgs e)
        {
            if (txtBx_pretraga.Text != string.Empty)
            {
                Pretraga();
            }
            else
            {
                MessageBox.Show("Popunite polje za pretragu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pretraga();
            }

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }





        #region POMOCNE METODE VOID

        // pretraga imena u zakazanim pregledima
        public void Pretraga()
        {
            SqlConnection connection = new SqlConnection(CnnString.cnn);

            try
            {
                using (SqlCommand command = new SqlCommand("PretragaZakazivanjaPoImenu", connection))
                {
                    connection.Open();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@imePacijenta", txtBx_pretraga.Text);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
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



        // SVI ZAKAZANI PACIJENTI I LEKARI SA DANASNJIM DATUMOM
        public void UcitajPacijenteZaDanas()
        {
            dataGridView.DataSource = podaciBaza.UcitajPodatke("select pac.IDPacijent AS 'Redni broj', pac.Ime + ' ' + pac.Prezime as Pacijent, lek.Ime + ' ' + lek.Prezime AS 'Lekar' , zak.ZastoPacijentDolazi AS 'Razlog dolaska', zak.DatumIVremeDolaska AS 'DATUM' from Pacijenti pac inner join Zakazivanje zak  on pac.IDPacijent = zak.FK_Pacijent inner join Lekari lek on zak.FK_Lekar = lek.IDLekar where CAST(DatumIVremeDolaska AS date) = CAST(GETDATE() AS date)");

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }




        public void Sva_Zakazivanja()
        {
            lbl_InfoGrid.Text = "Sva zakazivanja";

            dataGridView.DataSource = podaciBaza.UcitajPodatke("select pac.IDPacijent AS 'Redni broj', pac.Ime + ' ' + pac.Prezime as Pacijent, lek.Ime + ' ' + lek.Prezime AS 'Lekar' , zak.ZastoPacijentDolazi AS 'Razlog dolaska', zak.DatumIVremeDolaska AS 'DATUM' from Pacijenti pac inner join Zakazivanje zak  on pac.IDPacijent = zak.FK_Pacijent inner join Lekari lek on zak.FK_Lekar = lek.IDLekar");

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }




        // SVI PREGLEDI UNAZAD I ZAKAZANI
        public void Svi_Pregledi()
        {
            lbl_InfoGrid.Text = "Svi pregledi";

            dataGridView.DataSource = podaciBaza.UcitajPodatke($"select ip.IDIzvrseniPregledi AS 'Broj usluge', pac.Ime + ' ' + pac.Prezime AS 'Pacijent', lek.Ime + ' ' + lek.Prezime AS 'Lekar', ip.Anamneza, ip.Dijagnoza, ip.CenaPregleda, ip.Datum, usl.NazivUsluge from IzvrseniPregledi ip inner join Pacijenti pac on ip.FK_Pacijent = pac.IDPacijent inner join Lekari lek on ip.FK_Lekar = lek.IDLekar inner join Usluge usl on ip.FK_Usluga = usl.ID_Usluga");

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }




        // SPISAK SVIH PACIJENATA
        public void SpisakSvihPacijenata()
        {
            dataGridView.DataSource = podaciBaza.UcitajPodatke("SELECT l.IDPacijent, l.Ime, l.Prezime, l.Telefon, l.Email, g.NazivGrada FROM Pacijenti l INNER JOIN Gradovi g ON g.IDGrad = l.FK_Grad");

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }




        // SPISAK SVIH LEKARA
        public void SpisakSvihLekara()
        {
            dataGridView.DataSource = podaciBaza.UcitajPodatke("SELECT l.Ime, l.Prezime, l.Telefon, l.Email, g.NazivGrada FROM Lekari l INNER JOIN Gradovi g ON g.IDGrad = l.FK_Grad");

            lbl_ukupno.Text = dataGridView.RowCount.ToString();
        }


        #endregion
    }
}
